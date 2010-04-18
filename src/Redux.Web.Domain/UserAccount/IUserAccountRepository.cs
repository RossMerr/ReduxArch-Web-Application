using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReduxArch.Core.PersistenceSupport;

namespace Redux.Web.Domain.UserAccount
{
    public interface IUserAccountRepository : IRepository<UserAccountModel,Guid>
    {
        UserAccountModel GetUserByEmail(string email);
        UserAccountModel GetByUsername(string username);
        
        int GetNumberOfUsersOnline(DateTime period);

        IEnumerable<UserAccountModel> GetByEmailAddress(string email, int pageIndex, int pageSize);
        IEnumerable<UserAccountModel> GetByUsername(string username, int pageIndex, int pageSize);
        IEnumerable<UserAccountModel> GetByUsernameAndQuestionAnswer(string username, string encodePasswordQuestionAnswer);
    }
}