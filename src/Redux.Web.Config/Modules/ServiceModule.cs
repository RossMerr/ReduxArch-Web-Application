using Ninject.Modules;
using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Config.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserAccountService>().To<UserAccountService>();
        }
    }
}
