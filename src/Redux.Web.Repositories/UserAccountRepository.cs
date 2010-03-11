using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redux.Web.Domain.UserAccount;
using ReduxArch.Data.Castle.ActiveRecord;

namespace Redux.Web.Repositories
{
    public class UserAccountRepository : CastleRepository<UserAccount, Guid>, IUserAccountRepository
    {
    }
}