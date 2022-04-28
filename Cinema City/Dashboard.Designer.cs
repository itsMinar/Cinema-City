namespace Cinema_City
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashboardElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.movieReportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.analyticsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.runningMoviesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addMoviesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.running_Movies1 = new Cinema_City.User_Controls.Running_Movies();
            this.user_Dashboard1 = new Cinema_City.User_Controls.user_Dashboard();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.book_Ticket1 = new Cinema_City.User_Controls.Book_Ticket();
            this.add_Movies1 = new Cinema_City.User_Controls.Add_Movies();
            this.movie_Report1 = new Cinema_City.User_Controls.Movie_Report();
            this.analytics1 = new Cinema_City.User_Controls.Analytics();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardElipse
            // 
            this.dashboardElipse.ElipseRadius = 30;
            this.dashboardElipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.movieReportBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.analyticsBtn);
            this.panel1.Controls.Add(this.bookingBtn);
            this.panel1.Controls.Add(this.runningMoviesBtn);
            this.panel1.Controls.Add(this.addMoviesBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 775);
            this.panel1.TabIndex = 5;
            // 
            // movieReportBtn
            // 
            this.movieReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.movieReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.movieReportBtn.BorderRadius = 12;
            this.movieReportBtn.BorderThickness = 2;
            this.movieReportBtn.CheckedState.Parent = this.movieReportBtn;
            this.movieReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieReportBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.movieReportBtn.CustomImages.Parent = this.movieReportBtn;
            this.movieReportBtn.FillColor = System.Drawing.Color.Transparent;
            this.movieReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.movieReportBtn.ForeColor = System.Drawing.Color.White;
            this.movieReportBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.movieReportBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.movieReportBtn.HoverState.Parent = this.movieReportBtn;
            this.movieReportBtn.Location = new System.Drawing.Point(45, 482);
            this.movieReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.movieReportBtn.Name = "movieReportBtn";
            this.movieReportBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.movieReportBtn.ShadowDecoration.Parent = this.movieReportBtn;
            this.movieReportBtn.Size = new System.Drawing.Size(155, 39);
            this.movieReportBtn.TabIndex = 8;
            this.movieReportBtn.Text = "Movie Report";
            this.movieReportBtn.Click += new System.EventHandler(this.movieReportBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderRadius = 15;
            this.logoutBtn.BorderThickness = 2;
            this.logoutBtn.CheckedState.Parent = this.logoutBtn;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.logoutBtn.CustomImages.Parent = this.logoutBtn;
            this.logoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.Parent = this.logoutBtn;
            this.logoutBtn.Location = new System.Drawing.Point(37, 697);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ShadowDecoration.Parent = this.logoutBtn;
            this.logoutBtn.Size = new System.Drawing.Size(175, 46);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "LOG OUT";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // analyticsBtn
            // 
            this.analyticsBtn.BackColor = System.Drawing.Color.Transparent;
            this.analyticsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.analyticsBtn.BorderRadius = 12;
            this.analyticsBtn.BorderThickness = 2;
            this.analyticsBtn.CheckedState.Parent = this.analyticsBtn;
            this.analyticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyticsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.analyticsBtn.CustomImages.Parent = this.analyticsBtn;
            this.analyticsBtn.FillColor = System.Drawing.Color.Transparent;
            this.analyticsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.analyticsBtn.ForeColor = System.Drawing.Color.White;
            this.analyticsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.analyticsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.analyticsBtn.HoverState.Parent = this.analyticsBtn;
            this.analyticsBtn.Location = new System.Drawing.Point(45, 558);
            this.analyticsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.analyticsBtn.Name = "analyticsBtn";
            this.analyticsBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.analyticsBtn.ShadowDecoration.Parent = this.analyticsBtn;
            this.analyticsBtn.Size = new System.Drawing.Size(155, 39);
            this.analyticsBtn.TabIndex = 7;
            this.analyticsBtn.Text = "Analytics";
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.bookingBtn.BorderRadius = 12;
            this.bookingBtn.BorderThickness = 2;
            this.bookingBtn.CheckedState.Parent = this.bookingBtn;
            this.bookingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.bookingBtn.CustomImages.Parent = this.bookingBtn;
            this.bookingBtn.FillColor = System.Drawing.Color.Transparent;
            this.bookingBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookingBtn.ForeColor = System.Drawing.Color.White;
            this.bookingBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.bookingBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.bookingBtn.HoverState.Parent = this.bookingBtn;
            this.bookingBtn.Location = new System.Drawing.Point(45, 332);
            this.bookingBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.bookingBtn.ShadowDecoration.Parent = this.bookingBtn;
            this.bookingBtn.Size = new System.Drawing.Size(155, 39);
            this.bookingBtn.TabIndex = 7;
            this.bookingBtn.Text = "Book Tickets";
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // runningMoviesBtn
            // 
            this.runningMoviesBtn.BackColor = System.Drawing.Color.Transparent;
            this.runningMoviesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.runningMoviesBtn.BorderRadius = 12;
            this.runningMoviesBtn.BorderThickness = 2;
            this.runningMoviesBtn.CheckedState.Parent = this.runningMoviesBtn;
            this.runningMoviesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runningMoviesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.runningMoviesBtn.CustomImages.Parent = this.runningMoviesBtn;
            this.runningMoviesBtn.FillColor = System.Drawing.Color.Transparent;
            this.runningMoviesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.runningMoviesBtn.ForeColor = System.Drawing.Color.White;
            this.runningMoviesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.runningMoviesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.runningMoviesBtn.HoverState.Parent = this.runningMoviesBtn;
            this.runningMoviesBtn.Location = new System.Drawing.Point(45, 257);
            this.runningMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.runningMoviesBtn.Name = "runningMoviesBtn";
            this.runningMoviesBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.runningMoviesBtn.ShadowDecoration.Parent = this.runningMoviesBtn;
            this.runningMoviesBtn.Size = new System.Drawing.Size(155, 39);
            this.runningMoviesBtn.TabIndex = 7;
            this.runningMoviesBtn.Text = "Running Movies";
            this.runningMoviesBtn.Click += new System.EventHandler(this.runningMoviesBtn_Click);
            // 
            // addMoviesBtn
            // 
            this.addMoviesBtn.BackColor = System.Drawing.Color.Transparent;
            this.addMoviesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.addMoviesBtn.BorderRadius = 12;
            this.addMoviesBtn.BorderThickness = 2;
            this.addMoviesBtn.CheckedState.Parent = this.addMoviesBtn;
            this.addMoviesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMoviesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.addMoviesBtn.CustomImages.Parent = this.addMoviesBtn;
            this.addMoviesBtn.FillColor = System.Drawing.Color.Transparent;
            this.addMoviesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addMoviesBtn.ForeColor = System.Drawing.Color.White;
            this.addMoviesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.addMoviesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.addMoviesBtn.HoverState.Parent = this.addMoviesBtn;
            this.addMoviesBtn.Location = new System.Drawing.Point(45, 407);
            this.addMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addMoviesBtn.Name = "addMoviesBtn";
            this.addMoviesBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.addMoviesBtn.ShadowDecoration.Parent = this.addMoviesBtn;
            this.addMoviesBtn.Size = new System.Drawing.Size(155, 39);
            this.addMoviesBtn.TabIndex = 7;
            this.addMoviesBtn.Text = "Add Movies";
            this.addMoviesBtn.Click += new System.EventHandler(this.addMoviesBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.dashboardBtn.BorderRadius = 12;
            this.dashboardBtn.BorderThickness = 2;
            this.dashboardBtn.CheckedState.Parent = this.dashboardBtn;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.dashboardBtn.CustomImages.Parent = this.dashboardBtn;
            this.dashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.dashboardBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.HoverState.Parent = this.dashboardBtn;
            this.dashboardBtn.Location = new System.Drawing.Point(45, 182);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.PressedColor = System.Drawing.Color.Firebrick;
            this.dashboardBtn.ShadowDecoration.Parent = this.dashboardBtn;
            this.dashboardBtn.Size = new System.Drawing.Size(155, 39);
            this.dashboardBtn.TabIndex = 7;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.analytics1);
            this.panel2.Controls.Add(this.movie_Report1);
            this.panel2.Controls.Add(this.add_Movies1);
            this.panel2.Controls.Add(this.book_Ticket1);
            this.panel2.Controls.Add(this.running_Movies1);
            this.panel2.Controls.Add(this.user_Dashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 775);
            this.panel2.TabIndex = 6;
            // 
            // running_Movies1
            // 
            this.running_Movies1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.running_Movies1.Location = new System.Drawing.Point(13, 10);
            this.running_Movies1.Margin = new System.Windows.Forms.Padding(4);
            this.running_Movies1.Name = "running_Movies1";
            this.running_Movies1.Size = new System.Drawing.Size(1080, 751);
            this.running_Movies1.TabIndex = 1;
            // 
            // user_Dashboard1
            // 
            this.user_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.user_Dashboard1.Location = new System.Drawing.Point(13, 10);
            this.user_Dashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_Dashboard1.Name = "user_Dashboard1";
            this.user_Dashboard1.Size = new System.Drawing.Size(1080, 751);
            this.user_Dashboard1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.panel1;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.panel2;
            // 
            // book_Ticket1
            // 
            this.book_Ticket1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.book_Ticket1.Location = new System.Drawing.Point(13, 10);
            this.book_Ticket1.Margin = new System.Windows.Forms.Padding(4);
            this.book_Ticket1.Name = "book_Ticket1";
            this.book_Ticket1.Size = new System.Drawing.Size(1080, 751);
            this.book_Ticket1.TabIndex = 2;
            // 
            // add_Movies1
            // 
            this.add_Movies1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.add_Movies1.Location = new System.Drawing.Point(13, 10);
            this.add_Movies1.Margin = new System.Windows.Forms.Padding(4);
            this.add_Movies1.Name = "add_Movies1";
            this.add_Movies1.Size = new System.Drawing.Size(1080, 751);
            this.add_Movies1.TabIndex = 3;
            // 
            // movie_Report1
            // 
            this.movie_Report1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.movie_Report1.Location = new System.Drawing.Point(13, 10);
            this.movie_Report1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movie_Report1.Name = "movie_Report1";
            this.movie_Report1.Size = new System.Drawing.Size(1080, 751);
            this.movie_Report1.TabIndex = 4;
            // 
            // analytics1
            // 
            this.analytics1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.analytics1.Location = new System.Drawing.Point(13, 10);
            this.analytics1.Margin = new System.Windows.Forms.Padding(4);
            this.analytics1.Name = "analytics1";
            this.analytics1.Size = new System.Drawing.Size(1080, 751);
            this.analytics1.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1341, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse dashboardElipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private Guna.UI2.WinForms.Guna2Button bookingBtn;
        private Guna.UI2.WinForms.Guna2Button runningMoviesBtn;
        private Guna.UI2.WinForms.Guna2Button addMoviesBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button analyticsBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Button movieReportBtn;
        private User_Controls.user_Dashboard user_Dashboard1;
        private User_Controls.Running_Movies running_Movies1;
        private User_Controls.Book_Ticket book_Ticket1;
        private User_Controls.Add_Movies add_Movies1;
        private User_Controls.Movie_Report movie_Report1;
        private User_Controls.Analytics analytics1;
    }
}