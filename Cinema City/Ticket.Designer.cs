namespace Cinema_City
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.exitBtn = new Guna.UI.WinForms.GunaControlBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PrintBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.barCodeBox = new System.Windows.Forms.PictureBox();
            this.qrCodeBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pSeat = new System.Windows.Forms.Label();
            this.pTicketNumber = new System.Windows.Forms.Label();
            this.pDate = new System.Windows.Forms.Label();
            this.pTime = new System.Windows.Forms.Label();
            this.pTheatre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AnimationHoverSpeed = 0.07F;
            this.exitBtn.AnimationSpeed = 0.03F;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconSize = 15F;
            this.exitBtn.Location = new System.Drawing.Point(755, 27);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitBtn.OnHoverIconColor = System.Drawing.Color.White;
            this.exitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.exitBtn.Size = new System.Drawing.Size(27, 25);
            this.exitBtn.TabIndex = 3;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(734, 418);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ShadowDecoration.Parent = this.PrintBtn;
            this.PrintBtn.Size = new System.Drawing.Size(48, 41);
            this.PrintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PrintBtn.TabIndex = 5;
            this.PrintBtn.TabStop = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // barCodeBox
            // 
            this.barCodeBox.Location = new System.Drawing.Point(351, 330);
            this.barCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.barCodeBox.Name = "barCodeBox";
            this.barCodeBox.Size = new System.Drawing.Size(351, 108);
            this.barCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barCodeBox.TabIndex = 31;
            this.barCodeBox.TabStop = false;
            // 
            // qrCodeBox
            // 
            this.qrCodeBox.Location = new System.Drawing.Point(177, 314);
            this.qrCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeBox.Name = "qrCodeBox";
            this.qrCodeBox.Size = new System.Drawing.Size(155, 155);
            this.qrCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodeBox.TabIndex = 30;
            this.qrCodeBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(278, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(306, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Seat No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Purchased Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(287, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ticket No:";
            // 
            // pTotalPrice
            // 
            this.pTotalPrice.AutoSize = true;
            this.pTotalPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTotalPrice.ForeColor = System.Drawing.Color.White;
            this.pTotalPrice.Location = new System.Drawing.Point(418, 216);
            this.pTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pTotalPrice.Name = "pTotalPrice";
            this.pTotalPrice.Size = new System.Drawing.Size(22, 27);
            this.pTotalPrice.TabIndex = 24;
            this.pTotalPrice.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Show Time:";
            // 
            // pSeat
            // 
            this.pSeat.AutoSize = true;
            this.pSeat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSeat.ForeColor = System.Drawing.Color.White;
            this.pSeat.Location = new System.Drawing.Point(418, 179);
            this.pSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pSeat.Name = "pSeat";
            this.pSeat.Size = new System.Drawing.Size(22, 27);
            this.pSeat.TabIndex = 23;
            this.pSeat.Text = "?";
            // 
            // pTicketNumber
            // 
            this.pTicketNumber.AutoSize = true;
            this.pTicketNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTicketNumber.ForeColor = System.Drawing.Color.White;
            this.pTicketNumber.Location = new System.Drawing.Point(419, 142);
            this.pTicketNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pTicketNumber.Name = "pTicketNumber";
            this.pTicketNumber.Size = new System.Drawing.Size(22, 27);
            this.pTicketNumber.TabIndex = 22;
            this.pTicketNumber.Text = "?";
            // 
            // pDate
            // 
            this.pDate.AutoSize = true;
            this.pDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDate.ForeColor = System.Drawing.Color.White;
            this.pDate.Location = new System.Drawing.Point(418, 253);
            this.pDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pDate.Name = "pDate";
            this.pDate.Size = new System.Drawing.Size(22, 27);
            this.pDate.TabIndex = 21;
            this.pDate.Text = "?";
            // 
            // pTime
            // 
            this.pTime.AutoSize = true;
            this.pTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTime.ForeColor = System.Drawing.Color.White;
            this.pTime.Location = new System.Drawing.Point(418, 105);
            this.pTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pTime.Name = "pTime";
            this.pTime.Size = new System.Drawing.Size(22, 27);
            this.pTime.TabIndex = 20;
            this.pTime.Text = "?";
            // 
            // pTheatre
            // 
            this.pTheatre.AutoSize = true;
            this.pTheatre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTheatre.ForeColor = System.Drawing.Color.White;
            this.pTheatre.Location = new System.Drawing.Point(418, 68);
            this.pTheatre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pTheatre.Name = "pTheatre";
            this.pTheatre.Size = new System.Drawing.Size(22, 27);
            this.pTheatre.TabIndex = 19;
            this.pTheatre.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Theatre No:";
            // 
            // pMovie
            // 
            this.pMovie.AutoSize = true;
            this.pMovie.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMovie.ForeColor = System.Drawing.Color.White;
            this.pMovie.Location = new System.Drawing.Point(417, 23);
            this.pMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pMovie.Name = "pMovie";
            this.pMovie.Size = new System.Drawing.Size(30, 35);
            this.pMovie.TabIndex = 17;
            this.pMovie.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Name:-";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(-3, 363);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(136, 133);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 15;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 11);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(127, 38);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(796, 495);
            this.Controls.Add(this.barCodeBox);
            this.Controls.Add(this.qrCodeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pSeat);
            this.Controls.Add(this.pTicketNumber);
            this.Controls.Add(this.pDate);
            this.Controls.Add(this.pTime);
            this.Controls.Add(this.pTheatre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2PictureBox PrintBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox barCodeBox;
        private System.Windows.Forms.PictureBox qrCodeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pSeat;
        private System.Windows.Forms.Label pTicketNumber;
        private System.Windows.Forms.Label pDate;
        private System.Windows.Forms.Label pTime;
        private System.Windows.Forms.Label pTheatre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pMovie;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}