using System;
using System.Collections.Generic;
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
using System.ComponentModel;
using StudentRepository;


namespace WWPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            foreach (var item in MainGrid.Children)
            {
                
                if (item is TextBox)
                {
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
                }

                
            }

            MessageBox.Show("Здрасти " + s + "!!! \nТова е твоята първа програма на Visual Studio 2012!");
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            if (MessageBox.Show("Do you want to close?", "", MessageBoxButton.YesNo ) == MessageBoxResult.Yes)
                e.Cancel = false;
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            Student s = StudentData.TestStudents[0];

            nameTxt.Text = s.name;
            surnameTxt.Text = s.surname;
            lastnameTxt.Text = s.lastname;

            facultyTxt.Text = s.faculty;
            specialtyTxt.Text = s.specialty;
            oksTxt.Text = s.degree;
            statusTxt.Text = s.status;
            numberTxt.Text = s.number;

            kursTxt.Text = s.year.ToString();
            potokTxt.Text = s.potok.ToString();
            groupTxt.Text = s.group.ToString();

        }
    }
}
