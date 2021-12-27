namespace numerical_methods_Newton
{
    partial class FormNewtonMethod
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_res = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_pkt_start = new System.Windows.Forms.TextBox();
            this.lb_pkt_start = new System.Windows.Forms.Label();
            this.lb_function = new System.Windows.Forms.Label();
            this.tb_function = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.tb_precision = new System.Windows.Forms.TextBox();
            this.lb_precision = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.Button();
            this.lb_max_iter = new System.Windows.Forms.Label();
            this.ud_iters = new System.Windows.Forms.NumericUpDown();
            this.tb_res_zero = new System.Windows.Forms.TextBox();
            this.tb_res_stop = new System.Windows.Forms.TextBox();
            this.tb_res_num_iter = new System.Windows.Forms.TextBox();
            this.tb_res_zero_function_val = new System.Windows.Forms.TextBox();
            this.lb_res_zero = new System.Windows.Forms.Label();
            this.lb_res_stop = new System.Windows.Forms.Label();
            this.lb_res_num_iter = new System.Windows.Forms.Label();
            this.lb_res_zero_function_val = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_res
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_res.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_res.Legends.Add(legend1);
            this.chart_res.Location = new System.Drawing.Point(0, 0);
            this.chart_res.Name = "chart_res";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_res.Series.Add(series1);
            this.chart_res.Size = new System.Drawing.Size(433, 336);
            this.chart_res.TabIndex = 0;
            this.chart_res.Text = "chart1";
            // 
            // tb_pkt_start
            // 
            this.tb_pkt_start.Location = new System.Drawing.Point(119, 419);
            this.tb_pkt_start.Name = "tb_pkt_start";
            this.tb_pkt_start.Size = new System.Drawing.Size(44, 20);
            this.tb_pkt_start.TabIndex = 1;
            // 
            // lb_pkt_start
            // 
            this.lb_pkt_start.AutoSize = true;
            this.lb_pkt_start.Location = new System.Drawing.Point(24, 422);
            this.lb_pkt_start.Name = "lb_pkt_start";
            this.lb_pkt_start.Size = new System.Drawing.Size(77, 13);
            this.lb_pkt_start.TabIndex = 2;
            this.lb_pkt_start.Text = "Punkt startowy";
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Location = new System.Drawing.Point(42, 362);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(45, 13);
            this.lb_function.TabIndex = 4;
            this.lb_function.Text = "Funkcja";
            // 
            // tb_function
            // 
            this.tb_function.Location = new System.Drawing.Point(93, 362);
            this.tb_function.Name = "tb_function";
            this.tb_function.Size = new System.Drawing.Size(169, 20);
            this.tb_function.TabIndex = 5;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(289, 362);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 6;
            this.b_ok.Text = "Ok";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // tb_precision
            // 
            this.tb_precision.Location = new System.Drawing.Point(93, 465);
            this.tb_precision.Name = "tb_precision";
            this.tb_precision.Size = new System.Drawing.Size(100, 20);
            this.tb_precision.TabIndex = 7;
            // 
            // lb_precision
            // 
            this.lb_precision.AutoSize = true;
            this.lb_precision.Location = new System.Drawing.Point(21, 468);
            this.lb_precision.Name = "lb_precision";
            this.lb_precision.Size = new System.Drawing.Size(66, 13);
            this.lb_precision.TabIndex = 8;
            this.lb_precision.Text = "Dokładność";
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(289, 412);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 9;
            this.b_close.Text = "Anuluj";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // lb_max_iter
            // 
            this.lb_max_iter.AutoSize = true;
            this.lb_max_iter.Location = new System.Drawing.Point(30, 508);
            this.lb_max_iter.Name = "lb_max_iter";
            this.lb_max_iter.Size = new System.Drawing.Size(129, 13);
            this.lb_max_iter.TabIndex = 10;
            this.lb_max_iter.Text = "Maksymalna liczba iteracji";
            // 
            // ud_iters
            // 
            this.ud_iters.Location = new System.Drawing.Point(165, 506);
            this.ud_iters.Name = "ud_iters";
            this.ud_iters.Size = new System.Drawing.Size(70, 20);
            this.ud_iters.TabIndex = 11;
            // 
            // tb_res_zero
            // 
            this.tb_res_zero.Location = new System.Drawing.Point(556, 43);
            this.tb_res_zero.Name = "tb_res_zero";
            this.tb_res_zero.Size = new System.Drawing.Size(100, 20);
            this.tb_res_zero.TabIndex = 12;
            // 
            // tb_res_stop
            // 
            this.tb_res_stop.Location = new System.Drawing.Point(627, 98);
            this.tb_res_stop.Name = "tb_res_stop";
            this.tb_res_stop.Size = new System.Drawing.Size(100, 20);
            this.tb_res_stop.TabIndex = 13;
            // 
            // tb_res_num_iter
            // 
            this.tb_res_num_iter.Location = new System.Drawing.Point(746, 151);
            this.tb_res_num_iter.Name = "tb_res_num_iter";
            this.tb_res_num_iter.Size = new System.Drawing.Size(100, 20);
            this.tb_res_num_iter.TabIndex = 14;
            // 
            // tb_res_zero_function_val
            // 
            this.tb_res_zero_function_val.Location = new System.Drawing.Point(722, 209);
            this.tb_res_zero_function_val.Name = "tb_res_zero_function_val";
            this.tb_res_zero_function_val.Size = new System.Drawing.Size(100, 20);
            this.tb_res_zero_function_val.TabIndex = 15;
            // 
            // lb_res_zero
            // 
            this.lb_res_zero.AutoSize = true;
            this.lb_res_zero.Location = new System.Drawing.Point(451, 50);
            this.lb_res_zero.Name = "lb_res_zero";
            this.lb_res_zero.Size = new System.Drawing.Size(80, 13);
            this.lb_res_zero.TabIndex = 16;
            this.lb_res_zero.Text = "Miejsce zerowe";
            // 
            // lb_res_stop
            // 
            this.lb_res_stop.AutoSize = true;
            this.lb_res_stop.Location = new System.Drawing.Point(451, 101);
            this.lb_res_stop.Name = "lb_res_stop";
            this.lb_res_stop.Size = new System.Drawing.Size(138, 13);
            this.lb_res_stop.TabIndex = 17;
            this.lb_res_stop.Text = "Wartości kryterium stopu (?)";
            // 
            // lb_res_num_iter
            // 
            this.lb_res_num_iter.AutoSize = true;
            this.lb_res_num_iter.Location = new System.Drawing.Point(451, 151);
            this.lb_res_num_iter.Name = "lb_res_num_iter";
            this.lb_res_num_iter.Size = new System.Drawing.Size(289, 13);
            this.lb_res_num_iter.TabIndex = 18;
            this.lb_res_num_iter.Text = "Numer iteracji, w której zostało wyznaczone miejsce zerowe";
            // 
            // lb_res_zero_function_val
            // 
            this.lb_res_zero_function_val.AutoSize = true;
            this.lb_res_zero_function_val.Location = new System.Drawing.Point(439, 212);
            this.lb_res_zero_function_val.Name = "lb_res_zero_function_val";
            this.lb_res_zero_function_val.Size = new System.Drawing.Size(257, 13);
            this.lb_res_zero_function_val.TabIndex = 19;
            this.lb_res_zero_function_val.Text = "Wartość funkcji od wyznaczonego miejsca zerowego";
            // 
            // FormNewtonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 610);
            this.Controls.Add(this.lb_res_zero_function_val);
            this.Controls.Add(this.lb_res_num_iter);
            this.Controls.Add(this.lb_res_stop);
            this.Controls.Add(this.lb_res_zero);
            this.Controls.Add(this.tb_res_zero_function_val);
            this.Controls.Add(this.tb_res_num_iter);
            this.Controls.Add(this.tb_res_stop);
            this.Controls.Add(this.tb_res_zero);
            this.Controls.Add(this.ud_iters);
            this.Controls.Add(this.lb_max_iter);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.lb_precision);
            this.Controls.Add(this.tb_precision);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.tb_function);
            this.Controls.Add(this.lb_function);
            this.Controls.Add(this.lb_pkt_start);
            this.Controls.Add(this.tb_pkt_start);
            this.Controls.Add(this.chart_res);
            this.Name = "FormNewtonMethod";
            this.Text = "Wyznaczanie miejsca zerowego metodą Newtona";
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_res;
        private System.Windows.Forms.TextBox tb_pkt_start;
        private System.Windows.Forms.Label lb_pkt_start;
        private System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.TextBox tb_function;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.TextBox tb_precision;
        private System.Windows.Forms.Label lb_precision;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label lb_max_iter;
        private System.Windows.Forms.NumericUpDown ud_iters;
        private System.Windows.Forms.TextBox tb_res_zero;
        private System.Windows.Forms.TextBox tb_res_stop;
        private System.Windows.Forms.TextBox tb_res_num_iter;
        private System.Windows.Forms.TextBox tb_res_zero_function_val;
        private System.Windows.Forms.Label lb_res_zero;
        private System.Windows.Forms.Label lb_res_stop;
        private System.Windows.Forms.Label lb_res_num_iter;
        private System.Windows.Forms.Label lb_res_zero_function_val;
    }
}

