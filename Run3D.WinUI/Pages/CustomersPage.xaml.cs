using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Run3D.WinUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            this.InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "Olivia Smith", Email = "olivia.smith@example.com", Phone = "123-456-7890" },
                new Customer { CustomerID = 2, Name = "Izabella Wilson", Email = "izabella.wilson@example.com", Phone = "987-654-3210" },
                new Customer { CustomerID = 3, Name = "Olivia Smith", Email = "olivia.smith@example.com", Phone = "123-456-7890" },
                new Customer { CustomerID = 4, Name = "Izabella Wilson", Email = "izabella.wilson@example.com", Phone = "987-654-3210" },
                new Customer { CustomerID = 5, Name = "Olivia Smith", Email = "olivia.smith@example.com", Phone = "123-456-7890" },
                new Customer { CustomerID = 6, Name = "Izabella Wilson", Email = "izabella.wilson@example.com", Phone = "987-654-3210" }
            };

            CustomersDataGrid.ItemsSource = customers;
        }

        private void OnBackToMainPageClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
