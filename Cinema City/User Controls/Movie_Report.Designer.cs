namespace Cinema_City.User_Controls
{
    partial class Movie_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.minimizeBtn = new Guna.UI.WinForms.GunaControlBox();
            this.exitBtn = new Guna.UI.WinForms.GunaControlBox();
            this.Movie_Income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkNowBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Income)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
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
            this.minimizeBtn.Location = new System.Drawing.Point(755, 10);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimizeBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.minimizeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.minimizeBtn.Size = new System.Drawing.Size(18, 18);
            this.minimizeBtn.TabIndex = 6;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AnimationHoverSpeed = 0.07F;
            this.exitBtn.AnimationSpeed = 0.03F;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconSize = 12F;
            this.exitBtn.Location = new System.Drawing.Point(779, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.exitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.exitBtn.Size = new System.Drawing.Size(18, 18);
            this.exitBtn.TabIndex = 7;
            // 
            // Movie_Income
            // 
            chartArea1.Name = "ChartArea1";
            this.Movie_Income.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Movie_Income.Legends.Add(legend1);
            this.Movie_Income.Location = new System.Drawing.Point(38, 40);
            this.Movie_Income.Name = "Movie_Income";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "movie_income";
            this.Movie_Income.Series.Add(series1);
            this.Movie_Income.Size = new System.Drawing.Size(460, 379);
            this.Movie_Income.TabIndex = 8;
            this.Movie_Income.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(549, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "From:";
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
            this.fromDate.Location = new System.Drawing.Point(549, 137);
            this.fromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDate.Name = "fromDate";
            this.fromDate.ShadowDecoration.Parent = this.fromDate;
            this.fromDate.Size = new System.Drawing.Size(217, 36);
            this.fromDate.TabIndex = 9;
            this.fromDate.Value = new System.DateTime(2022, 4, 15, 21, 55, 9, 455);
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
            this.toDate.Location = new System.Drawing.Point(549, 228);
            this.toDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDate.Name = "toDate";
            this.toDate.ShadowDecoration.Parent = this.toDate;
            this.toDate.Size = new System.Drawing.Size(217, 36);
            this.toDate.TabIndex = 9;
            this.toDate.Value = new System.DateTime(2022, 4, 15, 21, 55, 9, 455);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(549, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
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
            this.checkNowBtn.Location = new System.Drawing.Point(587, 302);
            this.checkNowBtn.Margin = new System.Windows.Forms.Padding(0);
            this.checkNowBtn.Name = "checkNowBtn";
            this.checkNowBtn.PressedColor = System.Drawing.Color.Transparent;
            this.checkNowBtn.ShadowDecoration.Parent = this.checkNowBtn;
            this.checkNowBtn.Size = new System.Drawing.Size(140, 40);
            this.checkNowBtn.TabIndex = 14;
            this.checkNowBtn.Text = "CHECK NOW";
            this.checkNowBtn.Click += new System.EventHandler(this.checkNowBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "Individual Income of Movies";
            // 
            // Movie_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.checkNowBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.Movie_Income);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "Movie_Report";
            this.Size = new System.Drawing.Size(810, 610);
            this.Load += new System.EventHandler(this.Movie_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaControlBox minimizeBtn;
        private Guna.UI.WinForms.GunaControlBox exitBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Movie_Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDate;
        private Guna.UI2.WinForms.Guna2Button checkNowBtn;
        private System.Windows.Forms.Label label3;
    }
}
