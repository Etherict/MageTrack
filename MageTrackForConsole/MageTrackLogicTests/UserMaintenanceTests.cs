using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MageTrackLogicTests
{
    [TestClass]
    public class UserMaintenanceTests
    {
        string plainTextPassword = "password";
        string incorrectPlainTextPassword = "notPassword";
        string userName = "user";
        int workForce = 10;

        [TestMethod]
        public void EncryptPassword_EncryptsPassword()
        {
            MageTrackLogic.User user = new MageTrackLogic.User();
            user.UserName = userName;
            user.PlainTextPassword = plainTextPassword;
            user.IsNewUser = true;
            new MageTrackLogic.UserMaintenance().EncryptPassword(user);
            Assert.AreNotEqual(user.HashedPassword, user.PlainTextPassword);
        }

        [TestMethod]
        public void EncryptPassword_RunsForSufficientTime()
        {
            MageTrackLogic.User user = new MageTrackLogic.User();
            user.UserName = userName;
            user.PlainTextPassword = plainTextPassword;
            user.IsNewUser = true;
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            new MageTrackLogic.UserMaintenance().EncryptPassword(user);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= 80);
        }
    }
}
