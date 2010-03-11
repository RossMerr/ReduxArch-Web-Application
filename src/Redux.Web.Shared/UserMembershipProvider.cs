using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redux.Membership;

namespace Redux.Web.Shared
{
    public class UserMembershipProvider : ReduxMembershipProvider<UserAccount, Guid>
    {
        //UserAccountDao

        public override UserAccount GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public override UserAccount GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override void Save(UserAccount model)
        {
            throw new NotImplementedException();
        }

        public override UserAccount NewModel()
        {
            throw new NotImplementedException();
        }

        public override UserAccount GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public override void Delete(UserAccount user)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<UserAccount> GetByEmailAddress(string email, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<UserAccount> GetByUsername(string username, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<UserAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public override UserAccount GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline(DateTime period)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<UserAccount> GetByUsernameAndQuestionAnswer(string username, string encodePasswordQuestionAnswer)
        {
            throw new NotImplementedException();
        }
    }
}
