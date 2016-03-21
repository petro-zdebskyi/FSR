using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;

namespace FSR.DesktopUI.Code
{
    public static class CurrentUser
    {
        private static User currentUser;

        public static void Initialize(User user)
        {
            if (currentUser != null)
            {
                throw new InvalidOperationException("Current user has already been specified");
            }
            currentUser = user;
        }

        public static int Id
        {
            get
            {
                return currentUser.Id;
            }
        }

        public static string Name
        {
            get
            {
                return currentUser.Name;
            }
        }

        public static string Surname
        {
            get
            {
                return currentUser.Surname;
            }
        }

        public static string Login
        {
            get
            {
                return currentUser.Login;
            }
        }

    }
}
