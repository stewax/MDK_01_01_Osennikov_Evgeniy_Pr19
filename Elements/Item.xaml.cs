using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace FurnitureStore_Osennikov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null )
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/Image/Items" + item.src))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Image/Items" + item.src));
                else
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Image/Items/placeholder.png"));

                price.Content = item.price;
                name.Content = item.name;
            }
        }
    }
}
