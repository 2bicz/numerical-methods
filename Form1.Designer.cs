﻿namespace numerical_methods_Newton
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewtonMethod));
            this.chart_res = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_pkt_start = new System.Windows.Forms.TextBox();
            this.lb_pkt_start = new System.Windows.Forms.Label();
            this.lb_function = new System.Windows.Forms.Label();
            this.tb_function = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.tb_precision_zero = new System.Windows.Forms.TextBox();
            this.lb_precision_zero = new System.Windows.Forms.Label();
            this.lb_max_iter = new System.Windows.Forms.Label();
            this.ud_iters = new System.Windows.Forms.NumericUpDown();
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bMinimize = new FontAwesome.Sharp.IconButton();
            this.bFullscreen = new FontAwesome.Sharp.IconButton();
            this.bClose = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bClear = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.udXmax = new System.Windows.Forms.NumericUpDown();
            this.udXmin = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_res_zero = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_places_comma)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udXmin)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_res
            // 
            this.chart_res.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart_res.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_res.Legends.Add(legend5);
            this.chart_res.Location = new System.Drawing.Point(15, 16);
            this.chart_res.Name = "chart_res";
            this.chart_res.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_res.Series.Add(series5);
            this.chart_res.Size = new System.Drawing.Size(1039, 654);
            this.chart_res.TabIndex = 0;
            this.chart_res.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chart_res_SelectionRangeChanged);
            // 
            // tb_pkt_start
            // 
            this.tb_pkt_start.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_pkt_start.Location = new System.Drawing.Point(315, 179);
            this.tb_pkt_start.Name = "tb_pkt_start";
            this.tb_pkt_start.Size = new System.Drawing.Size(104, 32);
            this.tb_pkt_start.TabIndex = 1;
            this.tb_pkt_start.Leave += new System.EventHandler(this.tb_pkt_start_Leave);
            this.tb_pkt_start.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_pkt_start_MouseMove);
            // 
            // lb_pkt_start
            // 
            this.lb_pkt_start.AutoSize = true;
            this.lb_pkt_start.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_pkt_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_pkt_start.Location = new System.Drawing.Point(70, 178);
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
            this.lb_function.Location = new System.Drawing.Point(20, 41);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(85, 30);
            this.lb_function.TabIndex = 4;
            this.lb_function.Text = "Funkcja";
            // 
            // tb_function
            // 
            this.tb_function.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_function.Location = new System.Drawing.Point(120, 41);
            this.tb_function.Name = "tb_function";
            this.tb_function.Size = new System.Drawing.Size(347, 32);
            this.tb_function.TabIndex = 5;
            this.tb_function.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_function_MouseMove);
            // 
            // b_ok
            // 
            this.b_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.b_ok.FlatAppearance.BorderSize = 0;
            this.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.b_ok.Location = new System.Drawing.Point(223, 310);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(155, 46);
            this.b_ok.TabIndex = 6;
            this.b_ok.Text = "Oblicz";
            this.b_ok.UseVisualStyleBackColor = false;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // tb_precision_zero
            // 
            this.tb_precision_zero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_precision_zero.Location = new System.Drawing.Point(121, 242);
            this.tb_precision_zero.Name = "tb_precision_zero";
            this.tb_precision_zero.Size = new System.Drawing.Size(104, 32);
            this.tb_precision_zero.TabIndex = 7;
            this.tb_precision_zero.Leave += new System.EventHandler(this.tb_precision_zero_Leave);
            this.tb_precision_zero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_precision_zero_MouseMove);
            // 
            // lb_precision_zero
            // 
            this.lb_precision_zero.AutoSize = true;
            this.lb_precision_zero.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_precision_zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_precision_zero.Location = new System.Drawing.Point(70, 241);
            this.lb_precision_zero.Name = "lb_precision_zero";
            this.lb_precision_zero.Size = new System.Drawing.Size(35, 30);
            this.lb_precision_zero.TabIndex = 8;
            this.lb_precision_zero.Text = "ε0";
            // 
            // lb_max_iter
            // 
            this.lb_max_iter.AutoSize = true;
            this.lb_max_iter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_max_iter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_max_iter.Location = new System.Drawing.Point(70, 50);
            this.lb_max_iter.Name = "lb_max_iter";
            this.lb_max_iter.Size = new System.Drawing.Size(188, 30);
            this.lb_max_iter.TabIndex = 10;
            this.lb_max_iter.Text = "Maksimum iteracji";
            // 
            // ud_iters
            // 
            this.ud_iters.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ud_iters.Location = new System.Drawing.Point(315, 48);
            this.ud_iters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_iters.Name = "ud_iters";
            this.ud_iters.Size = new System.Drawing.Size(104, 32);
            this.ud_iters.TabIndex = 11;
            this.ud_iters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_res_num_iter
            // 
            this.tb_res_num_iter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_res_num_iter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_num_iter.Location = new System.Drawing.Point(885, 50);
            this.tb_res_num_iter.MinimumSize = new System.Drawing.Size(40, 25);
            this.tb_res_num_iter.Name = "tb_res_num_iter";
            this.tb_res_num_iter.ReadOnly = true;
            this.tb_res_num_iter.Size = new System.Drawing.Size(100, 25);
            this.tb_res_num_iter.TabIndex = 14;
            // 
            // tb_res_zero_function_val
            // 
            this.tb_res_zero_function_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_res_zero_function_val.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_zero_function_val.Location = new System.Drawing.Point(439, 50);
            this.tb_res_zero_function_val.Name = "tb_res_zero_function_val";
            this.tb_res_zero_function_val.ReadOnly = true;
            this.tb_res_zero_function_val.Size = new System.Drawing.Size(234, 25);
            this.tb_res_zero_function_val.TabIndex = 15;
            this.tb_res_zero_function_val.TextChanged += new System.EventHandler(this.tb_res_zero_function_val_TextChanged);
            // 
            // lb_res_zero
            // 
            this.lb_res_zero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_res_zero.AutoSize = true;
            this.lb_res_zero.Location = new System.Drawing.Point(58, 50);
            this.lb_res_zero.Name = "lb_res_zero";
            this.lb_res_zero.Size = new System.Drawing.Size(49, 25);
            this.lb_res_zero.TabIndex = 16;
            this.lb_res_zero.Text = "x0 ≈";
            // 
            // lb_res_num_iter
            // 
            this.lb_res_num_iter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_res_num_iter.AutoSize = true;
            this.lb_res_num_iter.Location = new System.Drawing.Point(695, 50);
            this.lb_res_num_iter.Name = "lb_res_num_iter";
            this.lb_res_num_iter.Size = new System.Drawing.Size(184, 25);
            this.lb_res_num_iter.TabIndex = 18;
            this.lb_res_num_iter.Text = "Nr końcowej iteracji:";
            // 
            // lb_res_zero_function_val
            // 
            this.lb_res_zero_function_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_res_zero_function_val.AutoSize = true;
            this.lb_res_zero_function_val.Location = new System.Drawing.Point(367, 50);
            this.lb_res_zero_function_val.Name = "lb_res_zero_function_val";
            this.lb_res_zero_function_val.Size = new System.Drawing.Size(72, 25);
            this.lb_res_zero_function_val.TabIndex = 19;
            this.lb_res_zero_function_val.Text = "f(x0) = ";
            // 
            // tb_precision_sqrt
            // 
            this.tb_precision_sqrt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_precision_sqrt.Location = new System.Drawing.Point(315, 242);
            this.tb_precision_sqrt.Name = "tb_precision_sqrt";
            this.tb_precision_sqrt.Size = new System.Drawing.Size(104, 32);
            this.tb_precision_sqrt.TabIndex = 20;
            this.tb_precision_sqrt.Leave += new System.EventHandler(this.tb_precision_sqrt_Leave);
            this.tb_precision_sqrt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_precision_sqrt_MouseMove);
            // 
            // lb_precision_sqrt
            // 
            this.lb_precision_sqrt.AutoSize = true;
            this.lb_precision_sqrt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_precision_sqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_precision_sqrt.Location = new System.Drawing.Point(249, 241);
            this.lb_precision_sqrt.Name = "lb_precision_sqrt";
            this.lb_precision_sqrt.Size = new System.Drawing.Size(60, 30);
            this.lb_precision_sqrt.TabIndex = 21;
            this.lb_precision_sqrt.Text = "εsqrt";
            // 
            // ud_places_comma
            // 
            this.ud_places_comma.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ud_places_comma.Location = new System.Drawing.Point(315, 116);
            this.ud_places_comma.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ud_places_comma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_places_comma.Name = "ud_places_comma";
            this.ud_places_comma.Size = new System.Drawing.Size(104, 32);
            this.ud_places_comma.TabIndex = 22;
            this.ud_places_comma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_places_comma
            // 
            this.lb_places_comma.AutoSize = true;
            this.lb_places_comma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_places_comma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.lb_places_comma.Location = new System.Drawing.Point(70, 114);
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
            this.b_ok_2.Location = new System.Drawing.Point(369, 89);
            this.b_ok_2.Name = "b_ok_2";
            this.b_ok_2.Size = new System.Drawing.Size(98, 34);
            this.b_ok_2.TabIndex = 24;
            this.b_ok_2.Text = "Rysuj";
            this.b_ok_2.UseVisualStyleBackColor = false;
            this.b_ok_2.Click += new System.EventHandler(this.b_ok_2_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panelTitleBar.Controls.Add(this.pictureBoxLogo);
            this.panelTitleBar.Controls.Add(this.panel9);
            this.panelTitleBar.Controls.Add(this.label6);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Padding = new System.Windows.Forms.Padding(10);
            this.panelTitleBar.Size = new System.Drawing.Size(1674, 103);
            this.panelTitleBar.TabIndex = 25;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panel9.Controls.Add(this.bMinimize);
            this.panel9.Controls.Add(this.bFullscreen);
            this.panel9.Controls.Add(this.bClose);
            this.panel9.Location = new System.Drawing.Point(1480, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 43);
            this.panel9.TabIndex = 4;
            // 
            // bMinimize
            // 
            this.bMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.bMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.bMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.bMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bMinimize.IconSize = 15;
            this.bMinimize.Location = new System.Drawing.Point(2, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(64, 43);
            this.bMinimize.TabIndex = 3;
            this.bMinimize.UseVisualStyleBackColor = false;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bFullscreen
            // 
            this.bFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.bFullscreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.bFullscreen.FlatAppearance.BorderSize = 0;
            this.bFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFullscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bFullscreen.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.bFullscreen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bFullscreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bFullscreen.IconSize = 20;
            this.bFullscreen.Location = new System.Drawing.Point(66, 0);
            this.bFullscreen.Name = "bFullscreen";
            this.bFullscreen.Size = new System.Drawing.Size(64, 43);
            this.bFullscreen.TabIndex = 2;
            this.bFullscreen.UseVisualStyleBackColor = false;
            this.bFullscreen.Click += new System.EventHandler(this.bFullscreen_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bClose.IconSize = 20;
            this.bClose.Location = new System.Drawing.Point(130, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(64, 43);
            this.bClose.TabIndex = 1;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(172, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(608, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Przybliżanie miejsca zerowego funkcji metodą Newtona";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1674, 911);
            this.panel2.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(560, 911);
            this.panel8.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(35, 643);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 241);
            this.panel6.TabIndex = 29;
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
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel3.Controls.Add(this.bClear);
            this.panel3.Controls.Add(this.tb_precision_sqrt);
            this.panel3.Controls.Add(this.lb_precision_zero);
            this.panel3.Controls.Add(this.tb_precision_zero);
            this.panel3.Controls.Add(this.b_ok);
            this.panel3.Controls.Add(this.lb_places_comma);
            this.panel3.Controls.Add(this.tb_pkt_start);
            this.panel3.Controls.Add(this.ud_places_comma);
            this.panel3.Controls.Add(this.lb_pkt_start);
            this.panel3.Controls.Add(this.lb_precision_sqrt);
            this.panel3.Controls.Add(this.ud_iters);
            this.panel3.Controls.Add(this.lb_max_iter);
            this.panel3.Location = new System.Drawing.Point(35, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 387);
            this.panel3.TabIndex = 26;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.bClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bClear.IconSize = 30;
            this.bClear.Location = new System.Drawing.Point(124, 309);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(79, 46);
            this.bClear.TabIndex = 24;
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.udXmax);
            this.panel1.Controls.Add(this.udXmin);
            this.panel1.Controls.Add(this.b_ok_2);
            this.panel1.Controls.Add(this.tb_function);
            this.panel1.Controls.Add(this.lb_function);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(35, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 157);
            this.panel1.TabIndex = 25;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(205, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "xmax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(46, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "xmin";
            // 
            // udXmax
            // 
            this.udXmax.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.udXmax.Location = new System.Drawing.Point(278, 91);
            this.udXmax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udXmax.Name = "udXmax";
            this.udXmax.Size = new System.Drawing.Size(64, 32);
            this.udXmax.TabIndex = 26;
            // 
            // udXmin
            // 
            this.udXmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.udXmin.Location = new System.Drawing.Point(120, 91);
            this.udXmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udXmin.Name = "udXmin";
            this.udXmin.Size = new System.Drawing.Size(64, 32);
            this.udXmin.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.chart_res);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(566, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1070, 853);
            this.panel5.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panel4.Controls.Add(this.lb_res_num_iter);
            this.panel4.Controls.Add(this.tb_res_zero);
            this.panel4.Controls.Add(this.tb_res_zero_function_val);
            this.panel4.Controls.Add(this.tb_res_num_iter);
            this.panel4.Controls.Add(this.lb_res_zero_function_val);
            this.panel4.Controls.Add(this.lb_res_zero);
            this.panel4.Location = new System.Drawing.Point(15, 701);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1039, 118);
            this.panel4.TabIndex = 27;
            // 
            // tb_res_zero
            // 
            this.tb_res_zero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_res_zero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_res_zero.Location = new System.Drawing.Point(113, 50);
            this.tb_res_zero.Name = "tb_res_zero";
            this.tb_res_zero.ReadOnly = true;
            this.tb_res_zero.Size = new System.Drawing.Size(234, 25);
            this.tb_res_zero.TabIndex = 12;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ErrorImage = global::numerical_methods_Newton.Properties.Resources.metody2;
            this.pictureBoxLogo.Image = global::numerical_methods_Newton.Properties.Resources.metody2;
            this.pictureBoxLogo.InitialImage = global::numerical_methods_Newton.Properties.Resources.metody2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(70, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(87, 77);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormNewtonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1014);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewtonMethod";
            this.Text = "Wyznaczanie miejsca zerowego metodą Newtona";
            this.Load += new System.EventHandler(this.FormNewtonMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_places_comma)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udXmin)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.Label lb_max_iter;
        private System.Windows.Forms.NumericUpDown ud_iters;
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
        private System.Windows.Forms.Panel panelTitleBar;
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tb_res_zero;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton bMinimize;
        private FontAwesome.Sharp.IconButton bFullscreen;
        private FontAwesome.Sharp.IconButton bClose;
        private FontAwesome.Sharp.IconButton bClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udXmax;
        private System.Windows.Forms.NumericUpDown udXmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

