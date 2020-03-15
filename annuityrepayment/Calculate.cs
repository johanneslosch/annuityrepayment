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
            double __repayment = (__darlehn * __zinssatz) + (__darlehn * __tilgung);
             writeToFile("Year 1 - Repayment: " + __repayment.ToString());

            Console.WriteLine("tilgung " + __tilgung + " Zinssatz " + __zinssatz + "/ Darlehn " + __darlehn + "\n" + __repayment);
       }

        private static void writeToFile(String content)
        {
            File.AppendAllText(@"../../test.txt", content + Environment.NewLine);

        }
    }
}
