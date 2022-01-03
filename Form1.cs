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

        public FormNewtonMethod()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            EasyParser parser = new EasyParser(tb_function.Text);
            double x0 = Convert.ToDouble(tb_pkt_start.Text), x1 = x0 - 1;
            double f0 = parser.getFunctionValue(x0), f1 = parser.getFunctionDerivativeValue(x0);
            double eps0 = Convert.ToDouble(tb_precision_zero.Text);
            double epsx = Convert.ToDouble(tb_precision_sqrt.Text);
            int i = (int)ud_iters.Value, copyi = i;           

            while (i != 0 && (Math.Abs(f1) > epsx) && (Math.Abs(f0) > eps0))
            {
                f1 = parser.getFunctionDerivativeValue(x0);
                if(Math.Abs(f1) < eps0)
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
