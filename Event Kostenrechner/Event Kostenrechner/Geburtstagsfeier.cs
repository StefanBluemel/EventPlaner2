using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Kostenrechner
{
    class Geburtstagsfeier
    {
        public int Personenanzahl;

        public decimal Dekokosten = 7.50M;
        public int DekoPauschale = 30;

        public int Kuchengröße = 26;
        public int Tortenpauschale = 75;

        public Label kuchenlabel;             // reference for a Label Object from the class Form1
        public TextBox kuchentextbox;         // reference for a Textbox Object from the class Form1

        public string kuchentext = "";      // Support variable for Kuchentext
        public int maxlänge;            // Support variable for Kuchentext (will be changed from outside of this class as well)
        public string Kuchentext
        {
            get
            {
                return this.kuchentext;
            }
            set
            {
               
                if (Personenanzahl <= 4)
                {
                    maxlänge = 16;
                }
                else
                {
                    maxlänge = 40;
                }
                if (value.Length > maxlänge)
                {
                    MessageBox.Show("Text zu lang für " + Kuchengröße + " -´cm-Kuchen, max. " + maxlänge  + " Zeichen erlaubt" );

                    this.kuchentext = kuchentext.Substring(0, maxlänge);      //deletes last character in the kuchentext var

                    kuchentextbox.Text = kuchentext.Substring(0, maxlänge);  //deletes last character in the kuchentextbox var
                    kuchentextbox.SelectionStart = kuchentextbox.Text.Length; //puts the cursor back at the end of the textbox after the above code-line messes up the position unintenional

                    //kuchenlabel.Text = Kuchentext;
                }
                else
                {
                    this.kuchentext = value;
                }
                
            }
        }

        public void DekoKostenBerechnen(bool Deko_Option_eins_oder_zwei)
        {
            if (Deko_Option_eins_oder_zwei == true)
            {
                Dekokosten = 15.0M;
                DekoPauschale = 50;
            }
            else
            {
                Dekokosten = 7.5M;
                DekoPauschale = 30;
            }
        }

        public void KuchengrößeBerechnen()
        {
            if (Personenanzahl <= 4)
            {
                maxlänge = 16;
                Kuchengröße = 18;
                Tortenpauschale = 40;
                Kuchentext = kuchentext;
            }
            else
            {
                maxlänge = 40;
                Kuchengröße = 28;
                Tortenpauschale = 70;
            }
        }


        public decimal KostenBerechnen(decimal zahl) //Gesamtkosten - Totalcosts 
        {
            decimal Kosten;


            Kosten = (Personenanzahl * 25 + zahl * 0.25M
                + Personenanzahl * Dekokosten + DekoPauschale + Tortenpauschale);
            
            
            return Kosten;
        }
    }
}