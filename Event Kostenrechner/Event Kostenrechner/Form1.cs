using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Kostenrechner
{
    public partial class Form1 : Form
    {
        Abendessen abendessen;
        Geburtstagsfeier bdayparty;
        public Form1()
        {
            InitializeComponent();
            abendessen = new Abendessen() { Personenanzahl = 5 };
            abendessen.TrockenerAbendWählen(false);
            abendessen.DekoKostenBerechnen(false);
            AbendessenKostenAnzeigen();

            bdayparty = new Geburtstagsfeier() { Personenanzahl = 5, kuchenlabel = label6, kuchentextbox = textBox1 };

            panel2.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            abendessen.DekoKostenBerechnen(checkBox1.Checked);
            AbendessenKostenAnzeigen();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            abendessen.TrockenerAbendWählen(checkBox2.Checked); 
            AbendessenKostenAnzeigen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.Personenanzahl = (int) numericUpDown1.Value;
            AbendessenKostenAnzeigen();
        }

        private void AbendessenKostenAnzeigen()
        {
            decimal kosten = abendessen.KostenBerechnen(checkBox2.Checked);
            kostenlabel.Text = kosten.ToString("c");
        }

        private void GeburtstagsfeierKostenAnzeigen()
        {
            decimal kosten = bdayparty.KostenBerechnen((decimal)textBox1.Text.Length);
            kostenlabel2.Text = kosten.ToString("c");
        }

        private void AbendessenTab_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            GeburtstagsfeierKostenAnzeigen();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bdayparty.Personenanzahl = (int)numericUpDown2.Value;
            GeburtstagsfeierKostenAnzeigen();

            bdayparty.KuchengrößeBerechnen();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bdayparty.Kuchentext = textBox1.Text.ToString();
                //label6.Text = bdayparty.Kuchentext;
                
                GeburtstagsfeierKostenAnzeigen();
            }
            catch (Exception)
            {
                
            }
        }

        private void bdaycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bdayparty.DekoKostenBerechnen(bdaycheckbox.Checked);
            GeburtstagsfeierKostenAnzeigen();
        }
    }
}
