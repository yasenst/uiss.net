using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers = new List<User>();
        

        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static private void ResetTestUserData()
        {
            //_testUsers = new User[3];
            User u1 = new User();
            u1.username = "Yasen1";
            u1.password = "123456";
            u1.number = "81";
            u1.role = UserRoles.ADMIN;
            u1.dateCreated = DateTime.Now;
            u1.activeTo = DateTime.MaxValue;

            User u2 = new User();
            u2.username = "Yasen2";
            u2.password = "123456";
            u2.number = "82";
            u2.role = UserRoles.STUDENT;
            u2.dateCreated = DateTime.Now;
            u2.activeTo = DateTime.MaxValue;

            User u3 = new User();
            u3.username = "Ivan";
            u3.password = "123456";
            u3.number = "83";
            u3.role = UserRoles.STUDENT;
            u3.dateCreated = DateTime.Now;
            u3.activeTo = DateTime.MaxValue;

            _testUsers.Add(u1);
            _testUsers.Add(u2);
            _testUsers.Add(u3);
        }

        static public User isUserPassCorrect(string username, string password)
        {
            ResetTestUserData();
            List<User> u = (from user in _testUsers
                    where (user.username.Equals(username))
                    && (user.password.Equals(password))
                    select user).ToList();

            if (u.Any())
                return u.First();
            return null;
                /*
            for (int i = 0; i < _testUsers.Count; i++)
            {
                if (username.Equals(_testUsers[i].username) &&
                    password.Equals(_testUsers[i].password))
                {
                    return _testUsers[i];
                }
            }
            return null;
            */
        }

        static public bool setUserActiveTo(int userIndex, DateTime newDate)
        {
            if (!AllUsersUsernames().ContainsValue(userIndex))
            {
                return false;
            }

            _testUsers[userIndex].activeTo = newDate;
            Logger.LogActivity("Change in activity of " + _testUsers[userIndex].username);
            return true;
        }

        static public bool assignUserRole(int userIndex, UserRoles newRole)
        {
            if (!AllUsersUsernames().ContainsValue(userIndex))
            {
                return false;
            }

            _testUsers[userIndex].role = newRole;
            //Console.WriteLine("Role of " + _testUsers[userIndex].username + " is " + _testUsers[userIndex].role);
            Logger.LogActivity("Change in role of " + _testUsers[userIndex].username);
            return true;
        }

        static public Dictionary<string, int> AllUsersUsernames()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < _testUsers.Count; i++)
            {
                result.Add(_testUsers[i].username, i);
            }
            return result;
        }
    }
}
