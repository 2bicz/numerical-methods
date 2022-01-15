using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace numerical_methods_Newton 
{
    class NewtonMethod
    {
        private EasyParser parser;
        private double x0;
        private double f0, f1;
        private double eps0, epsx;
        private int i, comma;

        public List<double> zeroApproxList = new List<double>();

        public struct Result
        {
            public double x0, f0;
            
            public int i;
        }
        public Result res;

        public NewtonMethod(String functionString, double x00, double f00, double f11, double eps00, double epsxx, int ii, int commaPlaces)
        {
            this.parser = new EasyParser(functionString);
            this.x0 = x00;
            this.f0 = f00;
            this.f1 = f11;
            this.eps0 = eps00;
            this.epsx = epsxx;
            this.i = ii;
            this.comma = commaPlaces;
        }

        public void calculate()
        {
            try
            {
                int copyi = this.i;
                while (i != 0 && (Math.Abs(f1) > epsx) && (Math.Abs(f0) > eps0)) // program działa tak długo dopóki 'i' nie jest równe 0 i dopóki nie zostało spełnione kryterium stopu
                {
                    f1 = parser.getFunctionDerivativeValue(x0); // uzyskanie wartości pochodnej podanej funkcji w danym punkcie startowym/przybliżeniu
                    if (Math.Abs(f1) < eps0) 
                    {
                        MessageBox.Show("Zły punkt startowy!");
                        i = 0;
                        break;
                    }
                    x0 = x0 - f0 / f1; // wyznaczenie następnego przybliżenia miejsca zerowego podanej funkcji
                    this.zeroApproxList.Add(Math.Round(x0, comma)); // dodanie odpowiednio zaokrąglonego wyniku przybliżania funkcji do listy, która następnie zostanie wykorzystana przy rysowaniu wykresu
                    f0 = parser.getFunctionValue(x0); // obliczenie wartości funkcji w podanym x0

                    // zmniejszenie 'i' o 1 i poinformowanie użytkownika o przekroczonym limicie iteracji
                    // oraz o wartości funkcji w ostatnim przybliżeniu miejsca zerowego w przypadku gdy 'i' będzie wynosić 0
                    if ((--i) == 0) 
                    {
                        MessageBox.Show("Przekroczony limit obiegów! \n" +
                                        "Wartość funkcji w ostatnim przybliżeniu: " + f0);
                        break;
                    }                    
                }
                if (i != 0)
                {
                    res.x0 = Math.Round(this.x0, this.comma); // zwracanie przybliżonego miejsca zerowego                  
                    res.f0 = Math.Round(this.f0, this.comma); // zwracanie wartości funkcji w przybliżonym miejscu zerowym
                    res.i = copyi - this.i; // zwracanie numeru ostatniej iteracji
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error message: " + err.Message + "\n Error source: " + err.Source);
            }
        }
    }
}
