using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace tbWPFPrototype
{
    public partial class MainWindow : Window
    {
        static Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
            dpRegDate.SelectedDate = DateTime.Now;
            cbBrands.ItemsSource = File.ReadAllLines(@"..\..\brands.txt");

            for (int i = DateTime.Now.Year + 1; i >= 1950; i--)
            {
                cbYear.Items.Add(i);
            }
            
        }

        private void btnAddNewCar_Click(object sender, RoutedEventArgs e)
        {
            string license = txtLicensePlate.Text;
            bool add_car = true;
            if (license.CompareTo("") != 0 && license.Length > 1 && license.Length < 8)
            {
                foreach (Car c in lvCars.Items)
                {
                    if (c.License_Plate.CompareTo(license) == 0)
                    {
                        add_car = false;
                        MessageBox.Show($"Registreringsnummer finns redan i systemet");
                        break;
                    }
                }

                if (add_car)
                {
                    lvCars.Items.Add(new Car(license, cbBrands.Text, txtModel.Text, int.Parse(cbYear.Text), txtColour.Text, cbFuel.Text, dpRegDate.SelectedDate));
                    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvCars.Items);
                    view.SortDescriptions.Add(new SortDescription("License_Plate", ListSortDirection.Ascending));
                }
            }
            else
            {
                MessageBox.Show($"Felaktigt registreringsnummer");
            }
           
        }

        private void RemoveCar()
        {
            for (int i = 0; i < lvCars.SelectedItems.Count; i++)
            {
                if (lvCars.SelectedIndex >= 0 && MessageBox.Show($"Ta bort bil med regnr {((Car)lvCars.SelectedItems[i]).License_Plate}? ", "Ta bort bil?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    lvCars.Items.RemoveAt(lvCars.Items.IndexOf(lvCars.SelectedItems[i]));
                    i--;
                }
            }            
        }

        private void btnRemoveCar_Click(object sender, RoutedEventArgs e)
        {
            //RemoveCar();
            Window2 subWindow = new Window2();
            subWindow.Show();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                RemoveCar();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
