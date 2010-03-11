using System.Collections.Generic;
using System.Web.Security;
using ReduxArch.Core.PagedList;

namespace Redux.Web.UI.Models.UserAdministration
{
    public class IndexViewModel
    {
        public IPagedList<MembershipUser> Users { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}