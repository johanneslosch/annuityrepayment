using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace annuityrepayment
{
    class Calculate
    {
        public static void calculate(Double tilgung, Double zinssatz, Double dalehn)
        {
            //writeToFile(tilgung.ToString());
            Console.WriteLine("tilgung " + tilgung + " Zinssatz " + zinssatz + "/ Darlehn " + dalehn);
        }
        private static void writeToFile(String content)
        {
            File.AppendAllText(@"../../test.txt", content + Environment.NewLine);

        }
    }
}
