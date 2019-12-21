using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace InfoReaderV2
{
    class Derivat
    {
        CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
        public static int[] dizel;
        public static int[] dizelR2;
        public static int[] dizelR3;
        public static int[] litBmb95;
        public static int[] litBmb95R2;
        public static int[] litBmb98;
        public static int[] eudGold;
        public static int[] gasnoUlje;


        public int[] TabelaZapremine;



       public enum NazivDerivata { Dizel,DizelR2,DizelR3,LitBmb95, LitBmb95R2,LitBmb98,EudGold,GasnoUlje };

       public NazivDerivata nazivDerivata { get; set; }

        private static bool benzin;

        public Derivat(NazivDerivata der)
        {
            this.nazivDerivata = der;


            switch (nazivDerivata)
            {
                case NazivDerivata.Dizel:
                    TabelaZapremine = dizel;
                    benzin = false;
                    break;
                case NazivDerivata.DizelR2:
                    TabelaZapremine = dizelR2;
                    benzin = false;
                    break;
                case NazivDerivata.DizelR3:
                    TabelaZapremine = dizelR3;
                    benzin = false;
                    break;
                case NazivDerivata.LitBmb95:
                    TabelaZapremine = litBmb95;
                    benzin = true;
                    break;
                case NazivDerivata.LitBmb95R2:
                    TabelaZapremine = litBmb95R2;
                    benzin = true;
                    break;
                case NazivDerivata.LitBmb98:
                    TabelaZapremine = litBmb98;
                    benzin = true;
                    break;
                case NazivDerivata.EudGold:
                    TabelaZapremine = eudGold;
                    benzin = false;
                    break;
                case NazivDerivata.GasnoUlje:
                    TabelaZapremine = gasnoUlje;
                    benzin = false;
                    break;
                default:
                    break;
            }
        }

        //izracunati litrazu iz zadatog nivoa
        private string nivo;
        public string Nivo { get
            {
                culture.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = culture;
                if (nivo.Contains(",") || nivo.Contains("."))
                {
                    double inp = Double.Parse(nivo.Replace(",", "."));
                    double decimall = (inp - Math.Truncate(inp)) * 10;
                    int index = (int)Math.Truncate(inp);
                    double test = (TabelaZapremine[index + 1] - TabelaZapremine[index]);
                    double test2 = test / 10 * decimall + TabelaZapremine[index];

                    return Math.Round(test2).ToString();
                }
                else
                {
                    int i = Int32.Parse(nivo);

                    return TabelaZapremine[i].ToString();

                };
            }

            set { nivo = value; } }
        



       //vratiti koeficjent za izracunavanje korekcije na osnovu temperature
       private string temperatura;      

        public string Temperatura
        {
            get
            {
                if(temperatura != string.Empty)
                {
                    if (Derivat.benzin)
                    {
                      return  korekcijaBmb(temperatura).ToString();

                    }
                    return korekcijaEud(temperatura).ToString();
                }
                return "nije unesena temperatura";
            }

            set
            {
                temperatura = value;
            }

        }
          


        public static double korekcijaBmb(string temp)
        {
            int tem = int.Parse(temp);
            var korekcijaBmb95 = new SortedList<int, double>();
            korekcijaBmb95.Add(-10, 26.3);
            korekcijaBmb95.Add(-9, 25.2);
            korekcijaBmb95.Add(-8, 24.2);
            korekcijaBmb95.Add(-7, 23.1);
            korekcijaBmb95.Add(-6, 22.1);
            korekcijaBmb95.Add(-5, 21);
            korekcijaBmb95.Add(-4, 20);
            korekcijaBmb95.Add(-3, 18.9);
            korekcijaBmb95.Add(-2, 17.9);
            korekcijaBmb95.Add(-1, 18.8);
            korekcijaBmb95.Add(0, 15.8);
            korekcijaBmb95.Add(1, 14.7);
            korekcijaBmb95.Add(2, 13.7);
            korekcijaBmb95.Add(3, 12.6);
            korekcijaBmb95.Add(4, 11.6);
            korekcijaBmb95.Add(5, 10.5);
            korekcijaBmb95.Add(6, 9.5);
            korekcijaBmb95.Add(7, 8.4);
            korekcijaBmb95.Add(8, 7.4);
            korekcijaBmb95.Add(9, 6.3);
            korekcijaBmb95.Add(10, 5.3);
            korekcijaBmb95.Add(11, 4.2);
            korekcijaBmb95.Add(12, 3.2);
            korekcijaBmb95.Add(13, 2.1);
            korekcijaBmb95.Add(14, 1.1);
            korekcijaBmb95.Add(15, 0);
            korekcijaBmb95.Add(16, 1.1);
            korekcijaBmb95.Add(17, 2.1);
            korekcijaBmb95.Add(18, 3.2);
            korekcijaBmb95.Add(19, 4.2);
            korekcijaBmb95.Add(20, 5.3);
            korekcijaBmb95.Add(21, 6.3);
            korekcijaBmb95.Add(22, 7.4);
            korekcijaBmb95.Add(23, 8.4);
            korekcijaBmb95.Add(24, 9.5);
            korekcijaBmb95.Add(25, 10.5);
            korekcijaBmb95.Add(26, 11.6);
            korekcijaBmb95.Add(27, 12.6);
            korekcijaBmb95.Add(28, 13.7);
            korekcijaBmb95.Add(29, 14.7);
            korekcijaBmb95.Add(30, 15.8);
            korekcijaBmb95.Add(31, 16.8);
            korekcijaBmb95.Add(32, 17.9);
            korekcijaBmb95.Add(33, 18.9);
            korekcijaBmb95.Add(34, 20);
            korekcijaBmb95.Add(35, 21);
            korekcijaBmb95.Add(36, 22.1);
            korekcijaBmb95.Add(37, 23.1);
            korekcijaBmb95.Add(38, 24.2);
            korekcijaBmb95.Add(39, 25.2);
            korekcijaBmb95.Add(40, 26.3);
           
                double koef = korekcijaBmb95[tem];      
                return koef;
           
           

        }


        public static double korekcijaEud(string temp)
        {
            int tem = int.Parse(temp);
            var eud = new SortedList<int, double>();
            eud.Add(-10, 20.2);
            eud.Add(-9, 19.4);
            eud.Add(-8, 18.6);
            eud.Add(-6, 16.9);
            eud.Add(-5, 16.1);
            eud.Add(-4, 15.3);
            eud.Add(-3, 14.5);
            eud.Add(-2, 13.7);
            eud.Add(-1, 12.9);
            eud.Add(0, 12.1);
            eud.Add(1, 11.3);
            eud.Add(2, 10.5);
            eud.Add(3, 9.7);
            eud.Add(4, 8.9);
            eud.Add(5, 8.1);
            eud.Add(6, 7.3);
            eud.Add(7, 6.5);
            eud.Add(8, 5.6);
            eud.Add(9, 4.8);
            eud.Add(10, 4);
            eud.Add(11, 3.2);
            eud.Add(12, 2.4);
            eud.Add(13, 1.6);
            eud.Add(14, 0.8);
            eud.Add(15, 0);
            eud.Add(16, 0.8);
            eud.Add(17, 1.6);
            eud.Add(18, 2.4);
            eud.Add(19, 3.2);
            eud.Add(20, 4);
            eud.Add(21, 4.8);
            eud.Add(22, 5.6);
            eud.Add(23, 6.5);
            eud.Add(24, 7.3);
            eud.Add(25, 8.1);
            eud.Add(26, 8.9);
            eud.Add(27, 9.7);
            eud.Add(28, 10.5);
            eud.Add(29, 11.3);
            eud.Add(30, 12.1);
            eud.Add(31, 12.9);
            eud.Add(32, 13.7);
            eud.Add(33, 14.5);
            eud.Add(34, 15.3);
            eud.Add(35, 16.1);
            eud.Add(36, 16.9);
            eud.Add(37, 17.9);
            eud.Add(38, 18.6);
            eud.Add(39, 19.1);
            eud.Add(40, 20.2);

            double koef = eud[tem];
            return koef;

        }





        //izracunati zavrsni nivo u centimetrima
        private string kolicinaPoOtpremnici;
        public string KolicinaPoOtpremnici
        {
            get
            {
                if (kolicinaPoOtpremnici !=null)
                {
                    return litToNiv(TabelaZapremine, nivo, kolicinaPoOtpremnici).ToString();

                }
                return "";

            }
            set
            {
                this.kolicinaPoOtpremnici = value;
            }
        }



        public static int litToNiv(int[] litraza, string izracunataLitraza, string kolicinaPoOtprmnici)
        {
            double str1 = double.Parse(izracunataLitraza);
            double str2 = double.Parse(kolicinaPoOtprmnici);
            double s = str1 + str2;
            int lit = (int)s;
            var niv = new List<int>();
            for (int i = 0; i < lit; i++)
            {
                if (Array.IndexOf(litraza, i) > 0)
                {
                    niv.Add(Array.IndexOf(litraza, i));
                }
            }
            var nv = niv.Max() + 1;
            int c = (int)nv;
            return c;
        }
    }
}
