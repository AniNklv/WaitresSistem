using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WaitresPOS1
{
    /// <summary>
    /// Модел за ястие/напитка от предварително зададеното меню на ресторанта.
    /// </summary>
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public MenuItem(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Текст за показване върху бутона в менюто
        public string DisplayText => $"{Name}\n{Price:F2} €";
    }

    /// <summary>
    /// Модел за избран артикул в поръчката на конкретна маса.
    /// Включва име, единична цена, количество и специална забележка/модификатор за кухнята.
    /// </summary>
    public class OrderItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }

        public OrderItem(string name, decimal price, int quantity = 1, string note = "")
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Note = note ?? "";
        }

        // Обща сума за този ред = единична цена * количество
        public decimal TotalPrice => Price * Quantity;
    }

    /// <summary>
    /// Централизиран клас (състояние на ресторанта) за съхранение на поръчките по маси и менюто.
    /// Позволява данните за всяка маса да се пазят, когато сервитьорът се връща в залата.
    /// </summary>
    public static class RestaurantState
    {
        // Речник (Dictionary), където ключът е името на масата ("Маса 1"),
        // а стойността е списъкът с поръчаните артикули за тази маса.
        public static Dictionary<string, List<OrderItem>> TableOrders { get; private set; }

        // Пълно меню с категории: Предястия, Основни, Напитки, Десерти
        public static List<MenuItem> MenuItems { get; private set; }

        static RestaurantState()
        {
            TableOrders = new Dictionary<string, List<OrderItem>>();
            for (int i = 1; i <= 6; i++)
            {
                TableOrders[$"Маса {i}"] = new List<OrderItem>();
            }

            InitMenu();
        }

        /// <summary>
        /// Връща списъка с артикули за дадена маса.
        /// </summary>
        public static List<OrderItem> GetOrder(string tableName)
        {
            if (!TableOrders.ContainsKey(tableName))
            {
                TableOrders[tableName] = new List<OrderItem>();
            }
            return TableOrders[tableName];
        }

        /// <summary>
        /// Проверява дали масата има активни поръчки.
        /// </summary>
        public static bool HasActiveOrder(string tableName)
        {
            return TableOrders.ContainsKey(tableName) && TableOrders[tableName].Count > 0;
        }

        /// <summary>
        /// Изчислява общата стойност на поръчката за дадена маса.
        /// </summary>
        public static decimal GetTableTotal(string tableName)
        {
            var order = GetOrder(tableName);
            return order.Sum(item => item.TotalPrice);
        }

        /// <summary>
        /// Изчиства поръчката за дадена маса (при приключване на сметката).
        /// </summary>
        public static void ClearOrder(string tableName)
        {
            if (TableOrders.ContainsKey(tableName))
            {
                TableOrders[tableName].Clear();
            }
        }

        /// <summary>
        /// Инициализира примерно ресторантско меню с ястия по категории (цени в евро).
        /// </summary>
        private static void InitMenu()
        {
            MenuItems = new List<MenuItem>
            {
                // Предястия
                new MenuItem("Шопска салата", 4.50m, "Предястия"),
                new MenuItem("Овчарска салата", 5.20m, "Предястия"),
                new MenuItem("Гръцка салата", 4.80m, "Предястия"),
                new MenuItem("Пържени картофи", 2.80m, "Предястия"),
                new MenuItem("Картофи със сирене", 3.50m, "Предястия"),
                new MenuItem("Пилешки хапки", 4.60m, "Предястия"),

                // Основни ястия
                new MenuItem("Свинска пържола", 7.50m, "Основни"),
                new MenuItem("Пилешко филе", 6.80m, "Основни"),
                new MenuItem("Телешки кюфтета (3 бр.)", 6.00m, "Основни"),
                new MenuItem("Спагети Карбонара", 6.50m, "Основни"),
                new MenuItem("Пица Маргарита", 5.50m, "Основни"),
                new MenuItem("Сьомга на тиган", 10.50m, "Основни"),

                // Напитки
                new MenuItem("Минерална вода 500ml", 1.20m, "Напитки"),
                new MenuItem("Кока-Кола 330ml", 1.60m, "Напитки"),
                new MenuItem("Натурален сок", 1.70m, "Напитки"),
                new MenuItem("Кафе Еспресо", 1.30m, "Напитки"),
                new MenuItem("Наливна бира 500ml", 2.20m, "Напитки"),
                new MenuItem("Чаша вино (бяло/червено)", 2.90m, "Напитки"),

                // Десерти
                new MenuItem("Палачинка с шоколад", 2.80m, "Десерти"),
                new MenuItem("Шоколадово суфле", 3.60m, "Десерти"),
                new MenuItem("Чийзкейк боровинка", 3.40m, "Десерти"),
                new MenuItem("Сладолед асорти", 2.40m, "Десерти"),
                new MenuItem("Тирамису", 3.20m, "Десерти"),
                new MenuItem("Крем Карамел", 2.50m, "Десерти")
            };
        }

        /// <summary>
        /// Генерира текст за кухненски бон и го записва във текстов файл.
        /// Връща пътя до записания файл и генерирания текст на бона.
        /// </summary>
        public static (string FilePath, string ReceiptText) GenerateAndSaveKitchenTicket(string tableName)
        {
            var order = GetOrder(tableName);
            if (order.Count == 0)
            {
                return (null, null);
            }

            DateTime now = DateTime.Now;
            string dateStr = now.ToString("dd.MM.yyyy HH:mm:ss");
            string fileDateStr = now.ToString("yyyyMMdd_HHmmss");

            // Създаваме папка "Кухненски_Бони" в директорията на приложението
            string dir;
            try
            {
                dir = Path.Combine(System.Windows.Forms.Application.StartupPath, "Кухненски_Бони");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            catch
            {
                // Резервен вариант в папка Документи, ако няма права за запис
                dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Кухненски_Бони");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }

            string cleanTableName = tableName.Replace(" ", "_");
            string fileName = $"Бон_{cleanTableName}_{fileDateStr}.txt";
            string filePath = Path.Combine(dir, fileName);

            // Оформяне на кухненския бон
            StringWriter sw = new StringWriter();
            sw.WriteLine("==========================================================");
            sw.WriteLine("               КУХНЕНСКИ БОН (ПОРЪЧКА)                    ");
            sw.WriteLine("==========================================================");
            sw.WriteLine($" МАСА:       {tableName}");
            sw.WriteLine($" ДАТА/ЧАС:   {dateStr}");
            sw.WriteLine($" СТАТУС:     ИЗПРАТЕНО КЪМ КУХНЯ");
            sw.WriteLine("----------------------------------------------------------");
            sw.WriteLine(string.Format("{0,-25} {1,5}   {2}", "АРТИКУЛ", "КОЛ.", "ЗАБЕЛЕЖКА / МОДИФИКАТОР"));
            sw.WriteLine("----------------------------------------------------------");

            int totalItems = 0;
            decimal totalSum = 0m;

            for (int i = 0; i < order.Count; i++)
            {
                var item = order[i];
                totalItems += item.Quantity;
                totalSum += item.TotalPrice;

                string noteDisplay = string.IsNullOrWhiteSpace(item.Note) ? "-" : $"[{item.Note}]";
                sw.WriteLine(string.Format("{0,-25} {1,5}   {2}", item.Name, item.Quantity, noteDisplay));
            }

            sw.WriteLine("----------------------------------------------------------");
            sw.WriteLine($" ОБЩ БРОЙ АРТИКУЛИ: {totalItems}");
            sw.WriteLine($" ОБЩА СТОЙНОСТ:     {totalSum:F2} €");
            sw.WriteLine("==========================================================");
            sw.WriteLine("         МОЛЯ, ПРИГОТВЕТЕ ПОРЪЧКАТА С ПРИОРИТЕТ!          ");
            sw.WriteLine("==========================================================");

            string receiptText = sw.ToString();

            // Запис във файл
            File.WriteAllText(filePath, receiptText, System.Text.Encoding.UTF8);

            return (filePath, receiptText);
        }
    }
}
