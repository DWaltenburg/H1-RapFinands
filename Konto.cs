using System;
using System.Collections.Generic;
namespace Rap_Finands
{
    class Konto
    {
        public string registreringsnr;
        public string kontonr;
        public string ejer;
        public List<Transaktion> transaktioner;
        public Konto()
        {
            transaktioner = new List<Transaktion>();
            registreringsnr = "4242"; //Sæt registreringsnummer på kontoen! //flyttet variabeldeklaration
            kontonr = lavEtKontoNummer(); //Lav et nyt (tilfældigt shh!) kontonummer
        }
        //Flyttet kontonummergenerering til konto klassen
        /*
        fed metode til at lave helt nye kontonumre ~Konrad
        */
        private static string lavEtKontoNummer()
        {
            Random tilfael = new Random();
            string nr = tilfael.Next(1, 9).ToString();
            for (var i = 1; i <= 9; i++)
            {
                nr = nr + tilfael.Next(0, 9).ToString();
                if (i == 3) nr = nr + " ";
                if (i == 6) nr = nr + " ";
            }
            return nr;
        }

    }
}
/** 
Koden er lavet til undervisningbrug på TECHCOLLEGE
Voldum Bank og nævnte personer er fiktive.
~Simon Hoxer Bønding
**/