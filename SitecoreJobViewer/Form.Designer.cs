namespace SitecoreJobViewer
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.AttachButton = new System.Windows.Forms.Button();
            this.JobStatusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ServerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastUpdatedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MessageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.JobRangeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.JobsDataGridView = new System.Windows.Forms.DataGridView();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessTokenLabel = new System.Windows.Forms.Label();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.JobStatusChart)).BeginInit();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobRangeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AttachButton
            // 
            this.AttachButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AttachButton.Location = new System.Drawing.Point(12, 12);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(90, 44);
            this.AttachButton.TabIndex = 1;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = false;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_ClickAsync);
            this.AttachButton.Enter += new System.EventHandler(this.Control_Enter);
            this.AttachButton.Leave += new System.EventHandler(this.On_Leave);

            // 
            // JobStatusChart
            // 
            this.JobStatusChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobStatusChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JobStatusChart.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.JobStatusChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Interval = 10D;
            chartArea1.AxisX2.Maximum = 100D;
            chartArea1.AxisX2.Minimum = 0D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Interval = 2D;
            chartArea1.AxisY.LabelStyle.Interval = 1D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.Interval = 1D;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.IsMarksNextToAxis = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.LabelStyle.Interval = 2D;
            chartArea1.AxisY2.LabelStyle.IntervalOffset = 1D;
            chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.MajorTickMark.Size = 0.5F;
            chartArea1.AxisY2.Maximum = 16D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 60F;
            chartArea1.Name = "ChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.JobStatusChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.MaximumAutoSize = 25F;
            legend1.Name = "Legend";
            legend1.Position.Auto = false;
            legend1.Position.Height = 32.5F;
            legend1.Position.Width = 10.2F;
            legend1.Position.X = 89.8F;
            this.JobStatusChart.Legends.Add(legend1);
            this.JobStatusChart.Location = new System.Drawing.Point(12, 65);
            this.JobStatusChart.Name = "JobStatusChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend";
            series1.Name = "RUNNING";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend";
            series2.Name = "FINISHED";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend";
            series3.Name = "QUEUED";
            this.JobStatusChart.Series.Add(series1);
            this.JobStatusChart.Series.Add(series2);
            this.JobStatusChart.Series.Add(series3);
            this.JobStatusChart.Size = new System.Drawing.Size(776, 158);
            this.JobStatusChart.TabIndex = 5;
            this.JobStatusChart.TabStop = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerStatusLabel,
            this.LastUpdatedStatusLabel,
            this.MessageStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 530);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ServerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ServerStatusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ServerStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 2);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.ServerStatusLabel.Size = new System.Drawing.Size(101, 17);
            this.ServerStatusLabel.Text = "ServerStatusLabel";
            // 
            // LastUpdatedStatusLabel
            // 
            this.LastUpdatedStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.LastUpdatedStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.LastUpdatedStatusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LastUpdatedStatusLabel.Name = "LastUpdatedStatusLabel";
            this.LastUpdatedStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.LastUpdatedStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastUpdatedStatusLabel.Size = new System.Drawing.Size(125, 17);
            this.LastUpdatedStatusLabel.Text = "LastUpdatedStatusLabel";
            // 
            // MessageStatusLabel
            // 
            this.MessageStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.MessageStatusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MessageStatusLabel.Name = "MessageStatusLabel";
            this.MessageStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.MessageStatusLabel.Size = new System.Drawing.Size(108, 17);
            this.MessageStatusLabel.Text = "MessageStatusLabel";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextBox.BackColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsernameTextBox.Location = new System.Drawing.Point(525, 14);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 18);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "sitecore\\admin";
            this.UsernameTextBox.Enter += new System.EventHandler(this.Control_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.On_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.BackColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.PasswordTextBox.Location = new System.Drawing.Point(688, 15);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 18);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "b";
            this.PasswordTextBox.Enter += new System.EventHandler(this.Control_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.On_Leave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsernameLabel.Location = new System.Drawing.Point(460, 17);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 12);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "User name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PasswordLabel.Location = new System.Drawing.Point(638, 18);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(50, 12);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password:";
            // 
            // JobRangeChart
            // 
            this.JobRangeChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobRangeChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JobRangeChart.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.JobRangeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX2.Interval = 1D;
            chartArea2.AxisX2.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX2.LabelStyle.Format = " ";
            chartArea2.AxisX2.LabelStyle.Interval = 1D;
            chartArea2.AxisX2.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX2.LabelStyle.IsStaggered = true;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX2.MajorTickMark.Size = 0.5F;
            chartArea2.AxisX2.Maximum = 16D;
            chartArea2.AxisX2.Minimum = 0D;
            chartArea2.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Interval = 10D;
            chartArea2.AxisY2.Maximum = 100D;
            chartArea2.AxisY2.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 60F;
            chartArea2.Name = "ChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.JobRangeChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.JobRangeChart.Legends.Add(legend2);
            this.JobRangeChart.Location = new System.Drawing.Point(12, 235);
            this.JobRangeChart.Name = "JobRangeChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series4.Legend = "Legend1";
            series4.Name = "Jobs";
            series4.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValuesPerPoint = 2;
            this.JobRangeChart.Series.Add(series4);
            this.JobRangeChart.Size = new System.Drawing.Size(776, 158);
            this.JobRangeChart.TabIndex = 6;
            this.JobRangeChart.TabStop = false;
            // 
            // JobsDataGridView
            // 
            this.JobsDataGridView.AllowUserToAddRows = false;
            this.JobsDataGridView.AllowUserToDeleteRows = false;
            this.JobsDataGridView.AllowUserToResizeRows = false;
            this.JobsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JobsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JobsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.JobsDataGridView.ColumnHeadersHeight = 19;
            this.JobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.JobsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobName,
            this.JobHandle,
            this.Processed,
            this.JobState});
            this.JobsDataGridView.EnableHeadersVisualStyles = false;
            this.JobsDataGridView.Location = new System.Drawing.Point(12, 405);
            this.JobsDataGridView.Name = "JobsDataGridView";
            this.JobsDataGridView.ReadOnly = true;
            this.JobsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.JobsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.JobsDataGridView.Size = new System.Drawing.Size(776, 125);
            this.JobsDataGridView.TabIndex = 7;
            this.JobsDataGridView.TabStop = false;
            // 
            // JobName
            // 
            this.JobName.FillWeight = 40F;
            this.JobName.HeaderText = "JobName";
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            // 
            // JobHandle
            // 
            this.JobHandle.FillWeight = 40F;
            this.JobHandle.HeaderText = "JobHandle";
            this.JobHandle.Name = "JobHandle";
            this.JobHandle.ReadOnly = true;
            // 
            // Processed
            // 
            this.Processed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Processed.FillWeight = 10F;
            this.Processed.HeaderText = "Processed";
            this.Processed.Name = "Processed";
            this.Processed.ReadOnly = true;
            // 
            // JobState
            // 
            this.JobState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JobState.FillWeight = 10F;
            this.JobState.HeaderText = "JobState";
            this.JobState.Name = "JobState";
            this.JobState.ReadOnly = true;
            // 
            // AccessTokenLabel
            // 
            this.AccessTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessTokenLabel.AutoSize = true;
            this.AccessTokenLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccessTokenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessTokenLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AccessTokenLabel.Location = new System.Drawing.Point(460, 41);
            this.AccessTokenLabel.Name = "AccessTokenLabel";
            this.AccessTokenLabel.Size = new System.Drawing.Size(65, 12);
            this.AccessTokenLabel.TabIndex = 11;
            this.AccessTokenLabel.Text = "Access token:";
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessTokenTextBox.BackColor = System.Drawing.Color.Gray;
            this.AccessTokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessTokenTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.AccessTokenTextBox.Location = new System.Drawing.Point(525, 38);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(263, 18);
            this.AccessTokenTextBox.TabIndex = 4;
            this.AccessTokenTextBox.Enter += new System.EventHandler(this.Control_Enter);
            this.AccessTokenTextBox.Leave += new System.EventHandler(this.On_Leave);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.AccessTokenLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.JobsDataGridView);
            this.Controls.Add(this.JobRangeChart);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.JobStatusChart);
            this.Controls.Add(this.AttachButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "SitecoreJobViewer";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JobStatusChart)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobRangeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart JobStatusChart;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LastUpdatedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ServerStatusLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart JobRangeChart;
        private System.Windows.Forms.ToolStripStatusLabel MessageStatusLabel;
        private System.Windows.Forms.DataGridView JobsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processed;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobState;
        private System.Windows.Forms.Label AccessTokenLabel;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
    }
}

