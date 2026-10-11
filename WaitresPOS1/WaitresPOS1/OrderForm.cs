using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WaitresPOS1
{
    public partial class OrderForm : Form
    {
        private readonly string currentTableName;
        private List<OrderItem> currentOrder;
        private string activeCategory = "Предястия";

        public OrderForm(string tableName)
        {
            InitializeComponent();
            currentTableName = tableName;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Задаваме заглавия
            lblTableName.Text = $"🍽️ {currentTableName.ToUpper()} — ПОРЪЧКА";
            this.Text = $"WaiterPOS - {currentTableName}";

            // Вземаме активната поръчка за тази маса от глобалното състояние
            currentOrder = RestaurantState.GetOrder(currentTableName);

            // Зареждаме началната категория и показваме текущите артикули в таблицата
            SelectCategory("Предястия");
            RefreshOrderGrid();
        }

        #region Категории и Меню

        private void btnCategoryStarters_Click(object sender, EventArgs e) => SelectCategory("Предястия");
        private void btnCategoryMains_Click(object sender, EventArgs e) => SelectCategory("Основни");
        private void btnCategoryDrinks_Click(object sender, EventArgs e) => SelectCategory("Напитки");
        private void btnCategoryDesserts_Click(object sender, EventArgs e) => SelectCategory("Десерти");

        /// <summary>
        /// Превключва избраната категория в менюто и генерира бутони за ястията в нея.
        /// </summary>
        private void SelectCategory(string category)
        {
            activeCategory = category;

            // Визуално маркиране на активния бутон за категория
            HighlightCategoryButton(btnCategoryStarters, category == "Предястия");
            HighlightCategoryButton(btnCategoryMains, category == "Основни");
            HighlightCategoryButton(btnCategoryDrinks, category == "Напитки");
            HighlightCategoryButton(btnCategoryDesserts, category == "Десерти");

            // Зареждане на ястията за тази категория в панела
            LoadCategoryDishes(category);
        }

        private void HighlightCategoryButton(Button btn, bool isActive)
        {
            if (isActive)
            {
                btn.BackColor = Color.FromArgb(37, 99, 235); // Активен син цвят
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(51, 65, 85);
                btn.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                btn.FlatAppearance.BorderSize = 1;
            }
        }

        /// <summary>
        /// Динамично създава удобни бутони за всяко ястие от избраната категория.
        /// При клик върху ястието, то автоматично се добавя в поръчката.
        /// </summary>
        private void LoadCategoryDishes(string category)
        {
            pnlDishes.SuspendLayout();
            pnlDishes.Controls.Clear();

            var dishes = RestaurantState.MenuItems.Where(m => m.Category == category).ToList();

            foreach (var dish in dishes)
            {
                Button btn = new Button
                {
                    Text = dish.DisplayText,
                    Size = new Size(168, 65),
                    Margin = new Padding(4),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = dish
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
                btn.FlatAppearance.BorderSize = 1;

                // Събитие при натискане на ястие: добавяне в сметката
                btn.Click += DishButton_Click;

                pnlDishes.Controls.Add(btn);
            }

            pnlDishes.ResumeLayout();
        }

        /// <summary>
        /// Обработчик при натискане на ястие от менюто.
        /// Добавя артикула в списъка или увеличава количеството му с 1.
        /// </summary>
        private void DishButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MenuItem dish)
            {
                // Проверяваме дали вече има такъв артикул без специфична бележка
                var existingItem = currentOrder.FirstOrDefault(i => i.Name == dish.Name && string.IsNullOrEmpty(i.Note));

                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    currentOrder.Add(new OrderItem(dish.Name, dish.Price, 1, ""));
                }

                RefreshOrderGrid();
                SelectOrderItemRow(existingItem?.Name ?? dish.Name);
            }
        }

        #endregion

        #region Управление на поръчката и таблицата (DataGridView)

        /// <summary>
        /// Презарежда таблицата с поръчаните артикули и обновява общата сума.
        /// </summary>
        private void RefreshOrderGrid()
        {
            int selectedIndex = dgvOrder.SelectedRows.Count > 0 ? dgvOrder.SelectedRows[0].Index : -1;

            dgvOrder.Rows.Clear();

            foreach (var item in currentOrder)
            {
                int rowIndex = dgvOrder.Rows.Add(
                    item.Name,
                    $"{item.Price:F2} €",
                    item.Quantity,
                    $"{item.TotalPrice:F2} €",
                    item.Note
                );
            }

            // Възстановяваме селекцията, ако е валидна
            if (selectedIndex >= 0 && selectedIndex < dgvOrder.Rows.Count)
            {
                dgvOrder.Rows[selectedIndex].Selected = true;
            }
            else if (dgvOrder.Rows.Count > 0)
            {
                dgvOrder.Rows[dgvOrder.Rows.Count - 1].Selected = true;
            }

            // Обновяваме полето с общата сума
            decimal total = RestaurantState.GetTableTotal(currentTableName);
            lblTotalAmount.Text = $"ОБЩО: {total:F2} €";
        }

        private OrderItem GetSelectedOrderItem()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int index = dgvOrder.SelectedRows[0].Index;
                if (index >= 0 && index < currentOrder.Count)
                {
                    return currentOrder[index];
                }
            }
            return null;
        }

        private void SelectOrderItemRow(string itemName)
        {
            for (int i = 0; i < currentOrder.Count; i++)
            {
                if (currentOrder[i].Name == itemName)
                {
                    if (i < dgvOrder.Rows.Count)
                    {
                        dgvOrder.ClearSelection();
                        dgvOrder.Rows[i].Selected = true;
                    }
                    break;
                }
            }
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            var selected = GetSelectedOrderItem();
            if (selected != null)
            {
                txtNote.Text = selected.Note;
            }
            else
            {
                txtNote.Text = "";
            }
        }

        #endregion

        #region Управление на количеството (+ / - / Изтриване)

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedOrderItem();
            if (selected == null)
            {
                MessageBox.Show("Моля, изберете артикул от списъка за промяна на количеството.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selected.Quantity++;
            RefreshOrderGrid();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedOrderItem();
            if (selected == null)
            {
                MessageBox.Show("Моля, изберете артикул от списъка за промяна на количеството.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selected.Quantity > 1)
            {
                selected.Quantity--;
            }
            else
            {
                // При достигане на 0 премахваме артикула
                currentOrder.Remove(selected);
            }

            RefreshOrderGrid();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedOrderItem();
            if (selected == null)
            {
                MessageBox.Show("Моля, изберете артикул от списъка за изтриване.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentOrder.Remove(selected);
            RefreshOrderGrid();
        }

        #endregion

        #region Модификатори и Забележки към кухнята

        /// <summary>
        /// Бързи бутони за най-често използваните модификатори ("без лук", "без сол" и др.).
        /// При кликване добавят текста в полето за забележка.
        /// </summary>
        private void QuickModifier_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string modText = btn.Text;
                if (string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    txtNote.Text = modText;
                }
                else if (!txtNote.Text.Contains(modText))
                {
                    txtNote.Text += $", {modText}";
                }
            }
        }

        /// <summary>
        /// Записва въведената забележка/модификатор към избрания артикул в поръчката.
        /// </summary>
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedOrderItem();
            if (selected == null)
            {
                MessageBox.Show("Моля, първо маркирайте ястие от списъка, за което се отнася забележката.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selected.Note = txtNote.Text.Trim();
            RefreshOrderGrid();
            MessageBox.Show($"Забележката за '{selected.Name}' е добавена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Стока / Артикул извън менюто

        private void txtCustomName_Enter(object sender, EventArgs e)
        {
            if (txtCustomName.Text == "Име на артикул...")
            {
                txtCustomName.Text = "";
                txtCustomName.ForeColor = Color.Black;
            }
        }

        private void txtCustomName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomName.Text))
            {
                txtCustomName.Text = "Име на артикул...";
                txtCustomName.ForeColor = Color.Gray;
            }
        }

        private void txtCustomPrice_Enter(object sender, EventArgs e)
        {
            if (txtCustomPrice.Text == "Цена (€)")
            {
                txtCustomPrice.Text = "";
                txtCustomPrice.ForeColor = Color.Black;
            }
        }

        private void txtCustomPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomPrice.Text))
            {
                txtCustomPrice.Text = "Цена (€)";
                txtCustomPrice.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Добавя нестандартна поръчка/артикул извън менюто с ръчно зададени име и цена.
        /// </summary>
        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            string name = txtCustomName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || name == "Име на артикул...")
            {
                MessageBox.Show("Моля, въведете име на нестандартния артикул.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomName.Focus();
                return;
            }

            string priceText = txtCustomPrice.Text.Replace(",", ".").Trim();
            if (!decimal.TryParse(priceText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal price) || price <= 0)
            {
                MessageBox.Show("Моля, въведете коректна положителна цена (напр. 2.50).", "Невалидна цена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomPrice.Focus();
                return;
            }

            // Добавяме нестандартния артикул в поръчката
            currentOrder.Add(new OrderItem(name, price, 1, ""));
            RefreshOrderGrid();

            // Изчистваме полетата за въвеждане
            txtCustomName.Text = "Име на артикул...";
            txtCustomName.ForeColor = Color.Gray;
            txtCustomPrice.Text = "Цена (€)";
            txtCustomPrice.ForeColor = Color.Gray;

            SelectOrderItemRow(name);
        }

        #endregion

        #region Изпращане към кухня и Освобождаване на маса

        /// <summary>
        /// Генерира кухненски бон, записва го като текстов файл и го визуализира на екран.
        /// </summary>
        private void btnSendToKitchen_Click(object sender, EventArgs e)
        {
            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Няма добавени ястия в поръчката за изпращане към кухнята!", "Празна поръчка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Генерираме бона и записваме във файл
            var result = RestaurantState.GenerateAndSaveKitchenTicket(currentTableName);

            if (result.FilePath != null)
            {
                // Показваме екрана с бона
                KitchenTicketForm ticketForm = new KitchenTicketForm(result.ReceiptText, result.FilePath);
                ticketForm.ShowDialog(this);
            }
        }

        /// <summary>
        /// Изчиства цялата сметка за масата (при плащане / освобождаване).
        /// </summary>
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Масата вече е празна (няма активни артикули).", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"Сигурни ли сте, че искате да изчистите сметката и да освободите {currentTableName}?",
                "Потвърждение за освобождаване",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                RestaurantState.ClearOrder(currentTableName);
                RefreshOrderGrid();
                MessageBox.Show($"{currentTableName} е освободена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
