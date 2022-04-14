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
            this.minimizeBtn.Location = new System.Drawing.Point(755, 10);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimizeBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.minimizeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.minimizeBtn.Size = new System.Drawing.Size(18, 18);
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
            this.exitBtn.Location = new System.Drawing.Point(779, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.exitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.exitBtn.Size = new System.Drawing.Size(18, 18);
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
            this.CCity_1.Location = new System.Drawing.Point(20, 40);
            this.CCity_1.Name = "CCity_1";
            this.CCity_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total Income";
            this.CCity_1.Series.Add(series3);
            this.CCity_1.Size = new System.Drawing.Size(371, 260);
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
            this.CCity_2.Location = new System.Drawing.Point(416, 40);
            this.CCity_2.Name = "CCity_2";
            this.CCity_2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Income";
            this.CCity_2.Series.Add(series1);
            this.CCity_2.Size = new System.Drawing.Size(371, 260);
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
            this.CCity_3.Location = new System.Drawing.Point(20, 316);
            this.CCity_3.Name = "CCity_3";
            this.CCity_3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CCity_3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))))};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Income";
            this.CCity_3.Series.Add(series2);
            this.CCity_3.Size = new System.Drawing.Size(371, 260);
            this.CCity_3.TabIndex = 6;
            this.CCity_3.Text = "chart1";
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CCity_2);
            this.Controls.Add(this.CCity_3);
            this.Controls.Add(this.CCity_1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(810, 610);
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CCity_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCity_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaControlBox minimizeBtn;
        private Guna.UI.WinForms.GunaControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CCity_3;
    }
}
