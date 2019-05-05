using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page, INotifyPropertyChanged
    {
        public ObservableCollection<string> PersonsChecked
        { get; set; }

        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;
                // Извикване на PropertyChanged
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
            }
        }

        public ExpenseItHome()
        {
            InitializeComponent();

            LastChecked = DateTime.Now;

            this.DataContext = this;

            PersonsChecked = new ObservableCollection<string>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            //this.NavigationService.Navigate(expenseReportPage);
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value);
        }
    }


}
