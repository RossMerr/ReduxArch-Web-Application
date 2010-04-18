using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReduxArch.Core.Service;

namespace Redux.Web.Domain.UserAccount
{
    public interface IUserAccountService : IBaseService<UserAccountModel, UserViewModel, Guid, IUserAccountRepository>
    {
    }
}
