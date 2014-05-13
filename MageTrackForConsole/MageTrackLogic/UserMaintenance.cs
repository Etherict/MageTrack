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

        /// <summary>
        /// Encrypts a password, using BCrypt, with the WorkForce maintained in the config
        /// </summary>
        /// <param name="plainTextPassword"></param>
        /// <returns></returns>
        internal string EncryptPassword(MageTrackLogic.User user)
        {
            //Retrieve the workforce from the config
            string encryptedPassword = string.Empty;
            //encrypt the password using the workforce
            //return the encrypted password
            return encryptedPassword;
        }

        public bool LogUserIn(string userName, string plainTextPassword)
        {
            bool wasLoginSuccessful = false;
            //
            return wasLoginSuccessful;
        }
    }
}
