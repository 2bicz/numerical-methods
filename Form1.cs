using System;
using System.Windows.Forms;

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
            int i = (int)ud_iters.Value;

            NewtonMethod calculations = new NewtonMethod(tb_function.Text, x0, x1, f0, f1, eps0, epsx, i, (int)ud_places_comma.Value);
            calculations.calculate();
            tb_res_zero.Text = "" + calculations.res.x0;
            tb_res_stop.Text = "" + calculations.res.x1;
            tb_res_num_iter.Text = "" + calculations.res.i;
            tb_res_zero_function_val.Text = "" + calculations.res.f0;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
