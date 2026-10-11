namespace WaitresPOS1
{
    partial class MainForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblLegendBusy = new System.Windows.Forms.Label();
            this.lblLegendFree = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.headerPanel.Controls.Add(this.lblLegendBusy);
            this.headerPanel.Controls.Add(this.lblLegendFree);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblLegendBusy
            // 
            this.lblLegendBusy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLegendBusy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblLegendBusy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLegendBusy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblLegendBusy.Location = new System.Drawing.Point(760, 24);
            this.lblLegendBusy.Name = "lblLegendBusy";
            this.lblLegendBusy.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblLegendBusy.Size = new System.Drawing.Size(135, 30);
            this.lblLegendBusy.TabIndex = 3;
            this.lblLegendBusy.Text = "🟧 Заета с поръчка";
            this.lblLegendBusy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendFree
            // 
            this.lblLegendFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLegendFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.lblLegendFree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLegendFree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblLegendFree.Location = new System.Drawing.Point(625, 24);
            this.lblLegendFree.Name = "lblLegendFree";
            this.lblLegendFree.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblLegendFree.Size = new System.Drawing.Size(125, 30);
            this.lblLegendFree.TabIndex = 2;
            this.lblLegendFree.Text = "🟩 Свободна маса";
            this.lblLegendFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitle.Location = new System.Drawing.Point(24, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(425, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Изберете маса от залата, за да въведете или прегледате поръчка";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🍽️ WaiterPOS — ПЛАН НА ЗАЛАТА";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Controls.Add(this.lblStatusInfo);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 520);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(920, 50);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblStatusInfo
            // 
            this.lblStatusInfo.AutoSize = true;
            this.lblStatusInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblStatusInfo.Location = new System.Drawing.Point(23, 16);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(343, 19);
            this.lblStatusInfo.TabIndex = 0;
            this.lblStatusInfo.Text = "Общо маси: 6 | Заети: 0 | Общ оборот: 0.00 €";
            // 
            // btnTable1
            // 
            this.btnTable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable1.Location = new System.Drawing.Point(55, 120);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(230, 150);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "МАСА 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable2.Location = new System.Drawing.Point(345, 120);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(230, 150);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "МАСА 2";
            this.btnTable2.UseVisualStyleBackColor = true;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable3.Location = new System.Drawing.Point(635, 120);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(230, 150);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "МАСА 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable4.Location = new System.Drawing.Point(55, 320);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(230, 150);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "МАСА 4";
            this.btnTable4.UseVisualStyleBackColor = true;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable5.Location = new System.Drawing.Point(345, 320);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(230, 150);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "МАСА 5";
            this.btnTable5.UseVisualStyleBackColor = true;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTable6.Location = new System.Drawing.Point(635, 320);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(230, 150);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "МАСА 6";
            this.btnTable6.UseVisualStyleBackColor = true;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(920, 570);
            this.Controls.Add(this.btnTable6);
            this.Controls.Add(this.btnTable5);
            this.Controls.Add(this.btnTable4);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaiterPOS - Ресторантски Терминал (План на залата)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblLegendBusy;
        private System.Windows.Forms.Label lblLegendFree;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable6;
    }
}
