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
        private double f(double x)
        {
            try
            {
                String str = tb_function.Text.Replace("x", ""+x);
                str = str.Replace(",", ".");
                Expression e1 = new Expression(str);
                double result = e1.calculate();
                return result;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Brak podanej funkcji!");
            }
            return 1;
        }

        private double fp(double x)
        {
            Argument xArg = new Argument("x = " + x.ToString().Replace(",","."));
            Expression eder = new Expression("der(" + tb_function.Text + ",x)", xArg);
            double result = eder.calculate();
            MessageBox.Show("Pochodna " + eder.getExpressionString() + ", gdzie x to " + x + ": " + result);
            return result;
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
                x0 = x0 - f0 / f1;
                f0 = f(x0);
                if ((--i) == 0)
                    MessageBox.Show("Przekroczony limit obiegów!");
            }
            if (i != 0)
            {
                tb_res_zero.Text = "" + Math.Round(x0, (int)ud_places_comma.Value);
                tb_res_stop.Text = "" + Math.Round(x1, (int)ud_places_comma.Value);
                int res_iter = copyi - i;
                tb_res_num_iter.Text = "" + res_iter;
                tb_res_zero_function_val.Text = "" + Math.Round(f0, (int)ud_places_comma.Value);
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
