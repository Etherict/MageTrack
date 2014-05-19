namespace MageTrackLogic
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Encryption
    {
        internal Encryption()
        {
            this.WorkFactor = 
                Convert.ToInt32(ConfigurationManager.AppSettings["workFactor"]);
        }

        internal Encryption(int workFactor)
        {
            this.WorkFactor = workFactor;
        }

        internal int WorkFactor
        {
            get;
            set;
        }

        /// <summary>
        /// Encrypt a password using Bcrypt with the workforce specified in the config
        /// </summary>
        /// <param name="plainTextPassword">The password to encrypt, in plaintext</param>
        /// <returns>The encrypted password</returns>
        internal string EncryptPassword(string plainTextPassword)
        {
            string encryptedPassword =
                BCrypt.Net.BCrypt.HashPassword(plainTextPassword, this.WorkFactor);
            return encryptedPassword;
        }

        /// <summary>
        /// Determine if a plaintext password and a hash match
        /// </summary>
        /// <param name="plainTextPassword">The plaintext to compare</param>
        /// <param name="encryptedPassword">The hash to compare</param>
        /// <returns>The result of the comparison</returns>
        internal bool VerifyPassword(string plainTextPassword, string encryptedPassword)
        {
            bool isVerified = BCrypt.Net.BCrypt.Verify(plainTextPassword, encryptedPassword);
            return isVerified;
        }
    }
}
