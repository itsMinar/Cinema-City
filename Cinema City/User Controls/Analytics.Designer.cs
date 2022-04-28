namespace Cinema_City.User_Controls
{
    partial class Analytics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.minimizeBtn = new Guna.UI.WinForms.GunaControlBox();
            this.exitBtn = new Guna.UI.WinForms.GunaControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CCity_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CCity_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CCity_3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkNowBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.fromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.AnimationHoverSpeed = 0.07F;
            this.minimizeBtn.AnimationSpeed = 0.03F;
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimizeBtn.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.minimizeBtn.IconColor = System.Drawing.Color.Black;
            this.minimizeBtn.IconSize = 12F;
            this.minimizeBtn.Location = new System.Drawing.Point(1007, 12);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimizeBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.minimizeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.minimizeBtn.Size = new System.Drawing.Size(24, 22);
            this.minimizeBtn.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AnimationHoverSpeed = 0.07F;
            this.exitBtn.AnimationSpeed = 0.03F;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconSize = 12F;
            this.exitBtn.Location = new System.Drawing.Point(1039, 12);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.exitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.exitBtn.Size = new System.Drawing.Size(24, 22);
            this.exitBtn.TabIndex = 5;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // CCity_1
            // 
            this.CCity_1.BackColor = System.Drawing.Color.DarkGray;
            chartArea3.Name = "ChartArea1";
            this.CCity_1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CCity_1.Legends.Add(legend3);
            this.CCity_1.Location = new System.Drawing.Point(27, 49);
            this.CCity_1.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_1.Name = "CCity_1";
            this.CCity_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total Income";
            this.CCity_1.Series.Add(series3);
            this.CCity_1.Size = new System.Drawing.Size(495, 320);
            this.CCity_1.TabIndex = 6;
            this.CCity_1.Text = "chart1";
            // 
            // CCity_2
            // 
            this.CCity_2.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.CCity_2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CCity_2.Legends.Add(legend1);
            this.CCity_2.Location = new System.Drawing.Point(555, 49);
            this.CCity_2.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_2.Name = "CCity_2";
            this.CCity_2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Income";
            this.CCity_2.Series.Add(series1);
            this.CCity_2.Size = new System.Drawing.Size(495, 320);
            this.CCity_2.TabIndex = 6;
            this.CCity_2.Text = "chart1";
            // 
            // CCity_3
            // 
            this.CCity_3.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.CCity_3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CCity_3.Legends.Add(legend2);
            this.CCity_3.Location = new System.Drawing.Point(27, 389);
            this.CCity_3.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_3.Name = "CCity_3";
            this.CCity_3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Income";
            this.CCity_3.Series.Add(series2);
            this.CCity_3.Size = new System.Drawing.Size(495, 320);
            this.CCity_3.TabIndex = 6;
            this.CCity_3.Text = "chart1";
            // 
            // checkNowBtn
            // 
            this.checkNowBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.BorderColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.BorderRadius = 10;
            this.checkNowBtn.BorderThickness = 2;
            this.checkNowBtn.CheckedState.Parent = this.checkNowBtn;
            this.checkNowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNowBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.checkNowBtn.CustomImages.Parent = this.checkNowBtn;
            this.checkNowBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.checkNowBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNowBtn.ForeColor = System.Drawing.Color.White;
            this.checkNowBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.checkNowBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.checkNowBtn.HoverState.Parent = this.checkNowBtn;
            this.checkNowBtn.Location = new System.Drawing.Point(705, 638);
            this.checkNowBtn.Margin = new System.Windows.Forms.Padding(0);
            this.checkNowBtn.Name = "checkNowBtn";
            this.checkNowBtn.PressedColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.ShadowDecoration.Parent = this.checkNowBtn;
            this.checkNowBtn.Size = new System.Drawing.Size(187, 49);
            this.checkNowBtn.TabIndex = 19;
            this.checkNowBtn.Text = "CHECK NOW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 518);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(654, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "From:";
            // 
            // toDate
            // 
            this.toDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.toDate.BorderRadius = 6;
            this.toDate.BorderThickness = 2;
            this.toDate.CheckedState.Parent = this.toDate;
            this.toDate.FillColor = System.Drawing.Color.Transparent;
            this.toDate.ForeColor = System.Drawing.Color.White;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.toDate.HoverState.Parent = this.toDate;
            this.toDate.Location = new System.Drawing.Point(654, 559);
            this.toDate.Margin = new System.Windows.Forms.Padding(4);
            this.toDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDate.Name = "toDate";
            this.toDate.ShadowDecoration.Parent = this.toDate;
            this.toDate.Size = new System.Drawing.Size(289, 44);
            this.toDate.TabIndex = 15;
            this.toDate.Value = new System.DateTime(2022, 4, 15, 21, 55, 9, 455);
            // 
            // fromDate
            // 
            this.fromDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.fromDate.BorderRadius = 6;
            this.fromDate.BorderThickness = 2;
            this.fromDate.CheckedState.Parent = this.fromDate;
            this.fromDate.FillColor = System.Drawing.Color.Transparent;
            this.fromDate.ForeColor = System.Drawing.Color.White;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fromDate.HoverState.Parent = this.fromDate;
            this.fromDate.Location = new System.Drawing.Point(654, 447);
            this.fromDate.Margin = new System.Windows.Forms.Padding(4);
            this.fromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDate.Name = "fromDate";
            this.fromDate.ShadowDecoration.Parent = this.fromDate;
            this.fromDate.Size = new System.Drawing.Size(289, 44);
            this.fromDate.TabIndex = 16;
            this.fromDate.Value = new System.DateTime(2022, 4, 15, 21, 55, 9, 455);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.checkNowBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.CCity_2);
            this.Controls.Add(this.CCity_3);
            this.Controls.Add(this.CCity_1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1080, 751);
            this.VisibleChanged += new System.EventHandler(this.Analytics_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CCity_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaControlBox minimizeBtn;
        private Guna.UI.WinForms.GunaControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_3;
        private Guna.UI2.WinForms.Guna2Button checkNowBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDate;
    }
}
