using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace numerical_methods_Newton
{
    public partial class FormNewtonMethod : Form
    {
        

        /*private double setPrecision()
        {
            
        }*/

        private double f(double x)
        {
            try
            {
                String str = tb_function.Text.Replace("x", ""+x);
                str = str.Replace(",", ".");
                //MessageBox.Show(str);
                Expression e1 = new Expression(str);
                //MessageBox.Show("Parser: " + e1.getExpressionString());
                double result = e1.calculate();
                //MessageBox.Show("Result: "+ result);

                //String str2 = "-0.333333333333333 * -0.333333333333333 + 3 * -0.333333333333333 + 1";
                //Expression e2 = new Expression(str2);
                //double result2 = e2.calculate();
                //MessageBox.Show("Result 2: " + result2);

                return result;
                //return Math.Round(result, (int)ud_places_comma.Value);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Brak podanej funkcji!");
            }
            return 1;
            //return Math.Pow(x, 2) + 3 * x + 1;
        }

        private double fp(double x)
        {
            //Expression eder = new Expression("der(x^2 + 3*x + 1), x, 0");
            //MessageBox.Show("Pochodna x^2 + 3*x + 1, gdzie x to 0: " + eder.calculate());
            return 2 * x + 3;
            /*try
            {
                //String functionStr = tb_function.Text;

            }*/
        }

        public FormNewtonMethod()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            double x0, x1, f0, f1;
            double eps0 = Convert.ToDouble(tb_precision_zero.Text);
            double epsx = Convert.ToDouble(tb_precision_sqrt.Text);
            int i;

            x0 = Convert.ToDouble(tb_pkt_start.Text);
            x1 = x0 - 1;
            f0 = f(x0);
            i = (int)ud_iters.Value;
            int copyi = i;

            f1 = fp(x0);
            while (i != 0 && (Math.Abs(f1) > epsx) && (Math.Abs(f0) > eps0))
            {
                f1 = fp(x0);
                if(Math.Abs(f1) < eps0)
                {
                    MessageBox.Show("Zły punkt startowy!");
                    i = 0;
                    break;
                }
                x1 = x0;
                x0 = x0 - f0 / f1; // powinno wyjsc -1/3
                f0 = f(x0);
                if ((--i) == 0)
                    MessageBox.Show("Przekroczony limit obiegów!");
            }
            if (i != 0)
            {
                tb_res_zero.Text = "" + x0;
                tb_res_stop.Text = "" + x1;
                int res_iter = copyi - i;
                tb_res_num_iter.Text = "" + res_iter;
                tb_res_zero_function_val.Text = "" + f0;
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {

        }
    }
}
