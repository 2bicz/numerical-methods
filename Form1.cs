using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Text.RegularExpressions;

namespace numerical_methods_Newton
{
    public partial class FormNewtonMethod : Form
    {
        private EasyParser parser;
        //private Series series;
        //private NewtonMethod calculations;

        public FormNewtonMethod()
        {
            InitializeComponent();
            tb_precision_zero.Enabled = false;
            tb_precision_sqrt.Enabled = false;
            tb_pkt_start.Enabled = false;
            ud_iters.Enabled = false;
            ud_places_comma.Enabled = false;

        }


        /*private String safeFunction(String function)
        {
            // regex funkcji (będzie trzeba pokminić na co mxparser pozwala)
            // tb_function.Text
            // zwraca string funkcji
            Regex funkcja = new Regex("@^([+-]?([^-+][0-9]*([x-z](/^[0-9])*)*)+)$");
            if (!funkcja.IsMatch(function))
            {

                MessageBox.Show("nieprawidłowa funckja");
                tb_function.Clear();
                tb_function.Focus();

                return "";
            }
            return function;
        }

        private String safePktStart(String pktStart)
        {
            // regex punktu startowego (tylko liczby, bez innych znaków, maja byc przecinki)
            // tb_pkt_start.Text
            // zwraca string punktu startowego
            pktStart = pktStart.Replace(".", ",");

            Regex start = new Regex("@^\-?[0-9]{1,}$");

            if (!start.IsMatch(pktStart))
            {

                MessageBox.Show("zly punkt startowy elo");
                tb_pkt_start.Clear();
                tb_pkt_start.Focus();

                return "";
            }

            return pktStart;
        }

        private String safePrecision(String precision)
        {
            // regex dokładności porównania z zerem i przybliżenia pierwiastka (żadnych liter, same liczby, zero i jakieś wartości po !przecinku!)
            // tb_precision_zero.Text
            // zwraca string przybliżenia (np 0,0000000001)
            precision = precision.Replace(".", ",");
            Regex precision0 = new Regex("@^[0]{1},[0-9]{1,}$");
            if (!precision0.IsMatch(precision))
            {

                MessageBox.Show("zle przyblizenie");
                tb_precision_sqrt.Clear();
                tb_precision_sqrt.Focus();

                return "";
            }
            return precision;

        }*/

