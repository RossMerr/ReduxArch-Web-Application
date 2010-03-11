using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReduxArch.Core.PersistenceSupport;

namespace Redux.Web.Domain.UserAccount
{
    public interface IUserAccountRepository : IRepository<UserAccount,Guid>
    {
    }
}