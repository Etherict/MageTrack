namespace MageTrackLogicTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EncryptionTests
    {
        string PlainTextPassword = "password";
        string IncorrectPlainTextPassword = "notPassword";
        int WorkFactor = 10;

        [TestMethod]
        public void EncryptPassword_EncryptsPassword()
        {
            string encryptedPassword = 
                new MageTrackLogic.Encryption(this.WorkFactor).EncryptPassword(PlainTextPassword);
            Assert.AreNotEqual(PlainTextPassword, encryptedPassword);
        }

        [TestMethod]
        public void EncryptPassword_RunsSufficientlyLong()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            new MageTrackLogic.Encryption(this.WorkFactor).EncryptPassword(PlainTextPassword);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= 80);
        }

        [TestMethod]
        public void VerifyPassword_VerifiesValidPassword()
        {
            string encryptedPassword = 
                new MageTrackLogic.Encryption(this.WorkFactor)
                .EncryptPassword(PlainTextPassword);
            bool isPasswordVerified = 
                new MageTrackLogic.Encryption(this.WorkFactor)
                .VerifyPassword(PlainTextPassword, encryptedPassword);
            Assert.IsTrue(isPasswordVerified);
        }

        [TestMethod]
        public void VerifyPassword_RejectsInvalidPassword()
        {
            string encryptedPassword = 
                new MageTrackLogic.Encryption(this.WorkFactor)
                .EncryptPassword(PlainTextPassword);
            bool isPasswordVerified = 
                new MageTrackLogic.Encryption(this.WorkFactor)
                .VerifyPassword(IncorrectPlainTextPassword, encryptedPassword);
            Assert.IsFalse(isPasswordVerified);
        }
    }
}
