using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WaitresPOS1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // При първоначално зареждане на формата обновяваме визуалното състояние на масите
            UpdateTableButtons();
        }

        /// <summary>
        /// Отваря екрана за въвеждане на поръчка за избраната маса.
        /// Скрива главния екран и след приключване/връщане обновява статусите на масите.
        /// </summary>
        /// <param name="tableName">Име на масата (напр. "Маса 1")</param>
        private void OpenOrderForm(string tableName)
        {
            OrderForm orderForm = new OrderForm(tableName);
            this.Hide();
            orderForm.ShowDialog();
            this.Show(); // При затваряне на екрана за поръчка се връщаме в залата
            UpdateTableButtons(); // Обновяваме статусите и цветовете на масите
        }

        /// <summary>
        /// Обхожда всички маси и визуализира дали са свободни или заети с активна поръчка.
        /// Заетите маси се оцветяват в топъл цвят и показват броя артикули и текущата сметка.
        /// </summary>
        private void UpdateTableButtons()
        {
            Button[] tableButtons = new Button[] { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6 };

            int busyCount = 0;
            decimal totalTurnover = 0m;

            for (int i = 0; i < tableButtons.Length; i++)
            {
                string tableName = $"Маса {i + 1}";
                Button btn = tableButtons[i];

                var order = RestaurantState.GetOrder(tableName);
                bool isBusy = order.Count > 0;

                if (isBusy)
                {
                    busyCount++;
                    int totalItems = order.Sum(item => item.Quantity);
                    decimal totalSum = order.Sum(item => item.TotalPrice);
                    totalTurnover += totalSum;

                    // Оформяне за заета маса (топъл кехлибарен цвят)
                    btn.Text = $"🍽️ {tableName.ToUpper()}\n[ ЗАЕТА ]\n{totalItems} бр. | {totalSum:F2} €";
                    btn.BackColor = Color.FromArgb(254, 243, 199);
                    btn.ForeColor = Color.FromArgb(146, 64, 14);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(245, 158, 11);
                    btn.FlatAppearance.BorderSize = 2;
                }
                else
                {
                    // Оформяне за свободна маса (свеж зелен цвят)
                    btn.Text = $"🍽️ {tableName.ToUpper()}\n\n[ СВОБОДНА ]";
                    btn.BackColor = Color.FromArgb(236, 253, 245);
                    btn.ForeColor = Color.FromArgb(6, 95, 70);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(16, 185, 129);
                    btn.FlatAppearance.BorderSize = 2;
                }
            }

            // Обновяване на долната лента със статистика за залата
            lblStatusInfo.Text = $"Общо маси: 6 | Заети маси: {busyCount} | Общ оборот в залата: {totalTurnover:F2} €";
        }

        // Събития при кликване върху всяка маса
        private void btnTable1_Click(object sender, EventArgs e) => OpenOrderForm("Маса 1");
        private void btnTable2_Click(object sender, EventArgs e) => OpenOrderForm("Маса 2");
        private void btnTable3_Click(object sender, EventArgs e) => OpenOrderForm("Маса 3");
        private void btnTable4_Click(object sender, EventArgs e) => OpenOrderForm("Маса 4");
        private void btnTable5_Click(object sender, EventArgs e) => OpenOrderForm("Маса 5");
        private void btnTable6_Click(object sender, EventArgs e) => OpenOrderForm("Маса 6");
    }
}
