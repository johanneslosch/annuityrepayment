using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace annuityrepayment
{
    class Calculate
    {
        public static void calculate(double __tilgung, double __zinssatz, double __darlehn)
        {
            int jahr = 1;
            double saldo;
            double tilgung;
            double zinsen;
            double annuitaet = 0;
            double restschuld = 0;

            //TODO: clear file after each run
            double __repayment = (__darlehn * __zinssatz) + (__darlehn * __tilgung);
            jahr = 1;
        
            tilgung = __darlehn * __tilgung;
            zinsen = __darlehn * __zinssatz;
            annuitaet = tilgung + zinsen;
            restschuld = __darlehn - tilgung;
            writeToFile("Jahr " + jahr + "; Saldo: " + __darlehn + " €; Tilgung: " + tilgung + " €; Zinsen: " + zinsen + " €; Restschuld: " + restschuld + " €");
            do
            {
                Console.Write("\n");
                Console.Write("----------");
                /*calc second*/
                saldo = restschuld;
                zinsen = saldo * __zinssatz;
                tilgung = annuitaet - zinsen;
                restschuld = saldo - tilgung;
                jahr++;
                /*output*/
                writeToFile("Jahr " + jahr + "; Saldo: " + saldo + " €; Tilgung: " + tilgung + " €; Zinsen: " + zinsen + " €; Restschuld: " + restschuld + " €");
                Console.Write("\n");
                Console.Write("Jahr: ");
                Console.Write(jahr);
                Console.Write("\n");
                Console.Write("Saldo: ");
                Console.Write(saldo);
                Console.Write("\n");
                Console.Write("Tilgung: ");
                Console.Write(tilgung);
                Console.Write("\n");
                Console.Write("Zinsen: ");
                Console.Write(zinsen);
                Console.Write("\n");
                Console.Write("Annuitaet: ");
                Console.Write(annuitaet);
                Console.Write("\n");
                Console.Write("Restschuld: ");
                Console.Write(restschuld);
            } while (restschuld > 0);



                Console.WriteLine("tilgung " + __tilgung + " Zinssatz " + __zinssatz + "/ Darlehn " + __darlehn + "\n" + __repayment);
       }

        private static void writeToFile(String content)
        {
            File.AppendAllText(@"../../test1.txt", content + Environment.NewLine);

        }
    }
}

