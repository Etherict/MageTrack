using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageTrackLogic
{
    public class UserMaintenance
    {
        /// <summary>
        /// Store a new user.
        /// </summary>
        /// <param name="userName">The users chosen name</param>
        /// <param name="plainTextPassword">The users password, prior to any encryption</param>
        public void StoreUser(string userName, string plainTextPassword)
        {
            //Encrypt the users password
            //Pass the encrypted password and username down to data for storage
        }

        public bool LogUserIn(string userName, string plainTextPassword)
        {
            bool wasLoginSuccessful = false;
            //
            return wasLoginSuccessful;
        }
    }
}
