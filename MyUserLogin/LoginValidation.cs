using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    public class LoginValidation
    {

        private string username;
        private string password;
        private string errorMessage;
        private ActionOnError actionOnError;

        public LoginValidation(string u, string p, ActionOnError aoe)
        {
            username = u;
            password = p;
            actionOnError = aoe;
        }

        static private UserRoles currentUserRole;

        static public UserRoles CurrentUserRole
        {
            get
            {
                return currentUserRole;
            }
             private set
            {
                
            }
        }

        public delegate void ActionOnError(string errorMsg);

        public bool ValidateUserInput(ref User u)
        {
            currentUserRole = UserRoles.ANONYMOUS;

            Boolean isEmptyUsername;
            isEmptyUsername = username.Equals(String.Empty);
            if (isEmptyUsername)
            {
                errorMessage = "Username not provided.";
                actionOnError(errorMessage);
                return false;
            }

            Boolean isEmptyPassword;
            isEmptyPassword = password.Equals(String.Empty);
            if (isEmptyPassword)
            {
                errorMessage = "Password not provided.";
                actionOnError(errorMessage);
                return false;
            }

            Boolean isUsernameShort;
            isUsernameShort = (username.Length < 5);
            if (isUsernameShort)
            {
                errorMessage = "Username should be at least 5 characters.";
                actionOnError(errorMessage);
                return false;
            }

            Boolean isPasswordShort;
            isPasswordShort = (password.Length < 5);
            if (isPasswordShort)
            {
                errorMessage = "Password should be at least 5 characters.";
                actionOnError(errorMessage);
                return false;
            }

            u = UserData.isUserPassCorrect(username, password);

            if (u == null)
            {
                errorMessage = "No such username or password.";
                actionOnError(errorMessage);
                return false;
            }

            currentUserRole = u.role;

            Logger.LogActivity("Successful Login");

            return true;
        }
    }
}
