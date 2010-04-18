using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using Redux.Web.Domain.UserAccount;
using Redux.Web.Repositories;
using ReduxArch.Data.Interface;

namespace Redux.Web.Shared.Modules
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserAccountRepository>().To<UserAccountRepository>();
            Bind<IUserFactory<UserAccountModel, Guid>>().To<UserAccountFactory>();   
        }
    }
}
