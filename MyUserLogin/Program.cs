using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordInput = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(usernameInput, passwordInput, errorLog);
            
            User mainUser = new User();
            if (loginValidation.ValidateUserInput(ref mainUser))
            {
                Console.WriteLine(mainUser.username + " " + mainUser.password + " " + mainUser.number + " " + LoginValidation.CurrentUserRole);
                if (mainUser.role == UserRoles.ADMIN)
                    adminMenu();
            }
        }

        static public void errorLog(string errorMsg)
        {
            Console.WriteLine("!!! " + errorMsg + " !!!");
        }

        static public void adminMenu()
        {
            int choice;

            Dictionary<string, int> allUsers = UserData.AllUsersUsernames();

            do
            {
                //Console.Clear();

                Console.WriteLine("Admin Menu:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Change user activity");
                Console.WriteLine("2. Change user role");
                Console.WriteLine("3. Show list of users");
                Console.WriteLine("4. Show log file");
                Console.WriteLine("5. Show current session activities");

                do
                {
                    Console.Write("Choose option: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice < 0 || choice > 5);

                

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Enter username: ");
                        string usernameChangeActive = Console.ReadLine();
                        Console.Write("Enter date[MM/DD/YYYY or YYYY/MM/DD]: ");
                        string dateString = Console.ReadLine();
                        DateTime dateChangeActive = DateTime.Parse(dateString);

                        

                        UserData.setUserActiveTo(allUsers[usernameChangeActive], dateChangeActive);
                        break;
                    case 2:
                        Console.Write("Enter username: ");
                        string usernameChangeRole = Console.ReadLine();

                        int newRoleChoice;
                        UserRoles newRole = UserRoles.ANONYMOUS;

                        Console.WriteLine("1. Admin");
                        Console.WriteLine("2. Inspector");
                        Console.WriteLine("3. Professor");
                        Console.WriteLine("4. Student");

                        do
                        {
                            Console.Write("Choose new role: ");
                            newRoleChoice = Convert.ToInt32(Console.ReadLine());
                        } while (newRoleChoice < 1 || newRoleChoice > 4);

                        switch (newRoleChoice)
                        {
                            case 1:
                                newRole = UserRoles.ADMIN;
                                break;
                            case 2:
                                newRole = UserRoles.INSPECTOR;
                                break;
                            case 3:
                                newRole = UserRoles.PROFESSOR;
                                break;
                            case 4:
                                newRole = UserRoles.STUDENT;
                                break;
                            default:
                                newRole = UserRoles.ANONYMOUS;
                                break;
                        }
                        UserData.assignUserRole(allUsers[usernameChangeRole], newRole);

                        break;
                    case 3:
                        
                        foreach (KeyValuePair<string, int> user in allUsers)
                        {
                            Console.WriteLine(user.Key);
                        }
                        break;
                    case 4:
                        Logger.showLogFile();
                        break;
                    case 5:
                        Console.Write("Enter filter: ");
                        string filter = Console.ReadLine();
                        string activities = Logger.GetCurrentSessionActivities(filter);
                        Console.WriteLine(activities);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
    }
}
