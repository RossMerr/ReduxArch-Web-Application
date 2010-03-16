using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReduxArch.Data.Interface;

namespace Redux.Web.Domain.UserAccount
{
    public class UserAccountFactory : IUserFactory<UserAccountModel, Guid>
    {
        public UserAccountModel CreateUser(string username, string password, string email, string passwordQuestion, string questionAnswer, bool isApproved, string salt)
        {
            return UserAccountModel.CreateUserAccount(username, password, email, passwordQuestion, questionAnswer, isApproved, salt);
        }
    }
}
