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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
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
            chartArea21.Name = "ChartArea1";
            this.CCity_1.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.CCity_1.Legends.Add(legend21);
            this.CCity_1.Location = new System.Drawing.Point(27, 49);
            this.CCity_1.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_1.Name = "CCity_1";
            this.CCity_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Total Income";
            this.CCity_1.Series.Add(series21);
            this.CCity_1.Size = new System.Drawing.Size(495, 320);
            this.CCity_1.TabIndex = 6;
            this.CCity_1.Text = "chart1";
            // 
            // CCity_2
            // 
            this.CCity_2.BackColor = System.Drawing.Color.DarkGray;
            chartArea19.Name = "ChartArea1";
            this.CCity_2.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.CCity_2.Legends.Add(legend19);
            this.CCity_2.Location = new System.Drawing.Point(555, 49);
            this.CCity_2.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_2.Name = "CCity_2";
            this.CCity_2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Total Income";
            this.CCity_2.Series.Add(series19);
            this.CCity_2.Size = new System.Drawing.Size(495, 320);
            this.CCity_2.TabIndex = 6;
            this.CCity_2.Text = "chart1";
            // 
            // CCity_3
            // 
            this.CCity_3.BackColor = System.Drawing.Color.DarkGray;
            chartArea20.Name = "ChartArea1";
            this.CCity_3.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.CCity_3.Legends.Add(legend20);
            this.CCity_3.Location = new System.Drawing.Point(27, 389);
            this.CCity_3.Margin = new System.Windows.Forms.Padding(4);
            this.CCity_3.Name = "CCity_3";
            this.CCity_3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Total Income";
            this.CCity_3.Series.Add(series20);
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
            this.checkNowBtn.Location = new System.Drawing.Point(709, 595);
            this.checkNowBtn.Margin = new System.Windows.Forms.Padding(0);
            this.checkNowBtn.Name = "checkNowBtn";
            this.checkNowBtn.PressedColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.ShadowDecoration.Parent = this.checkNowBtn;
            this.checkNowBtn.Size = new System.Drawing.Size(187, 49);
            this.checkNowBtn.TabIndex = 19;
            this.checkNowBtn.Text = "CHECK NOW";
            this.checkNowBtn.Click += new System.EventHandler(this.checkNowBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(825, 462);
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
            this.label1.Location = new System.Drawing.Point(573, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "From:";
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "dd-MM-yyyy";
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(573, 510);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(210, 38);
            this.fromDate.TabIndex = 20;
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "dd-MM-yyyy";
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(825, 510);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(210, 38);
            this.toDate.TabIndex = 20;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.checkNowBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
    }
}
