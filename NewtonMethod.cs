using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace numerical_methods_Newton 
{
    class NewtonMethod
    {
        private EasyParser parser;
        private double x0, x1;
        private double f0, f1;
        private double eps0, epsx;
        private int i, comma;

        public List<double> zeroApproxList = new List<double>();

        public struct Result
        {
            public double x0, x1, f0;
            
            public int i;
        }
        public Result res;

        public NewtonMethod(String functionString, double x00, double x11, double f00, double f11, double eps00, double epsxx, int ii, int commaPlaces)
        {
            this.parser = new EasyParser(functionString);
            this.x0 = x00;
            this.x1 = x11;
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
                while (i != 0 && (Math.Abs(f1) > epsx) && (Math.Abs(f0) > eps0))
                {
                    f1 = parser.getFunctionDerivativeValue(x0);
                    if (Math.Abs(f1) < eps0)
                    {
                        MessageBox.Show("Zły punkt startowy!");
                        i = 0;
                        break;
                    }
                    x1 = x0;
                    x0 = x0 - f0 / f1;
                    this.zeroApproxList.Add(Math.Round(x0, comma));
                    f0 = parser.getFunctionValue(x0);

                    if ((--i) == 0)
                    {
                        MessageBox.Show("Przekroczony limit obiegów!");
                        break;
                    }
                        
                }
                if (i != 0)
                {
                    res.x0 = Math.Round(this.x0, this.comma);
                    res.x1 = Math.Round(this.x1, this.comma);
                    res.i = copyi - this.i;
                    res.f0 = Math.Round(this.f0, this.comma);
                }
            }
            catch(Exception err)
            {
                Console.WriteLine("Error message: " + err.Message);
                Console.WriteLine("Error source: " + err.Source);
            }
        }
    }
}
