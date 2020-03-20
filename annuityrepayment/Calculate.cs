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
           
            //TODO: clear file after each run
            double __repayment = (__darlehn * __zinssatz) + (__darlehn * __tilgung);
             writeToFile("Year 1 - darlehn after: " + (__darlehn - __repayment));
            //double y2 = __darlehn - __repayment - __repayment;
            //writeToFile("Year 2 - darlehn after: " + y2);
            int year = 2;
            //
            while(__repayment > 0)
            {
                Console.WriteLine(year);
                double y2 = __darlehn - __repayment - __repayment;
                __repayment = y2;
                writeToFile("Year " + year + ": " + y2);
                year++;
            }

            /**
            do
            {
                /*calc second
                saldo = restschuld;
                zinsen = saldo * zinssatz / 100;
                tilgung = annuitaet - zinsen;
                restschuld = saldo - tilgung;
                jahr++;
                /*output
                cout << endl << "Jahr: " << jahr;
                cout << endl << "Saldo: " << saldo;
                cout << endl << "Tilgung: " << tilgung;
                cout << endl << "Zinsen: " << zinsen;
                cout << endl << "Annuitaet: " << annuitaet;
                cout << endl << "Restschuld: " << restschuld;

            } while (restschuld > 0);
            */

            Console.WriteLine("tilgung " + __tilgung + " Zinssatz " + __zinssatz + "/ Darlehn " + __darlehn + "\n" + __repayment);
       }

        private static void writeToFile(String content)
        {
            File.AppendAllText(@"../../test.txt", content + Environment.NewLine);

        }
    }
}
