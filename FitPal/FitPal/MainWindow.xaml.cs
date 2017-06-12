using FitPal.Data;
using FitPal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<FitnessEntry> entries = new ObservableCollection<FitnessEntry>(FitnessRepository.GetUserEntries("Gosho"));

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.CanMinimize;

            logsTable.ItemsSource = entries;

            weightSlider.Value = 75;
            logDate.SelectedDate = DateTime.Now;
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            settingsTab.Focus();
        }

        private void logNewbutton_Click(object sender, RoutedEventArgs e)
        {
            logNewTab.Focus();
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {
            double weight = 0;
            bool isWParsed = double.TryParse(weightBox.Text, out weight);
            if (isWParsed)
            {
                if (logDate.SelectedDate.HasValue)
                {
                    var date = logDate.SelectedDate.Value;

                    FitnessEntry newEntry = new FitnessEntry() { Username = "Gosho", LogDate = date, Weight = weight };

                    entries.Add(newEntry);
                }
            }
        }
    }
}