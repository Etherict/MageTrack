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
            string encryptedPassword = new Encryption().EncryptPassword(plainTextPassword);
            //Pass the encrypted password and username down to data for storage

        }

        public bool LogUserIn(int userId, string plainTextPassword)
        {
            bool wasLoginSuccessful = false;
            //
            return wasLoginSuccessful;
        }
    }
}
