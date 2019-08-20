using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Kostenrechner
{
    class Abendessen
    {
        public int Personenanzahl;
        
        public decimal GetränkeKostenProPerson; // example for decimal variable (var = 123.0M;)

        public decimal DekoKosten;
        public int DekoPauschale = 30;
        
        public const int EssensKostenProPerson = 25;



        public void TrockenerAbendWählen(bool Alkohol_JA_NEIN)
        {
            if(Alkohol_JA_NEIN== true)
            {
                GetränkeKostenProPerson = 5.0M;
            }
            else
            {
                GetränkeKostenProPerson = 20.0M;
            }
        }

        public void DekoKostenBerechnen(bool Deko_Option_eins_oder_zwei)
        {
            if (Deko_Option_eins_oder_zwei == true)
            {
                DekoKosten = 15.0M;
                DekoPauschale = 50;
            }
            else
            {
                DekoKosten = 7.5M;
                DekoPauschale = 30;
            }
        }


        public decimal KostenBerechnen(bool ischecked) //Gesamtkosten
        {
            decimal Kosten;
            if (ischecked)
            {
                
                Kosten = (Personenanzahl * 25 + Personenanzahl * GetränkeKostenProPerson 
                    + Personenanzahl * DekoKosten + DekoPauschale)*0.95M;
            }
            else
            {
                Kosten = (Personenanzahl * 25 + Personenanzahl * GetränkeKostenProPerson
                    + Personenanzahl * DekoKosten + DekoPauschale);
            }
            return Kosten;
        }
    }
}
