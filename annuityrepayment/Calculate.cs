using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace annuityrepayment
{
    class Calculate
    {
        public static void calculate(double __tilgung, double __zinssatz, double __dalehn)
        {
            //zinsen + tilgung? (im ersten jahr und dann.... ja)
            double __repayment;

            

            __repayment = __dalehn * __zinssatz *__tilgung;



            //writeToFile(tilgung.ToString());
            Console.WriteLine("tilgung " + __tilgung + " Zinssatz " + __zinssatz + "/ Darlehn " + __dalehn);
       }

        private static void writeToFile(String content)
        {
            File.AppendAllText(@"../../test.txt", content + Environment.NewLine);

        }
    }
}
