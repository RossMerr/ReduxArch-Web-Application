using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Ninject;
using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Shared
{
    public class BaseController : Controller
    {
        [Inject]
        public IUserAccountRepository UserAccountDao
        {
            get; set;
        }
    }
}
