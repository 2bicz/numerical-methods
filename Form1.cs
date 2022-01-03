using System;
using System.Windows.Forms;

namespace numerical_methods_Newton
{
    public partial class FormNewtonMethod : Form
    {
        private String safeFunction(String function)
        {
            // regex funkcji (będzie trzeba pokminić na co mxparser pozwala)
            // tb_function.Text
            // zwraca string funkcji
        }

        private String safePktStart(String pktStart)
        {
            // regex punktu startowego (tylko liczby, bez innych znaków, zamieniać kropki na przecinki)
            // tb_pkt_start.Text
            // zwraca string punktu startowego
        }

        private String safePrecision(String precision)
        {
            // regex dokładności porównania z zerem i przybliżenia pierwiastka (żadnych liter, same liczby, zero i jakieś wartości po !przecinku!)
            // tb_precision_zero.Text
            // zwraca string przybliżenia (np 0,0000000001)
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            EasyParser parser = new EasyParser(safeFunction(tb_function.Text));
            double x0 = Convert.ToDouble(safePktStart(tb_pkt_start.Text)), x1 = x0 - 1;
            double f0 = parser.getFunctionValue(x0), f1 = parser.getFunctionDerivativeValue(x0);
            double eps0 = Convert.ToDouble(safePrecision(tb_precision_zero.Text));
            double epsx = Convert.ToDouble(safePrecision(tb_precision_sqrt.Text));
            int i = (int)ud_iters.Value;

            NewtonMethod calculations = new NewtonMethod(safeFunction(tb_function.Text), x0, x1, f0, f1, eps0, epsx, i, (int)ud_places_comma.Value);
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

        public FormNewtonMethod()
        {
            InitializeComponent();
        }
    }
}
