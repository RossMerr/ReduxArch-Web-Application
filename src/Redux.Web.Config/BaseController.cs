using System.Web.Mvc;
using Ninject;
using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Config
{
    public class BaseController : Controller
    {
        [Inject]
        public IUserAccountService UserAccountDao
        {
            get; set;
        }
    }
}
