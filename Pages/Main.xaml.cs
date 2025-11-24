using System.Collections.Generic;
using System.Windows.Controls;
using FurnitureStore_Osennikov.Classes;

namespace FurnitureStore_Osennikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();
        public Main()
        {
            InitializeComponent();
            items.Add(new Item("Шкаф", 20000, "Scaf.jpg"));
        }
    }
}
