using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReduxArch.Data.Service;

namespace Redux.Web.Domain.UserAccount
{
    public class UserAccountService : BaseService<UserAccountModel, UserViewModel, Guid, IUserAccountRepository>, IUserAccountService
    {
        public override UserViewModel Create()
        {
            return new UserViewModel();
        }
    }
}
