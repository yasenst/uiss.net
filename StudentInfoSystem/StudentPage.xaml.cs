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
using StudentRepository;
using MyUserLogin;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        public StudentPage()
        {
            InitializeComponent();
            
        }

        public StudentPage(object data)
        : this()
        {

            FillStudent(data);
            FillStudStatusChoices();
            this.DataContext = this;
        }

        public Student CurrentStudent { get; set; }
        public List<string> StudStatusChoices { get; set; }

        private bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();

            if (countStudents == 0)
                return true;
            return false;
        }

        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
        }

        private bool TestUsersIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<User> queryUsers = context.Users;
            int countUsers = queryUsers.Count();

            if (countUsers == 0)
                return true;
            return false;
        }

        private void CopyTestUsers()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (User st in UserData.TestUsers)
            {
                context.Users.Add(st);
            }
            context.SaveChanges();
        }

        private void FillStudent(object data)
        {
            CurrentStudent = new Student();
            CurrentStudent = StudentData.getStudentByFacultyNumber(int.Parse(data.ToString()));
        }
        
        
        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr
                FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            foreach (var item in StudentInfoGrid2.Children)
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
            //statusTxt.Text = s.status;
            //numberTxt.SetValue(s.number);

            courseTxt.Text = s.year.ToString();
            potokTxt.Text = s.potok.ToString();
            groupTxt.Text = s.group.ToString();

        }

        private void disableButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = !((TextBox)item).IsEnabled;
                }
            }
            foreach (var item in StudentInfoGrid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = !((TextBox)item).IsEnabled;
                }
            }

            clearBtn.IsEnabled = !clearBtn.IsEnabled;
            fillButton.IsEnabled = !fillButton.IsEnabled;
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

        private void testBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TestStudentsIfEmpty())
                CopyTestStudents();

            if (TestUsersIfEmpty())
                CopyTestUsers();
        }
    }
}
