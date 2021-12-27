using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_methods_Newton
{
    public partial class FormNewtonMethod : Form
    {
        private double eps0, epsx;

        private double setPrecision()
        {
            
        }

        private double f(double x)
        {

        }

        private double fp(double x)
        {

        }

        public FormNewtonMethod()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            double x0, x1, f0, f1;
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
