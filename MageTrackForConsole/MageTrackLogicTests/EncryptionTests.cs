namespace MageTrackLogicTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EncryptionTests
    {
        string plainTextPassword = "password";
        string incorrectPlainTextPassword = "notPassword";
        int workFactor = 10;

        [TestMethod]
        public void EncryptPassword_EncryptsPassword()
        {
            string encryptedPassword = 
                new MageTrackLogic.Encryption(this.workFactor).EncryptPassword(plainTextPassword);
            Assert.AreNotEqual(plainTextPassword, encryptedPassword);
        }

        [TestMethod]
        public void EncryptPassword_RunsSufficientlyLong()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            new MageTrackLogic.Encryption(this.workFactor).EncryptPassword(plainTextPassword);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= 80);
        }
    }
}
