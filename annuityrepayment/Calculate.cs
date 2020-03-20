using System;
using System.IO;

namespace annuityrepayment
{
    class Calculate
    {
        public static void calculate(double __tilgung, double __zinssatz, double __darlehn)
        {
            int jahr = 1;
            double saldo = __darlehn;
            double tilgung;
            double zinsen;
            double annuitaet = 0;
            double restschuld = 0;

            //TODO: clear file after each run
            double __repayment = (__darlehn * __zinssatz) + (__darlehn * __tilgung);
            jahr = 1;
        
            tilgung = saldo * __tilgung;
            zinsen = saldo * __zinssatz;
            annuitaet = tilgung + zinsen;
            restschuld = saldo - tilgung;
            writeToFile(String.Format("Jahr {0}; Saldo: {1} €; Tilgung: {2} €; Zinsen: {3} €; Annuität: {4} €; Restschuld: {5} €", jahr, Math.Round(saldo, 2), Math.Round(tilgung, 2), Math.Round(zinsen, 2), Math.Round(annuitaet, 2), Math.Round(restschuld, 2)));
            do
            {
                saldo = restschuld;
                zinsen = saldo * __zinssatz;
                tilgung = annuitaet - zinsen;
                restschuld = saldo - tilgung;
                jahr++;

                writeToFile(String.Format("Jahr {0}; Saldo: {1} €; Tilgung: {2} €; Zinsen: {3} €; Annuität: {4} €; Restschuld: {5} €", jahr, Math.Round(saldo, 2), Math.Round(tilgung, 2), Math.Round(zinsen, 2), Math.Round(annuitaet, 2), Math.Round(restschuld, 2)));
                if (restschuld <= annuitaet)
                {
                    saldo = restschuld;
                    zinsen = saldo * __zinssatz;
                    annuitaet = zinsen + restschuld;
                    tilgung = restschuld + zinsen;
                    restschuld = 0;
                    jahr++;
                    writeToFile(String.Format("Jahr {0}; Saldo: {1} €; Tilgung: {2} €; Zinsen: {3} €; Annuität: {4} €; Restschuld: {5} €", jahr, Math.Round(saldo, 2), Math.Round(tilgung, 2), Math.Round(zinsen, 2), Math.Round(annuitaet, 2), Math.Round(restschuld, 2)));
                    restschuld = 0;
                }
            } while (restschuld > 0);
       }

        private static void writeToFile(String content)
        {
            File.AppendAllText(@".\test1.txt", content + Environment.NewLine);

        }
    }
}

