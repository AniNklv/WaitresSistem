using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WaitresPOS1
{
    /// <summary>
    /// Прозорец (екран) за визуализиране на кухненския бон за готвачите.
    /// Позволява преглед на поръчката и бързо отваряне на генерирания файл.
    /// </summary>
    public class KitchenTicketForm : Form
    {
        private TextBox txtReceipt;
        private Label lblFilePath;
        private Button btnOpenFolder;
        private Button btnClose;
        private readonly string savedFilePath;

        public KitchenTicketForm(string receiptText, string filePath)
        {
            this.savedFilePath = filePath;
            InitializeComponent();
            txtReceipt.Text = receiptText;
            lblFilePath.Text = $"Записан файл: {Path.GetFileName(filePath)}";
        }

        private void InitializeComponent()
        {
            this.Text = "Кухненски бон (Екран за кухня)";
            this.Size = new Size(540, 620);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

            // Заглавен панел
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = Color.FromArgb(30, 41, 59)
            };

            Label lblTitle = new Label
            {
                Text = "🍳 КУХНЕНСКИ БОН - ПОРЪЧКА",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(16, 12)
            };

            Label lblSubtitle = new Label
            {
                Text = "Поръчката е предадена към готвачите и запазена във файл",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(203, 213, 225),
                AutoSize = true,
                Location = new Point(18, 38)
            };

            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // Текстово поле за бона (тип касова бележка)
            txtReceipt = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 10.5f, FontStyle.Regular),
                BackColor = Color.FromArgb(254, 252, 232), // Приятен цвят на хартия / бон
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(16, 75),
                Size = new Size(492, 425)
            };

            // Долен панел за действия
            Panel bottomPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 70,
                BackColor = Color.White
            };

            lblFilePath = new Label
            {
                Location = new Point(16, 12),
                Size = new Size(320, 20),
                ForeColor = Color.FromArgb(71, 85, 105),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Italic)
            };

            btnOpenFolder = new Button
            {
                Text = "📄 Отвори файла",
                Location = new Point(230, 16),
                Size = new Size(135, 38),
                BackColor = Color.FromArgb(226, 232, 240),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnOpenFolder.FlatAppearance.BorderSize = 0;
            btnOpenFolder.Click += BtnOpenFolder_Click;

            btnClose = new Button
            {
                Text = "✔ Разбрано (Затвори)",
                Location = new Point(375, 16),
                Size = new Size(135, 38),
                BackColor = Color.FromArgb(16, 185, 129), // Зелен бутон
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();

            bottomPanel.Controls.Add(lblFilePath);
            bottomPanel.Controls.Add(btnOpenFolder);
            bottomPanel.Controls.Add(btnClose);

            this.Controls.Add(txtReceipt);
            this.Controls.Add(headerPanel);
            this.Controls.Add(bottomPanel);
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savedFilePath) && File.Exists(savedFilePath))
            {
                try
                {
                    // Отваряме файла директно в Notepad за преглед
                    Process.Start("notepad.exe", savedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неуспешно отваряне на файла: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
