using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using Redux.Web.Domain.UserAccount;
using Redux.Web.Repositories.UserAccount;

namespace Redux.Web.Shared.Modules
{
    class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserAccountRepository>().To<UserAccountRepository>();          
        }
    }
}
