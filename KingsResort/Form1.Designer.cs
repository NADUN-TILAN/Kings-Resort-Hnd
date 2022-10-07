namespace KingsResort
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 26);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.roomDetailsToolStripMenuItem,
            this.reservationDetailsToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem,
            this.paymentTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // roomDetailsToolStripMenuItem
            // 
            this.roomDetailsToolStripMenuItem.Name = "roomDetailsToolStripMenuItem";
            this.roomDetailsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.roomDetailsToolStripMenuItem.Text = "Room Details";
            this.roomDetailsToolStripMenuItem.Click += new System.EventHandler(this.roomDetailsToolStripMenuItem_Click);
            // 
            // reservationDetailsToolStripMenuItem
            // 
            this.reservationDetailsToolStripMenuItem.Name = "reservationDetailsToolStripMenuItem";
            this.reservationDetailsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.reservationDetailsToolStripMenuItem.Text = "Reservation Details";
            this.reservationDetailsToolStripMenuItem.Click += new System.EventHandler(this.reservationDetailsToolStripMenuItem_Click);
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            this.paymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.paymentDetailsToolStripMenuItem_Click);
            // 
            // paymentTypeToolStripMenuItem
            // 
            this.paymentTypeToolStripMenuItem.Name = "paymentTypeToolStripMenuItem";
            this.paymentTypeToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.paymentTypeToolStripMenuItem.Text = "Payment Type";
            this.paymentTypeToolStripMenuItem.Click += new System.EventHandler(this.paymentTypeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 541);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kings Hotel & Resort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem paymentTypeToolStripMenuItem;
    }
}

