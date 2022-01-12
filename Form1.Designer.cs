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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_res = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_pkt_start = new System.Windows.Forms.TextBox();
            this.lb_pkt_start = new System.Windows.Forms.Label();
            this.lb_function = new System.Windows.Forms.Label();
            this.tb_function = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.tb_precision_zero = new System.Windows.Forms.TextBox();
            this.lb_precision_zero = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.Button();
            this.lb_max_iter = new System.Windows.Forms.Label();
            this.ud_iters = new System.Windows.Forms.NumericUpDown();
            this.tb_res_zero = new System.Windows.Forms.TextBox();
            this.tb_res_num_iter = new System.Windows.Forms.TextBox();
            this.tb_res_zero_function_val = new System.Windows.Forms.TextBox();
            this.lb_res_zero = new System.Windows.Forms.Label();
            this.lb_res_num_iter = new System.Windows.Forms.Label();
            this.lb_res_zero_function_val = new System.Windows.Forms.Label();
            this.tb_precision_sqrt = new System.Windows.Forms.TextBox();
            this.lb_precision_sqrt = new System.Windows.Forms.Label();
            this.ud_places_comma = new System.Windows.Forms.NumericUpDown();
            this.lb_places_comma = new System.Windows.Forms.Label();
            this.b_ok_2 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_places_comma)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_res
            // 
            this.chart_res.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart_res.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_res.Legends.Add(legend3);
            this.chart_res.Location = new System.Drawing.Point(15, 16);
            this.chart_res.Name = "chart_res";
            this.chart_res.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_res.Series.Add(series3);
            this.chart_res.Size = new System.Drawing.Size(1039, 664);
            this.chart_res.TabIndex = 0;
            this.chart_res.Text = "chart1";
            // 
            // tb_pkt_start
            // 
            this.tb_pkt_start.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_pkt_start.Location = new System.Drawing.Point(315, 176);
            this.tb_pkt_start.Name = "tb_pkt_start";
            this.tb_pkt_start.Size = new System.Drawing.Size(104, 32);
            this.tb_pkt_start.TabIndex = 1;
            this.tb_pkt_start.Leave += new System.EventHandler(this.tb_pkt_start_Leave);
            // 
            // lb_pkt_start
            // 
            this.lb_pkt_start.AutoSize = true;
            this.lb_pkt_start.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_pkt_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_pkt_start.Location = new System.Drawing.Point(70, 175);
            this.lb_pkt_start.Name = "lb_pkt_start";
            this.lb_pkt_start.Size = new System.Drawing.Size(155, 30);
            this.lb_pkt_start.TabIndex = 2;
            this.lb_pkt_start.Text = "Punkt startowy";
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_function.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_function.Location = new System.Drawing.Point(11, 42);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(85, 30);
            this.lb_function.TabIndex = 4;
            this.lb_function.Text = "Funkcja";
            // 
            // tb_function
            // 
            this.tb_function.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_function.Location = new System.Drawing.Point(111, 41);
            this.tb_function.Name = "tb_function";
            this.tb_function.Size = new System.Drawing.Size(220, 32);
            this.tb_function.TabIndex = 5;
            // 
            // b_ok
            // 
            this.b_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.b_ok.FlatAppearance.BorderSize = 0;
            this.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.b_ok.Location = new System.Drawing.Point(111, 309);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(269, 46);
            this.b_ok.TabIndex = 6;
            this.b_ok.Text = "Oblicz";
            this.b_ok.UseVisualStyleBackColor = false;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // tb_precision_zero
            // 
            this.tb_precision_zero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_precision_zero.Location = new System.Drawing.Point(121, 239);
            this.tb_precision_zero.Name = "tb_precision_zero";
            this.tb_precision_zero.Size = new System.Drawing.Size(104, 32);
            this.tb_precision_zero.TabIndex = 7;
            this.tb_precision_zero.Leave += new System.EventHandler(this.tb_precision_zero_Leave);
            // 
            // lb_precision_zero
            // 
            this.lb_precision_zero.AutoSize = true;
            this.lb_precision_zero.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_precision_zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_precision_zero.Location = new System.Drawing.Point(70, 238);
            this.lb_precision_zero.Name = "lb_precision_zero";
            this.lb_precision_zero.Size = new System.Drawing.Size(35, 30);
            this.lb_precision_zero.TabIndex = 8;
            this.lb_precision_zero.Text = "ε0";
            // 
            // b_close
            // 
            this.b_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.b_close.FlatAppearance.BorderSize = 0;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.b_close.Location = new System.Drawing.Point(172, 368);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(146, 34);
            this.b_close.TabIndex = 9;
            this.b_close.Text = "Czyść";
            this.b_close.UseVisualStyleBackColor = false;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // lb_max_iter
            // 
            this.lb_max_iter.AutoSize = true;
            this.lb_max_iter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_max_iter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_max_iter.Location = new System.Drawing.Point(70, 47);
            this.lb_max_iter.Name = "lb_max_iter";
            this.lb_max_iter.Size = new System.Drawing.Size(188, 30);
            this.lb_max_iter.TabIndex = 10;
            this.lb_max_iter.Text = "Maksimum iteracji";
            // 
            // ud_iters
            // 
            this.ud_iters.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ud_iters.Location = new System.Drawing.Point(315, 45);
            this.ud_iters.Name = "ud_iters";
            this.ud_iters.Size = new System.Drawing.Size(104, 32);
            this.ud_iters.TabIndex = 11;
            // 
            // tb_res_zero
            // 
            this.tb_res_zero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_zero.Location = new System.Drawing.Point(113, 47);
            this.tb_res_zero.Name = "tb_res_zero";
            this.tb_res_zero.ReadOnly = true;
            this.tb_res_zero.Size = new System.Drawing.Size(234, 25);
            this.tb_res_zero.TabIndex = 12;
            // 
            // tb_res_num_iter
            // 
            this.tb_res_num_iter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_num_iter.Location = new System.Drawing.Point(885, 43);
            this.tb_res_num_iter.Name = "tb_res_num_iter";
            this.tb_res_num_iter.ReadOnly = true;
            this.tb_res_num_iter.Size = new System.Drawing.Size(100, 25);
            this.tb_res_num_iter.TabIndex = 14;
            // 
            // tb_res_zero_function_val
            // 
            this.tb_res_zero_function_val.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_zero_function_val.Location = new System.Drawing.Point(430, 47);
            this.tb_res_zero_function_val.Name = "tb_res_zero_function_val";
            this.tb_res_zero_function_val.ReadOnly = true;
            this.tb_res_zero_function_val.Size = new System.Drawing.Size(234, 25);
            this.tb_res_zero_function_val.TabIndex = 15;
            this.tb_res_zero_function_val.TextChanged += new System.EventHandler(this.tb_res_zero_function_val_TextChanged);
            // 
            // lb_res_zero
            // 
            this.lb_res_zero.AutoSize = true;
            this.lb_res_zero.Location = new System.Drawing.Point(58, 50);
            this.lb_res_zero.Name = "lb_res_zero";
            this.lb_res_zero.Size = new System.Drawing.Size(49, 25);
            this.lb_res_zero.TabIndex = 16;
            this.lb_res_zero.Text = "x0 ≈";
            // 
            // lb_res_num_iter
            // 
            this.lb_res_num_iter.AutoSize = true;
            this.lb_res_num_iter.Location = new System.Drawing.Point(695, 47);
            this.lb_res_num_iter.Name = "lb_res_num_iter";
            this.lb_res_num_iter.Size = new System.Drawing.Size(184, 25);
            this.lb_res_num_iter.TabIndex = 18;
            this.lb_res_num_iter.Text = "Nr końcowej iteracji:";
            // 
            // lb_res_zero_function_val
            // 
            this.lb_res_zero_function_val.AutoSize = true;
            this.lb_res_zero_function_val.Location = new System.Drawing.Point(358, 50);
            this.lb_res_zero_function_val.Name = "lb_res_zero_function_val";
            this.lb_res_zero_function_val.Size = new System.Drawing.Size(72, 25);
            this.lb_res_zero_function_val.TabIndex = 19;
            this.lb_res_zero_function_val.Text = "f(x0) = ";
            // 
            // tb_precision_sqrt
            // 
            this.tb_precision_sqrt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_precision_sqrt.Location = new System.Drawing.Point(315, 239);
            this.tb_precision_sqrt.Name = "tb_precision_sqrt";
            this.tb_precision_sqrt.Size = new System.Drawing.Size(104, 32);
            this.tb_precision_sqrt.TabIndex = 20;
            this.tb_precision_sqrt.Leave += new System.EventHandler(this.tb_precision_sqrt_Leave);
            // 
            // lb_precision_sqrt
            // 
            this.lb_precision_sqrt.AutoSize = true;
            this.lb_precision_sqrt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_precision_sqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_precision_sqrt.Location = new System.Drawing.Point(249, 238);
            this.lb_precision_sqrt.Name = "lb_precision_sqrt";
            this.lb_precision_sqrt.Size = new System.Drawing.Size(60, 30);
            this.lb_precision_sqrt.TabIndex = 21;
            this.lb_precision_sqrt.Text = "εsqrt";
            // 
            // ud_places_comma
            // 
            this.ud_places_comma.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ud_places_comma.Location = new System.Drawing.Point(315, 113);
            this.ud_places_comma.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ud_places_comma.Name = "ud_places_comma";
            this.ud_places_comma.Size = new System.Drawing.Size(104, 32);
            this.ud_places_comma.TabIndex = 22;
            // 
            // lb_places_comma
            // 
            this.lb_places_comma.AutoSize = true;
            this.lb_places_comma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_places_comma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_places_comma.Location = new System.Drawing.Point(70, 111);
            this.lb_places_comma.Name = "lb_places_comma";
            this.lb_places_comma.Size = new System.Drawing.Size(216, 30);
            this.lb_places_comma.TabIndex = 23;
            this.lb_places_comma.Text = "Miejsca po przecinku";
            // 
            // b_ok_2
            // 
            this.b_ok_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.b_ok_2.FlatAppearance.BorderSize = 0;
            this.b_ok_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ok_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_ok_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.b_ok_2.Location = new System.Drawing.Point(357, 39);
            this.b_ok_2.Name = "b_ok_2";
            this.b_ok_2.Size = new System.Drawing.Size(98, 34);
            this.b_ok_2.TabIndex = 24;
            this.b_ok_2.Text = "Rysuj";
            this.b_ok_2.UseVisualStyleBackColor = false;
            this.b_ok_2.Click += new System.EventHandler(this.b_ok_2_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelMenu.Size = new System.Drawing.Size(1674, 103);
            this.panelMenu.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1674, 911);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.b_ok_2);
            this.panel1.Controls.Add(this.tb_function);
            this.panel1.Controls.Add(this.lb_function);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(37, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 127);
            this.panel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel3.Controls.Add(this.tb_precision_sqrt);
            this.panel3.Controls.Add(this.lb_precision_zero);
            this.panel3.Controls.Add(this.tb_precision_zero);
            this.panel3.Controls.Add(this.b_close);
            this.panel3.Controls.Add(this.b_ok);
            this.panel3.Controls.Add(this.lb_places_comma);
            this.panel3.Controls.Add(this.tb_pkt_start);
            this.panel3.Controls.Add(this.ud_places_comma);
            this.panel3.Controls.Add(this.lb_pkt_start);
            this.panel3.Controls.Add(this.lb_precision_sqrt);
            this.panel3.Controls.Add(this.ud_iters);
            this.panel3.Controls.Add(this.lb_max_iter);
            this.panel3.Location = new System.Drawing.Point(37, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 419);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel4.Controls.Add(this.lb_res_num_iter);
            this.panel4.Controls.Add(this.tb_res_zero);
            this.panel4.Controls.Add(this.tb_res_zero_function_val);
            this.panel4.Controls.Add(this.tb_res_num_iter);
            this.panel4.Controls.Add(this.lb_res_zero_function_val);
            this.panel4.Controls.Add(this.lb_res_zero);
            this.panel4.Location = new System.Drawing.Point(15, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1039, 118);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.chart_res);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(566, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1070, 853);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(37, 643);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 241);
            this.panel6.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Wojciech Lisiak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(277, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Paweł Skrzyński";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(65, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mikołaj Tchorz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(277, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Patryk Tubicz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(116, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Informatyka Stosowana III";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(494, 146);
            this.panel7.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(456, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(754, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Przybliżanie miejsca zerowego funkcji metodą Newtona";
            // 
            // FormNewtonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1014);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Name = "FormNewtonMethod";
            this.Text = "Wyznaczanie miejsca zerowego metodą Newtona";
            this.Load += new System.EventHandler(this.FormNewtonMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_places_comma)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pkt_start;
        private System.Windows.Forms.Label lb_pkt_start;
        private System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.TextBox tb_function;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.TextBox tb_precision_zero;
        private System.Windows.Forms.Label lb_precision_zero;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label lb_max_iter;
        private System.Windows.Forms.NumericUpDown ud_iters;
        private System.Windows.Forms.TextBox tb_res_zero;
        private System.Windows.Forms.TextBox tb_res_num_iter;
        private System.Windows.Forms.TextBox tb_res_zero_function_val;
        private System.Windows.Forms.Label lb_res_zero;
        private System.Windows.Forms.Label lb_res_num_iter;
        private System.Windows.Forms.Label lb_res_zero_function_val;
        private System.Windows.Forms.TextBox tb_precision_sqrt;
        private System.Windows.Forms.Label lb_precision_sqrt;
        private System.Windows.Forms.NumericUpDown ud_places_comma;
        private System.Windows.Forms.Label lb_places_comma;
        private System.Windows.Forms.Button b_ok_2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_res;
        private System.Windows.Forms.Label label6;
    }
}

