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
            this.iconButtonInfo = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bMinimize = new FontAwesome.Sharp.IconButton();
            this.bFullscreen = new FontAwesome.Sharp.IconButton();
            this.bClose = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.panelAuthors = new System.Windows.Forms.Panel();
            this.panelNames = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelProperties = new System.Windows.Forms.Panel();
            this.bClear = new FontAwesome.Sharp.IconButton();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.udXmax = new System.Windows.Forms.NumericUpDown();
            this.udXmin = new System.Windows.Forms.NumericUpDown();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.tb_res_zero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_iters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_places_comma)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.panelAuthors.SuspendLayout();
            this.panelNames.SuspendLayout();
            this.panelProperties.SuspendLayout();
            this.panelFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udXmin)).BeginInit();
            this.panelChart.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_res
            // 
            this.chart_res.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart_res.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_res.Legends.Add(legend1);
            this.chart_res.Location = new System.Drawing.Point(15, 16);
            this.chart_res.Name = "chart_res";
            this.chart_res.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_res.Series.Add(series1);
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
            this.panelTitleBar.Controls.Add(this.iconButtonInfo);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
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
            // iconButtonInfo
            // 
            this.iconButtonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonInfo.FlatAppearance.BorderSize = 0;
            this.iconButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.iconButtonInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButtonInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.iconButtonInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo.IconSize = 25;
            this.iconButtonInfo.Location = new System.Drawing.Point(1634, 71);
            this.iconButtonInfo.Name = "iconButtonInfo";
            this.iconButtonInfo.Size = new System.Drawing.Size(40, 32);
            this.iconButtonInfo.TabIndex = 6;
            this.iconButtonInfo.UseVisualStyleBackColor = true;
            this.iconButtonInfo.Click += new System.EventHandler(this.iconButtonInfo_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::numerical_methods_Newton.Properties.Resources.metody2;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.label6.Location = new System.Drawing.Point(145, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(608, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Przybliżanie miejsca zerowego funkcji metodą Newtona";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelLeftSide);
            this.panelMain.Controls.Add(this.panelChart);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.panelMain.Location = new System.Drawing.Point(0, 103);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1674, 911);
            this.panelMain.TabIndex = 27;
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.Controls.Add(this.panelAuthors);
            this.panelLeftSide.Controls.Add(this.panelProperties);
            this.panelLeftSide.Controls.Add(this.panelFunction);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(560, 911);
            this.panelLeftSide.TabIndex = 30;
            // 
            // panelAuthors
            // 
            this.panelAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panelAuthors.Controls.Add(this.panelNames);
            this.panelAuthors.Controls.Add(this.label5);
            this.panelAuthors.Location = new System.Drawing.Point(35, 643);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(494, 241);
            this.panelAuthors.TabIndex = 29;
            // 
            // panelNames
            // 
            this.panelNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panelNames.Controls.Add(this.label4);
            this.panelNames.Controls.Add(this.label1);
            this.panelNames.Controls.Add(this.label2);
            this.panelNames.Controls.Add(this.label3);
            this.panelNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNames.Location = new System.Drawing.Point(0, 0);
            this.panelNames.Name = "panelNames";
            this.panelNames.Size = new System.Drawing.Size(494, 146);
            this.panelNames.TabIndex = 29;
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
            // panelProperties
            // 
            this.panelProperties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panelProperties.Controls.Add(this.bClear);
            this.panelProperties.Controls.Add(this.tb_precision_sqrt);
            this.panelProperties.Controls.Add(this.lb_precision_zero);
            this.panelProperties.Controls.Add(this.tb_precision_zero);
            this.panelProperties.Controls.Add(this.b_ok);
            this.panelProperties.Controls.Add(this.lb_places_comma);
            this.panelProperties.Controls.Add(this.tb_pkt_start);
            this.panelProperties.Controls.Add(this.ud_places_comma);
            this.panelProperties.Controls.Add(this.lb_pkt_start);
            this.panelProperties.Controls.Add(this.lb_precision_sqrt);
            this.panelProperties.Controls.Add(this.ud_iters);
            this.panelProperties.Controls.Add(this.lb_max_iter);
            this.panelProperties.Location = new System.Drawing.Point(35, 221);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(494, 387);
            this.panelProperties.TabIndex = 26;
            this.panelProperties.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
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
            // panelFunction
            // 
            this.panelFunction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panelFunction.Controls.Add(this.label8);
            this.panelFunction.Controls.Add(this.label7);
            this.panelFunction.Controls.Add(this.udXmax);
            this.panelFunction.Controls.Add(this.udXmin);
            this.panelFunction.Controls.Add(this.b_ok_2);
            this.panelFunction.Controls.Add(this.tb_function);
            this.panelFunction.Controls.Add(this.lb_function);
            this.panelFunction.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFunction.Location = new System.Drawing.Point(35, 31);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(494, 157);
            this.panelFunction.TabIndex = 25;
            this.panelFunction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.panelChart.Controls.Add(this.chart_res);
            this.panelChart.Controls.Add(this.panelResults);
            this.panelChart.Location = new System.Drawing.Point(566, 31);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1070, 853);
            this.panelChart.TabIndex = 28;
            // 
            // panelResults
            // 
            this.panelResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.panelResults.Controls.Add(this.lb_res_num_iter);
            this.panelResults.Controls.Add(this.tb_res_zero);
            this.panelResults.Controls.Add(this.tb_res_zero_function_val);
            this.panelResults.Controls.Add(this.tb_res_num_iter);
            this.panelResults.Controls.Add(this.lb_res_zero_function_val);
            this.panelResults.Controls.Add(this.lb_res_zero);
            this.panelResults.Location = new System.Drawing.Point(15, 701);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(1039, 118);
            this.panelResults.TabIndex = 27;
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
            // FormNewtonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1674, 1014);
            this.Controls.Add(this.panelMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelLeftSide.ResumeLayout(false);
            this.panelAuthors.ResumeLayout(false);
            this.panelAuthors.PerformLayout();
            this.panelNames.ResumeLayout(false);
            this.panelNames.PerformLayout();
            this.panelProperties.ResumeLayout(false);
            this.panelProperties.PerformLayout();
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udXmin)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
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
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Panel panelProperties;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelAuthors;
        private System.Windows.Forms.Panel panelNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelLeftSide;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonInfo;
    }
}

