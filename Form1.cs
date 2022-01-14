using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace numerical_methods_Newton
{
    public partial class FormNewtonMethod : Form
    {
        private EasyParser parser;

        public FormNewtonMethod()
        {
            InitializeComponent();

            chart_res.Series.Clear();
            tb_precision_zero.Enabled = false;
            tb_precision_sqrt.Enabled = false;
            tb_pkt_start.Enabled = false;
            ud_iters.Enabled = false;
            ud_places_comma.Enabled = false;
            b_ok.Enabled = false;
            b_ok_2.Enabled = false;
            Color icCol = Color.FromArgb(12, 19, 22);
            bClear.IconColor = icCol;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(tb_pkt_start.Text), x1 = x0 - 1;
                double f0 = parser.getFunctionValue(x0), f1 = parser.getFunctionDerivativeValue(x0);
                double eps0 = Convert.ToDouble(tb_precision_zero.Text);
                double epsx = Convert.ToDouble(tb_precision_sqrt.Text);
                int i = (int)ud_iters.Value;

                NewtonMethod calculations = new NewtonMethod(tb_function.Text, x0, x1, f0, f1, eps0, epsx, i, (int)ud_places_comma.Value);
                calculations.calculate();
                tb_res_zero.Text = "" + calculations.res.x0;
                tb_res_num_iter.Text = "" + calculations.res.i;
                tb_res_zero_function_val.Text = "" + calculations.res.f0;

                drawChart(calculations);
            }
            catch
            {

            }         
        }

        private void b_ok_2_Click(object sender, EventArgs e)
        {    
            try
            {
                this.parser = new EasyParser(tb_function.Text);

                tb_function.Enabled = false;
                udXmax.Enabled = false;
                udXmin.Enabled = false;

                tb_precision_zero.Enabled = true;
                tb_precision_sqrt.Enabled = true;
                tb_pkt_start.Enabled = true;
                ud_iters.Enabled = true;
                ud_places_comma.Enabled = true;         
                bClear.Enabled = true;
                Color icCol = Color.FromArgb(232, 247, 238);
                bClear.IconColor = icCol;


                drawChart();
            }
            catch
            {

            }
        }

        // rysowanie wstepnego, pomocniczego wykresu funkcji po nacisnieciu przycisku 'rysuj'
        private void drawChart()
        {
            int min = (int)udXmin.Value;
            int max = (int)udXmax.Value;

            var chart = chart_res.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Interval = 1;

            chart_res.Titles.Clear();
            chart_res.Series.Clear();
            
            chart_res.Titles.Add("Wykres f(x) = " + tb_function.Text);
            Series series = chart_res.Series.Add("f(x) = " + tb_function.Text);
            series.ChartType = SeriesChartType.Spline;
                   

            for (int i = min; i <= max; i++)
            {
                series.Points.AddXY(i.ToString(), parser.getFunctionValue(i));
            }

            chart_res.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_res.MouseWheel += chart_res_MouseWheel;

            chart_res.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart_res.ChartAreas[0].CursorX.AutoScroll = true;
            chart_res.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        // ponowne rysowanie wykresu po nacisnieciu przycisku 'oblicz'
        private void drawChart(NewtonMethod calculations)
        {

            int min = (int)udXmin.Value;
            int max = (int)udXmax.Value;

            var chart = chart_res.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Interval = 1;

            chart_res.Titles.Clear();
            chart_res.Series.Clear();

            chart_res.Titles.Add("Wykres f(x) = " + tb_function.Text);
            Series series = chart_res.Series.Add("f(x) = " + tb_function.Text);
            series.ChartType = SeriesChartType.Spline;

            Series seriesX0 = chart_res.Series.Add("Wyznaczone miejsce zerowe");
            seriesX0.Color = Color.Gold;
            seriesX0.MarkerStyle = MarkerStyle.Square;
            Series seriesApprox = chart_res.Series.Add("Kolejne przybliżenia miejsca zerowego");
            seriesApprox.Color = Color.Green;
            seriesApprox.MarkerStyle = MarkerStyle.Circle;
            Series seriesStart = chart_res.Series.Add("Punkt startowy");
            seriesStart.Color = Color.Red;
            seriesStart.MarkerStyle = MarkerStyle.Circle;

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
                        }
                    }
                }

                if (i <= Convert.ToDouble(tb_pkt_start.Text) && i + 1 > Convert.ToDouble(tb_pkt_start.Text))
                {
                    series.Points.AddXY(tb_pkt_start.Text, parser.getFunctionValue(Convert.ToDouble(tb_pkt_start.Text)));
                    series.Points[series.Points.Count - 1].MarkerColor = Color.Red;
                    series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
                    series.Points[series.Points.Count - 1].MarkerSize = 10;
                    continue;
                }

                if (i < calculations.res.x0 && i + 1 > calculations.res.x0)
                {
                    series.Points.AddXY(calculations.res.x0.ToString(), parser.getFunctionValue(calculations.res.x0));
                    series.Points[series.Points.Count - 1].MarkerColor = Color.Gold;
                    series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Square;
                    series.Points[series.Points.Count - 1].MarkerSize = 15;
                    continue;
                }

                series.Points.AddXY(i.ToString(), parser.getFunctionValue(i));
            }

            Legend customLegend = CustomCloneLegend(chart_res, chart_res.Legends[0]);
            chart_res.Legends.Add(customLegend);

            chart_res.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_res.MouseWheel += chart_res_MouseWheel;

            chart_res.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart_res.ChartAreas[0].CursorX.AutoScroll = true;
            chart_res.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        Legend CustomCloneLegend(Chart chart, Legend oLeg)
        {
            Legend newL = new Legend();
            newL.Position = oLeg.Position;  // copy a few settings:
            newL.Docking = oLeg.Docking;
            newL.Alignment = oLeg.Alignment;
            // a few numbers for the drawing to play with; you may want to use floats..
            int iw = 32; int iw2 = iw / 2; int ih = 18; int ih2 = ih / 2;
            int ir = 18; int ir2 = ir / 2; int lw = 3;
            // we want to access the series' colors!
            chart.ApplyPaletteColors();
            foreach (Series S in chart.Series)
            {
                // the drawing code is only for linechart and markerstyles circle or square:
                Bitmap bmp = new Bitmap(iw, ih);
                using (Graphics G = Graphics.FromImage(bmp))
                using (Pen pen = new Pen(S.Color, lw))
                using (SolidBrush brush = new SolidBrush(S.Color))
                {
                    G.DrawLine(pen, 0, ih2, iw, ih2);
                    if (S.MarkerStyle == MarkerStyle.Circle)
                        G.FillEllipse(brush, iw2 - ir2, ih2 - ir2, ir, ir);
                    else if (S.MarkerStyle == MarkerStyle.Square)
                        G.FillRectangle(brush, iw2 - ir2, ih2 - ir2, ir, ir);
                }
                // add a new NamesImage
                NamedImage ni = new NamedImage(S.Name, bmp);
                chart.Images.Add(ni);
                // create and add the custom legend item
                LegendItem lit = new LegendItem(S.Name, Color.Red, S.Name);
                newL.CustomItems.Add(lit);
            }
            oLeg.Enabled = false;
            return newL;
        }

        private void chart_res_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) 
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) 
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void tb_precision_zero_Leave(object sender, EventArgs e)
        {
            String precision = tb_precision_zero.Text;
            if (!Regex.Match(precision, "^[0]{1},([0-9]+)?[1-9]$").Success)
            {
                MessageBox.Show("Nieprawidłowy format przybliżenia! \n" +
                                "Prawidłowy format: 0,.....");
                tb_precision_zero.Clear();
            }

            if (tb_pkt_start.Text != "" && tb_precision_sqrt.Text != "" && tb_precision_zero.Text != "")
                if (!b_ok.Enabled)
                    b_ok.Enabled = true;
            if (tb_pkt_start.Text == "" || tb_precision_sqrt.Text == "" || tb_precision_zero.Text == "")
                if (b_ok.Enabled)
                    b_ok.Enabled = false;
        }

        private void tb_precision_sqrt_Leave(object sender, EventArgs e)
        {
            String precision = tb_precision_sqrt.Text;
            if (!Regex.Match(precision, "^[0]{1},([0-9]+)?[1-9]$").Success)
            {
                MessageBox.Show("Nieprawidłowy format przybliżenia! \n" +
                                "Prawidłowy format: 0,.....");
                tb_precision_sqrt.Clear();
            }

        }

        private void tb_pkt_start_Leave(object sender, EventArgs e)
        {
            String pktStart = tb_pkt_start.Text;

            if (!Regex.Match(pktStart, "^[-]?(?!00)(?!01)(?!02)(?!03)(?!04)(?!05)(?!06)(?!07)(?!08)(?!09)(?!-0)[0-9]{1}([0-9]{1,})?$").Success)
            {
                MessageBox.Show("Nieprawidłowy punkt startowy!");
                tb_pkt_start.Clear();
            }

            
        }

        private void tb_res_zero_function_val_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNewtonMethod_Load(object sender, EventArgs e)
        {

        }

        private void chart_res_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            double startX, endX, startY, endY;

            if (chart_res.ChartAreas[0].CursorX.SelectionStart > chart_res.ChartAreas[0].CursorX.SelectionEnd)
            {
                startX = chart_res.ChartAreas[0].CursorX.SelectionEnd;
                endX = chart_res.ChartAreas[0].CursorX.SelectionStart;
            }
            else
            {
                startX = chart_res.ChartAreas[0].CursorX.SelectionStart;
                endX = chart_res.ChartAreas[0].CursorX.SelectionEnd;
            }
            if (chart_res.ChartAreas[0].CursorY.SelectionStart > chart_res.ChartAreas[0].CursorY.SelectionEnd)
            {
                endY = chart_res.ChartAreas[0].CursorY.SelectionStart;
                startY = chart_res.ChartAreas[0].CursorY.SelectionEnd;
            }
            else
            {
                startY = chart_res.ChartAreas[0].CursorY.SelectionStart;
                endY = chart_res.ChartAreas[0].CursorY.SelectionEnd;
            }

            if (startX == endX && startY == endY)
            {
                return;
            }

            chart_res.ChartAreas[0].AxisX.ScaleView.Zoom(startX, (endX - startX), DateTimeIntervalType.Auto, true);
            chart_res.ChartAreas[0].AxisY.ScaleView.Zoom(startY, (endY - startY), DateTimeIntervalType.Auto, true);
        }

        private void tb_pkt_start_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_pkt_start.Text != "" && tb_precision_sqrt.Text != "" && tb_precision_zero.Text != "")
                if (!b_ok.Enabled)
                    b_ok.Enabled = true;
            if (tb_pkt_start.Text == "" || tb_precision_sqrt.Text == "" || tb_precision_zero.Text == "")
                if (b_ok.Enabled)
                    b_ok.Enabled = false;
        }

        private void tb_precision_zero_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_pkt_start.Text != "" && tb_precision_sqrt.Text != "" && tb_precision_zero.Text != "")
                if (!b_ok.Enabled)
                    b_ok.Enabled = true;
            if (tb_pkt_start.Text == "" || tb_precision_sqrt.Text == "" || tb_precision_zero.Text == "")
                if (b_ok.Enabled)
                    b_ok.Enabled = false;
        }

        private void tb_precision_sqrt_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_pkt_start.Text != "" && tb_precision_sqrt.Text != "" && tb_precision_zero.Text != "")
                if (!b_ok.Enabled)
                    b_ok.Enabled = true;
            if (tb_pkt_start.Text == "" || tb_precision_sqrt.Text == "" || tb_precision_zero.Text == "")
                if (b_ok.Enabled)
                    b_ok.Enabled = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_pkt_start.Text != "" && tb_precision_sqrt.Text != "" && tb_precision_zero.Text != "")
                if (!b_ok.Enabled)
                    b_ok.Enabled = true;
            if (tb_pkt_start.Text == "" || tb_precision_sqrt.Text == "" || tb_precision_zero.Text == "")
                if (b_ok.Enabled)
                    b_ok.Enabled = false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            chart_res.Series.Clear();
            chart_res.Titles.Clear();

            tb_function.Text = "";
            tb_pkt_start.Text = "";
            tb_precision_sqrt.Text = "";
            tb_precision_zero.Text = "";

            tb_res_zero.Text = "";
            tb_res_num_iter.Text = "";
            tb_res_zero_function_val.Text = "";

            udXmin.Value = 0;
            udXmax.Value = 0;
            ud_iters.Value = 1;
            ud_places_comma.Value = 1;


            tb_function.Enabled = true;
            udXmin.Enabled = true;
            udXmax.Enabled = true;
            tb_precision_zero.Enabled = false;
            tb_precision_sqrt.Enabled = false;
            tb_pkt_start.Enabled = false;
            ud_iters.Enabled = false;
            ud_places_comma.Enabled = false;
            b_ok.Enabled = false;
            b_ok_2.Enabled = false;
            Color icCol = Color.FromArgb(12, 19, 22);
            bClear.IconColor = icCol;
        }

        private void tb_function_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_function.Text != "")
                if (!b_ok_2.Enabled)
                    b_ok_2.Enabled = true;
            if (tb_function.Text == "")
                if (b_ok_2.Enabled)
                    b_ok_2.Enabled = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_function.Text != "")
                if (!b_ok_2.Enabled)
                    b_ok_2.Enabled = true;
            if (tb_function.Text == "")
                if (b_ok_2.Enabled)
                    b_ok_2.Enabled = false;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bFullscreen_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                bFullscreen.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }  
        }

        // Chwytanie i przenoszenie aplikacji
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
