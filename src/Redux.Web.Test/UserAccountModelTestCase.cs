using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Test
{
    [TestFixture]
    public class UserAccountModelTestCase : AbstractModelTestCase
    {
        [Test]
        public void CreateUser()
        {
            var user = UserAccountModel.CreateUserAccount("ross", "password", "email@email.com");
            UserAccountRepository.SaveOrUpdate(user);

            var newUser = UserAccountRepository.Get(user.Id);
            Assert.IsNotNull(newUser, "UserAccount not found");
            Assert.IsTrue(newUser.Username == user.Username, "Name not saved correctly");
            Assert.IsTrue(newUser.Email == user.Email, "Email not saved correctly");
            Assert.IsTrue(newUser.Password == user.Password, "Password not saved correctly");

            var userTwo = UserAccountModel.CreateUserAccount("ross", "password", "email@email.com", "passwordQuestion",
                                                             "questionAnswer", false, "salt");
            UserAccountRepository.SaveOrUpdate(userTwo);

            newUser = UserAccountRepository.Get(userTwo.Id);
            Assert.IsNotNull(newUser, "UserAccount not found");
            Assert.IsTrue(newUser.Username == userTwo.Username, "Name not saved correctly");
            Assert.IsTrue(newUser.Email == userTwo.Email, "Email not saved correctly");
            Assert.IsTrue(newUser.Password == userTwo.Password, "Password not saved correctly");

            Assert.IsTrue(newUser.PasswordQuestion == userTwo.PasswordQuestion, "PasswordQuestion not saved correctly");
            Assert.IsTrue(newUser.QuestionAnswer == userTwo.QuestionAnswer, "QuestionAnswer not saved correctly");
            Assert.IsTrue(newUser.Salt == userTwo.Salt, "Salt not saved correctly");
        }
    }
}
