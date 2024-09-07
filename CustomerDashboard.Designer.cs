namespace ABC_Car_Traders
{
    partial class CustomerDashboard
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
            this.CustomerDashboardPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.GreetingLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.OrderPageBtn = new System.Windows.Forms.Button();
            this.CustomerDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerDashboardPanel
            // 
            this.CustomerDashboardPanel.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.CustNav;
            this.CustomerDashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerDashboardPanel.Controls.Add(this.LogOutBtn);
            this.CustomerDashboardPanel.Controls.Add(this.GreetingLbl);
            this.CustomerDashboardPanel.Controls.Add(this.label1);
            this.CustomerDashboardPanel.Controls.Add(this.label2);
            this.CustomerDashboardPanel.Controls.Add(this.label3);
            this.CustomerDashboardPanel.Controls.Add(this.ReportsBtn);
            this.CustomerDashboardPanel.Controls.Add(this.OrderPageBtn);
            this.CustomerDashboardPanel.Location = new System.Drawing.Point(-1, -1);
            this.CustomerDashboardPanel.Name = "CustomerDashboardPanel";
            this.CustomerDashboardPanel.Size = new System.Drawing.Size(219, 661);
            this.CustomerDashboardPanel.TabIndex = 1;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 309);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(218, 32);
            this.LogOutBtn.TabIndex = 12;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // GreetingLbl
            // 
            this.GreetingLbl.AutoSize = true;
            this.GreetingLbl.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLbl.ForeColor = System.Drawing.Color.White;
            this.GreetingLbl.Location = new System.Drawing.Point(3, 47);
            this.GreetingLbl.Name = "GreetingLbl";
            this.GreetingLbl.Size = new System.Drawing.Size(57, 20);
            this.GreetingLbl.TabIndex = 10;
            this.GreetingLbl.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ABC CAR TRADERS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "_________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(2, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "_________________";
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtn.Location = new System.Drawing.Point(0, 175);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(218, 32);
            this.ReportsBtn.TabIndex = 1;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // OrderPageBtn
            // 
            this.OrderPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrderPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPageBtn.Location = new System.Drawing.Point(0, 115);
            this.OrderPageBtn.Name = "OrderPageBtn";
            this.OrderPageBtn.Size = new System.Drawing.Size(218, 32);
            this.OrderPageBtn.TabIndex = 0;
            this.OrderPageBtn.Text = "Order Cars / Car Parts";
            this.OrderPageBtn.UseVisualStyleBackColor = false;
            this.OrderPageBtn.Click += new System.EventHandler(this.OrderPageBtn_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(865, 659);
            this.Controls.Add(this.CustomerDashboardPanel);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.CustomerDashboardPanel.ResumeLayout(false);
            this.CustomerDashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomerDashboardPanel;
        private System.Windows.Forms.Button OrderPageBtn;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Label GreetingLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogOutBtn;
    }
}