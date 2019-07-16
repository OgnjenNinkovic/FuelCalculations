using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Threading;

namespace InfoReaderV2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      



        public MainWindow()
        {
            InitializeComponent();
        }



        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9,.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private static bool IsTextAllowedTemp(string text)
        {
            Regex regex = new Regex("[^0-9-]"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }




        private void txtIn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 7;
            e.Handled = !IsTextAllowed(e.Text);


        }

        private void txtIn_PreviewTextTemp(object sender, TextCompositionEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 3;
            e.Handled = !IsTextAllowedTemp(e.Text);

        }
      

    
      




        private void txtInBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95);
            der.Nivo = txtInBmb95.Text;

            if (e.Key == Key.Enter)
            {
                if (txtInBmb95.Text == "")
                {
                    return;
                }
                try
                {
                    outBmb95.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }
        private void txtInBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95R2);
            der.Nivo = tempBmb95R2.Text;
            if (e.Key == Key.Enter)
            {
                if (txtInBmb95R2.Text == "")
                {
                    return;
                }
                try
                {
                   outBmb95R2.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);

            }
        }
        private void txtInBmb98_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb98);
            der.Nivo = txtInBmb98.Text;
            if (e.Key == Key.Enter)
            {
                if (txtInBmb98.Text == "")
                {
                    return;
                }
                try
                {
                    outBmb98.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }
        private void txtInDizel_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.Dizel);
            der.Nivo = txtInDizel.Text;
            if (e.Key == Key.Enter)
            {
                if (txtInDizel.Text == "")
                {
                    return;
                }
                try
                {
                   outDizel.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }
        private void txtInDizel1_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.DizelR2);
            der.Nivo = txtInDizel1.Text;
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInDizel1.Text == "")
                {
                    return;
                }
                try
                {
                   outDizel1.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }
        private void txtInDizel2_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.DizelR3);
            der.Nivo = txtInDizel2.Text;
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInDizel2.Text == "")
                {
                    return;
                }
                try
                {
                    outDizel2.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }
        private void txtInGold_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.EudGold);
            der.Nivo = txtInGold.Text;
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInGold.Text == "")
                {
                    return;
                }
                try
                {
                    outGold.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void txtInGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.GasnoUlje);
            der.Nivo = txtInGasnoUlje.Text;

            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInGasnoUlje.Text == "")
                {
                    return;
                }
                try
                {
                    outGasnoUlje.Text = der.Nivo;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }




        #region PrijemBMB98

        private void prBmb98_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb98);
            if (e.Key == Key.Enter)
            {
                if (prBmb98.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb98.Text;                
                prBmb98out.Text = der.Nivo;              
                double max = Double.Parse(max98.Text);
                double d = max - double.Parse(prBmb98out.Text);
                raspolozivo.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d));
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }

        private void tempBmb98_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb98);

            if (e.Key == Key.Enter)
            {
                if (tempBmb98.Text == "")
                {
                    return;
                }
                try
                {
                    der.Temperatura = tempBmb98.Text;
                    koefBmb98.Text = der.Temperatura;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijom.Text = Korekcija(prBmb98out.Text, tempBmb98.Text, koefBmb98.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb98);

            if (e.Key == Key.Enter)
            {
                if (litSipka.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb98out.Text;
                der.KolicinaPoOtpremnici = litSipka.Text;
                sipka.Text =der.KolicinaPoOtpremnici +"(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prBmb98.Clear();
            prBmb98out.Text = "0";
            litSaKorekcijom.Text = "0";
            tempBmb98.Clear();
            koefBmb98.Text = "0";
            litSipka.Clear();
            raspolozivo.Text = "";

        }


        #endregion

        #region PrijemBMB95


        private void prBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95);
            if (e.Key == Key.Enter)
            {
                if (prBmb95.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb95.Text;
                prBmb95out.Text = der.Nivo;
                double max = Double.Parse(max95.Text);
                double d = max - double.Parse(prBmb95out.Text);
                raspolozivoBmb95.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }

        private void tempBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95);

            if (e.Key == Key.Enter)
            {
                if (tempBmb95.Text == "")
                {
                    return;
                }
                try
                {
                    der.Temperatura = tempBmb95.Text;
                    koefBmb95.Text = der.Temperatura;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomBmb95.Text = Korekcija(prBmb95out.Text, tempBmb95.Text, koefBmb95.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }


        private void TextBox_KeyDownBmb95(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95);

            if (e.Key == Key.Enter)
            {
                if (litSipkaBmb95.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb95out.Text;
                der.KolicinaPoOtpremnici = litSipkaBmb95.Text;
                sipkaBmb95.Text = der.KolicinaPoOtpremnici + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void ButtonBmb95_Click(object sender, RoutedEventArgs e)
        {

            prBmb95.Clear();
            prBmb95out.Text = "0";
            litSaKorekcijomBmb95.Text = "0";
            tempBmb95.Clear();
            koefBmb95.Text = "0";
            litSipkaBmb95.Clear();
            raspolozivoBmb95.Text = "";

        }


        #endregion

        #region prijemBMB95R2

        private void prBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95R2);
            if (e.Key == Key.Enter)
            {
                if (prBmb95R2.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb95outR2.Text;
                prBmb95outR2.Text = der.Nivo;
                double max = Double.Parse(max95R2.Text);
                double d = max - double.Parse(prBmb95outR2.Text);
                raspolozivoBmb95R2.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }

        private void tempBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95R2);


            if (e.Key == Key.Enter)
            {
                if (tempBmb95R2.Text == "")
                {
                    return;
                }
                try
                {
                    der.Temperatura = tempBmb95R2.Text;
                    koefBmb95R2.Text = der.Temperatura;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomBmb95R2.Text = Korekcija(prBmb95outR2.Text, tempBmb95R2.Text, koefBmb95R2.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        private void TextBox_KeyDownBmb95R2(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.LitBmb95R2);


            if (e.Key == Key.Enter)
            {
                if (litSipkaBmb95R2.Text == "")
                {
                    return;
                }
                der.Nivo = prBmb95outR2.Text;
                der.KolicinaPoOtpremnici = litSipkaBmb95R2.Text;
                sipkaBmb95R2.Text = der.KolicinaPoOtpremnici + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        private void ButtonBmb95R2_Click(object sender, RoutedEventArgs e)
        {

            prBmb95R2.Clear();
            prBmb95outR2.Text = "0";
            litSaKorekcijomBmb95R2.Text = "0";
            tempBmb95R2.Clear();
            koefBmb95R2.Text = "0";
            litSipkaBmb95R2.Clear();
            raspolozivoBmb95R2.Text = "";


        }



        #endregion


        #region PrijemEUD

        private void prEud_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.Dizel);
            if (e.Key == Key.Enter)
            {
                if (prEud.Text == "")
                {
                    return;
                }
                der.Nivo = prEud.Text;
                prEudOut.Text = der.Nivo;               
                double max = Double.Parse(maxEud.Text);
                double d = max - double.Parse(prEudOut.Text);
                raspolozivoEud.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }


        private void tempEud_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.Dizel);

            if (e.Key == Key.Enter)
            {
                if (tempEud.Text == "")
                {
                    return;
                }

                try
                {
                    der.Temperatura = tempEud.Text;
                    koefEud.Text = der.Temperatura;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud.Text = Korekcija(prEudOut.Text, tempEud.Text, koefEud.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void TextBox_KeyDownEud(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.Dizel);

            if (e.Key == Key.Enter)
            {
                if (litSipkaEud.Text == "")
                {
                    return;
                }
                der.Nivo = prEudOut.Text;
                der.KolicinaPoOtpremnici = litSipkaEud.Text;
                sipkaEud.Text =der.KolicinaPoOtpremnici + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void ButtonEud_Click(object sender, RoutedEventArgs e)
        {
            prEud.Clear();
            prEudOut.Text = "0";
            litSaKorekcijomEud.Text = "0";
            tempEud.Clear();
            koefEud.Text = "0";
            litSipkaEud.Clear();
            raspolozivoEud.Text = "";
        }







        #endregion

        #region PrijemEUD2
        private void prEud1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (prEud1.Text == "")
                {
                    return;
                }
                if (prEud1.Text.Contains(",") || prEud1.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prEud1.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivat.dizelR2[index + 1] - Derivat.dizelR2[index]);
                        double test2 = test / 10 * decimall + Derivat.dizelR2[index];
                        prEudOut1.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prEud1.Text);
                    try
                    {
                        prEudOut1.Text = Derivat.dizelR2[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxEud1.Text);
                double d = max - double.Parse(prEudOut1.Text);
                raspolozivoEud1.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }




        }

        private void tempEud1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempEud1.Text == "")
                {
                    return;
                }

                try
                {
                    koefEud1.Text = Derivat.korekcijaEud(tempEud1.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud1.Text = Korekcija(prEudOut1.Text, tempEud1.Text, koefEud1.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }
        private void ButtonEud1_Click(object sender, RoutedEventArgs e)
        {
            prEud1.Clear();
            prEudOut1.Text = "0";
            litSaKorekcijomEud1.Text = "0";
            tempEud1.Clear();
            koefEud1.Text = "0";
            litSipkaEud1.Clear();
            raspolozivoEud1.Text = "";
        }


        private void TextBox_KeyDownEud1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipkaEud1.Text == "")
                {
                    return;
                }
                sipkaEud1.Text = Derivat.litToNiv(Derivat.dizelR2, prEudOut1.Text, litSipkaEud1.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }







        #endregion

        #region prijemEUD3
        private void prEud2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (prEud2.Text == "")
                {
                    return;
                }
                if (prEud2.Text.Contains(",") || prEud2.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prEud2.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivat.dizelR3[index + 1] - Derivat.dizelR3[index]);
                        double test2 = test / 10 * decimall + Derivat.dizelR3[index];
                        prEudOut2.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prEud2.Text);
                    try
                    {
                        prEudOut2.Text = Derivat.dizelR3[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxEud2.Text);
                double d = max - double.Parse(prEudOut2.Text);
                raspolozivoEud2.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }

        }

        private void tempEud2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempEud2.Text == "")
                {
                    return;
                }

                try
                {
                    koefEud2.Text = Derivat.korekcijaEud(tempEud2.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud2.Text = Korekcija(prEudOut2.Text, tempEud2.Text, koefEud2.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void ButtonEud2_Click(object sender, RoutedEventArgs e)
        {
            prEud2.Clear();
            prEudOut2.Text = "0";
            litSaKorekcijomEud2.Text = "0";
            tempEud2.Clear();
            koefEud2.Text = "0";
            litSipkaEud2.Clear();
            raspolozivoEud2.Text = "";


        }

        private void TextBox_KeyDownEud2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipkaEud2.Text == "")
                {
                    return;
                }
                sipkaEud2.Text = Derivat.litToNiv(Derivat.dizelR3, prEudOut2.Text, litSipkaEud2.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        #endregion


        #region PrijemGOLD
        private void prGold_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.EudGold);


            if (e.Key == Key.Enter)
            {
                if (prGold.Text == "")
                {
                    return;
                }
                der.Nivo = prGold.Text;
                prGoldOut.Text = der.Nivo;              
                double max = Double.Parse(maxGold.Text);
                double d = max - double.Parse(prGoldOut.Text);
                raspolozivoGold.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }
        private void tempGold_KeyDown(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.EudGold);

            if (e.Key == Key.Enter)
            {
                if (tempGold.Text == "")
                {
                    return;
                }
                try
                {
                    der.Temperatura = tempGold.Text;
                    koefGold.Text = der.Temperatura;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomGold.Text = Korekcija(prGoldOut.Text, tempGold.Text, koefGold.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }
        private void TextBox_KeyDownGold(object sender, KeyEventArgs e)
        {
            Derivat der = new Derivat(Derivat.NazivDerivata.EudGold);
            if (e.Key == Key.Enter)
            {

                if (litSipkaGold.Text == "")
                {
                    return;
                }
                der.Nivo = prGoldOut.Text;
                der.KolicinaPoOtpremnici = litSipkaGold.Text;
                sipkaGold.Text = der.KolicinaPoOtpremnici + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }
        private void ButtonGold_Click(object sender, RoutedEventArgs e)
        {
            prGold.Clear();
            prGoldOut.Text = "0";
            litSaKorekcijomGold.Text = "0";
            tempGold.Clear();
            koefGold.Text = "0";
            litSipkaGold.Clear();
            raspolozivoGold.Text = "";
        }










        #endregion



        #region GasnoUlje
        private void prGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (prGasnoUlje.Text == "")
                {
                    return;
                }
                if (prGasnoUlje.Text.Contains(",") || prGasnoUlje.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prGasnoUlje.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivat.gasnoUlje[index + 1] - Derivat.gasnoUlje[index]);
                        double test2 = test / 10 * decimall + Derivat.gasnoUlje[index];
                        prGasnoUljeOut.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prGasnoUlje.Text);
                    try
                    {
                        prGasnoUljeOut.Text = Derivat.gasnoUlje[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxGasnoUlje.Text);
                double d = max - double.Parse(prGasnoUlje.Text);
                raspolozivoGasnoUlje.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }




        }
        private void tempGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempGasnoUlje.Text == "")
                {
                    return;
                }

                try
                {
                    koefGasnoUlje.Text = Derivat.korekcijaEud(tempGasnoUlje.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomGasnoUlje.Text = Korekcija(prGasnoUljeOut.Text, tempGasnoUlje.Text, koefGasnoUlje.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void buttonGasnoUlje_Click(object sender, RoutedEventArgs e)
        {
            prGasnoUlje.Clear();
            prGasnoUljeOut.Text = "0";
            litSaKorekcijomGasnoUlje.Text = "0";
            tempGasnoUlje.Clear();
            koefGasnoUlje.Text = "0";
            litSipkaGasnoUlje.Clear();
            raspolozivoGasnoUlje.Text = "";
        }

        private void TextBox_litSipkaGasnoUlje(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (litSipkaGasnoUlje.Text == "")
                {
                    return;
                }
                sipkaGasnoUlje.Text = Derivat.litToNiv(Derivat.gasnoUlje, prGasnoUljeOut.Text, litSipkaGasnoUlje.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        #endregion









        private double Korekcija(string litraza, string temp, string koef)
        {

            double koe = double.Parse(koef);
            double lit = double.Parse(litraza);
            int Temp = int.Parse(temp);
            double result;
            if (Temp < 15)
            {
                result = (lit / 1000 * koe) + lit;

            }
            else
            {
                result = lit - (lit / 1000 * koe);
            }
            return Math.Round(result);
        }



        private void nivo_Click(object sender, RoutedEventArgs e)
        {
            txtInBmb98.Clear();
            txtInBmb95.Clear();
            txtInBmb95R2.Clear();
            txtInDizel.Clear();
            txtInDizel1.Clear();
            txtInGold.Clear();
            txtInDizel2.Clear();
            txtInGasnoUlje.Clear();
            outBmb98.Text = "0 lit";
            outBmb95.Text = "0 lit";
            outBmb95R2.Text = "0 lit";
            outDizel.Text = "0 lit";
            outDizel1.Text = "0 lit";
            outGold.Text = "0 lit";
            outGasnoUlje.Text = "0 lit";
            outDizel2.Text = "0 lit";


        }



        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string theDir = filePath + @"\TabliceRezervoara";
                string goriva = theDir + @"\programData.txt";

                string[] data = { cene98.Text, cene95.Text, ceneEud.Text, ceneGold.Text, ceneTng.Text, ceneGasnoUlje.Text, max98.Text, max95.Text, maxEud.Text, maxGold.Text, maxEud1.Text, maxEud2.Text, maxGasnoUlje.Text, max95R2.Text };
                File.WriteAllLines(goriva, data);

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }



        bool bmbCheck = false;
        private void radioBmb_Checked(object sender, RoutedEventArgs e)
        {
            bmbCheck = true;
            dizelCheck = false;
            litVolumetar.Clear();
            tempVolumetar.Clear();
            koefVolumetar.Text = "0";
            litSaKorekcijomVol.Text = "0";
        }
        bool dizelCheck = false;
        private void radioDizel_Checked(object sender, RoutedEventArgs e)
        {
            dizelCheck = true;
            bmbCheck = false;
            litVolumetar.Clear();
            tempVolumetar.Clear();
            koefVolumetar.Text = "0";
            litSaKorekcijomVol.Text = "0";

        }

        private void tempVolumetar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempVolumetar.Text == "")
                {
                    return;
                }
                if (bmbCheck == true)
                {

                    try
                    {
                        koefVolumetar.Text = Derivat.korekcijaBmb(tempVolumetar.Text).ToString();
                    }
                    catch (KeyNotFoundException)
                    {
                        MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                    }
                    if (litVolumetar.Text == "")
                    {
                        return;
                    }
                    litSaKorekcijomVol.Text = Korekcija(litVolumetar.Text.Replace(",", "."), tempVolumetar.Text, koefVolumetar.Text).ToString();

                }
                else if (dizelCheck == true)
                {
                    try
                    {
                        koefVolumetar.Text = Derivat.korekcijaEud(tempVolumetar.Text).ToString();
                    }
                    catch (KeyNotFoundException)
                    {
                        MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                    }
                    if (litVolumetar.Text == "")
                    {
                        return;
                    }
                    litSaKorekcijomVol.Text = Korekcija(litVolumetar.Text.Replace(",", "."), tempVolumetar.Text, koefVolumetar.Text).ToString();
                }



            }
        }

        private void litVolumetar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Right);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void Win_Loaded(object sender, RoutedEventArgs e)
        {
            Files.fileCreate();

           
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = filePath + @"\TabliceRezervoara";
            string goriva = theDir + @"\programData.txt";

            if (File.Exists(goriva))
            {
                string[] data = File.ReadAllLines(goriva);
                try
                {
                    cene98.Text = data[0];
                    cene95.Text = data[1];
                    ceneEud.Text = data[2];
                    ceneGold.Text = data[3];
                    ceneTng.Text = data[4];
                    ceneGasnoUlje.Text = data[5];
                    max98.Text = data[6];
                    max95.Text = data[7];
                    maxEud.Text = data[8];
                    maxGold.Text = data[9];
                    maxEud1.Text = data[10];
                    maxEud2.Text = data[11];
                    maxGasnoUlje.Text = data[12];
                    max95R2.Text = data[13];
                }
                catch (Exception)
                {


                }


            }

            DispatcherTimer dp = new DispatcherTimer();
            dp.Interval = TimeSpan.FromSeconds(1);
            dp.Tick += Dp_Tick;
            dp.Start();

        }


        private void Dp_Tick(object sender, EventArgs e)
        {
            Time.Content = DateTime.Now.ToString("HH:mm");
            datum.Content = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void textBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Kalkulator Zapremine\nDeveloped by Ognjen Ninković\nCopyright(C)Ognjen Ninković\nEmail: Oninkovic5@gmail.com",
                "About", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = filePath + @"\TabliceRezervoara";
            string goriva = theDir + @"\programData.txt";

            string[] data = { cene98.Text, cene95.Text, ceneEud.Text, ceneGold.Text, ceneTng.Text, ceneGasnoUlje.Text, max98.Text, max95.Text, maxEud.Text, maxGold.Text, maxEud1.Text, maxEud2.Text, maxGasnoUlje.Text };
            File.WriteAllLines(goriva, data);


        }


    }


    public class Files
    {

        public static void fileCreate()
        {
            string TheDir = @"\TabliceRezervoara";
            string curentDir = Directory.GetCurrentDirectory() + TheDir;
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = thePath + TheDir;


            string bmb98 = theDir + @"\bmb98.txt";
            string bmb95 = theDir + @"\bmb95.txt";
            string bmb95R2 = theDir + @"\bmb95R2.txt";
            string eud = theDir + @"\eud.txt";
            string eudR2 = theDir + @"\eudR2.txt";
            string eudR3 = theDir + @"\eudR3.txt";
            string eudGold = theDir + @"\eudGold.txt";
            string gasnoUlje = theDir + @"\gasnoUlje.txt";


            if (Directory.Exists(curentDir))
            {
                Directory.Move(curentDir, theDir);
            }
            else if (!Directory.Exists(theDir))
            {
                Directory.CreateDirectory(theDir);
                File.Create(bmb98).Dispose();
                File.Create(bmb95).Dispose();
                File.Create(bmb95R2).Dispose();
                File.Create(eud).Dispose();
                File.Create(eudR2).Dispose();
                File.Create(eudR3).Dispose();
                File.Create(eudGold).Dispose();
                File.Create(gasnoUlje).Dispose();
            }


            Derivat.litBmb98 = GetArray(bmb98);
            Derivat.litBmb95 = GetArray(bmb95);
            Derivat.litBmb95R2 = GetArray(bmb95R2);
            Derivat.dizel = GetArray(eud);
            Derivat.dizelR2 = GetArray(eudR2);
            Derivat.dizelR3 = GetArray(eudR3);
            Derivat.eudGold = GetArray(eudGold);
            Derivat.gasnoUlje = GetArray(gasnoUlje);




        }

        private static int[] GetArray(string filePath)
        {
            List<int> parsedNum = new List<int>();
            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    string[] s = line.Split(',');
                    int num;
                    foreach (string item in s)
                    {
                        if (Int32.TryParse(item, out num))
                        {
                            parsedNum.Add(num);
                        }
                    }

                    parsedNum.Sort();
                }
            }


            return parsedNum.ToArray();
        }
    }

}










