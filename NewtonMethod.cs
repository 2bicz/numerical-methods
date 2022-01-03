using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_methods_Newton 
{
    class NewtonMethod
    {
        private EasyParser parser;
        private double x0, x1;
        private double f0, f1;
        private double eps0, epsx;
        private int i;

        public struct Result
        {
            public double x0, x1, f0;
            public int i;
            public String error;
        }

        public NewtonMethod(String functionString, double x00, double x11, double f00, double f11, double eps00, double epsxx, int ii)
        {
            this.parser = new EasyParser(functionString);
            this.x0 = x00;
            this.x1 = x11;
            this.f0 = f00;
            this.f1 = f11;
            this.eps0 = eps00;
            this.epsx = epsxx;
            this.i = ii;
        }

        public Result calculate()
        {
            Result res = new Result();
            try
            {
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
                    f0 = parser.getFunctionValue(x0);

                    if ((--i) == 0)
                        MessageBox.Show("Przekroczony limit obiegów!");
                }
                if (i != 0)
                {
                    //tb_res_zero.Text = "" + Math.Round(x0, (int)ud_places_comma.Value); //double
                    //tb_res_stop.Text = "" + Math.Round(x1, (int)ud_places_comma.Value); //double
                    //int res_iter = copyi - i; //int
                    //tb_res_num_iter.Text = "" + res_iter;
                    //tb_res_zero_function_val.Text = "" + Math.Round(f0, (int)ud_places_comma.Value); //double
                    res.x0 = this.x0;
                    res.x1 = this.x1;
                    res.i = this.i;
                    res.f0 = this.f0;

                    return res;
                }
            }
            catch(Exception err)
            {
                Console.WriteLine("Error message: " + err.Message);
                Console.WriteLine("Error source: " + err.Source);
            }
            return res;
        }
    }
}