        private void b_ok_Click(object sender, EventArgs e)
        {        
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

            drawChart(calculations);
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_2_Click(object sender, EventArgs e)
        {    
            try
            {
                this.parser = new EasyParser(tb_function.Text);

                tb_function.ReadOnly = true;
                tb_precision_zero.Enabled = true;
                tb_precision_sqrt.Enabled = true;
                tb_pkt_start.Enabled = true;
                ud_iters.Enabled = true;
                ud_places_comma.Enabled = true;

                drawChart();
            }
            catch
            {

            }
        }

        // rysowanie wstepnego, pomocniczego wykresu funkcji po nacisnieciu przycisku 'rysuj'
        private void drawChart()
        {
            int min = -10;
            int max = 10;

            var chart = chart_res.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            //chart.AxisX.Minimum = min;
            //chart.AxisX.Maximum = max;

            chart.AxisX.Interval = 1;

            chart_res.Titles.Clear();
            chart_res.Series.Clear();
            
            chart_res.Titles.Add("Wykres f(x) = " + tb_function.Text);
            Series series = chart_res.Series.Add("f(x) = " + tb_function.Text);
            series.ChartType = SeriesChartType.Spline;
                   

            for (int i = min; i <= max; i++)
            {
                series.Points.AddXY(i.ToString(), parser.getFunctionValue(i));
                //MessageBox.Show("wartosc funkcji: " + this.parser.getFunctionValue(i));
            }
        }

        // ponowne rysowanie wykresu po nacisnieciu przycisku 'oblicz'
        private void drawChart(NewtonMethod calculations)
        {
            /*Series series2 = this.chart_res.Series.Add("Punkt startowy");
            series2.ChartType = SeriesChartType.Point;
            series2.Points.AddXY(tb_pkt_start.Text, parser.getFunctionValue(Convert.ToDouble(tb_pkt_start.Text)));*/

            int min = -10;
            int max = 10;

            var chart = chart_res.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            //chart.AxisX.Minimum = min;
            //chart.AxisX.Maximum = max;

            chart.AxisX.Interval = 1;

            chart_res.Titles.Clear();
            chart_res.Series.Clear();

            chart_res.Titles.Add("Wykres f(x) = " + tb_function.Text);
            Series series = chart_res.Series.Add("f(x) = " + tb_function.Text);
            series.ChartType = SeriesChartType.Spline;     

            for (int i = min; i <= max; i++)
            {
                foreach (double element in calculations.zeroApproxList)
                {
                    if (i <= element && i + 1 > element)
                    {
                        if(element != calculations.res.x0)
                        {
                            series.Points.AddXY(element.ToString(), parser.getFunctionValue(element));
                            series.Points[series.Points.Count - 1].MarkerColor = Color.Green;
                            series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
                            series.Points[series.Points.Count - 1].MarkerSize = 10;
                            //MessageBox.Show("pkt start: " + this.parser.getFunctionValue(Convert.ToDouble(tb_pkt_start.Text)));
                        }
                    }
                }

                if (i <= Convert.ToDouble(tb_pkt_start.Text) && i + 1 > Convert.ToDouble(tb_pkt_start.Text))
                {
                    series.Points.AddXY(tb_pkt_start.Text, parser.getFunctionValue(Convert.ToDouble(tb_pkt_start.Text)));
                    series.Points[series.Points.Count - 1].MarkerColor = Color.Red;
                    series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
                    series.Points[series.Points.Count - 1].MarkerSize = 10;
                    //MessageBox.Show("pkt start: " + this.parser.getFunctionValue(Convert.ToDouble(tb_pkt_start.Text)));
                    continue;
                }

                if (i < calculations.res.x0 && i + 1 > calculations.res.x0)
                {
                    series.Points.AddXY(calculations.res.x0.ToString(), parser.getFunctionValue(calculations.res.x0));
                    series.Points[series.Points.Count - 1].MarkerColor = Color.Gold;
                    series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Star5;
                    series.Points[series.Points.Count - 1].MarkerSize = 20;
                    //MessageBox.Show("pkt zero: " + parser.getFunctionValue(calculations.res.x0));
                    continue;
                }

                series.Points.AddXY(i.ToString(), parser.getFunctionValue(i));
                //MessageBox.Show("wartosc funkcji: " + this.parser.getFunctionValue(i));
            }
        }

        private void tb_function_Leave(object sender, EventArgs e)
        {
            //Regex funkcja = new Regex("@^([+-]?([^-+][0-9]*([x-z](/^[0-9])*)*)+)$");
            if (!Regex.Match(tb_function.Text, "^([-+]?([0-9]*/.?[0-9]+)?((/*)?x(/^[+-]?([0-9]*/.?[0-9]+)?)?)?)+$").Success)
            {
                MessageBox.Show("nieprawidłowa funckja");
                tb_function.Clear();
            }
        }

        private void tb_precision_zero_Leave(object sender, EventArgs e)
        {
            String precision = tb_precision_zero.Text;
            //Regex precision0 = new Regex("@^[0]{1},[0-9]{1,}$");
            if (!Regex.Match(precision, "^[0]{1},([0-9]+)?[1-9]$").Success)
            {
                MessageBox.Show("zle przyblizenie");
                tb_precision_zero.Clear();
            }
        }

        private void tb_precision_sqrt_Leave(object sender, EventArgs e)
        {
            //@"^[0](?:\.[0-9]*)?$"
            String precision = tb_precision_sqrt.Text;
           // Regex precisionSqrt = new Regex("@^[0]{1},[0-9]1*$");
            //if (!precisionSqrt.IsMatch(precision))
            //@"^[0]{1},[0-9]{1*}$"
            if (!Regex.Match(precision, "^[0]{1},([0-9]+)?[1-9]$").Success)
            {
                MessageBox.Show("zle przyblizenie");
                tb_precision_sqrt.Clear();
            }
        }

        private void tb_pkt_start_Leave(object sender, EventArgs e)
        {
            String pktStart = tb_pkt_start.Text;
            //"^[-]?[0-9]{1,}$"
            // Regex start = new Regex("@^/-?[0-9]{1,}$");

            if (!Regex.Match(pktStart, "^[-]?(?!00)(?!01)(?!02)(?!03)(?!04)(?!05)(?!06)(?!07)(?!08)(?!09)(?!-0)[0-9]{1}([0-9]{1,})?$").Success)
            {
                MessageBox.Show("zly punkt startowy elo");
                tb_pkt_start.Clear();
            }
        }
    }
}
