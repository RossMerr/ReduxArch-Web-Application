using System;
using System.Collections.Generic;
using System.Linq;
using Redux.Web.Domain.UserAccount;
using ReduxArch.Core.PagedList;
using ReduxArch.Data.Castle.ActiveRecord;
using NHibernate.Linq;

namespace Redux.Web.Repositories
{
    public class UserAccountRepository : CastleRepository<UserAccountModel, Guid>, IUserAccountRepository
    {
        public UserAccountModel GetUserByEmail(string email)
        {
            var context = new ActiveRecordLinqContext();
            var results = from users in context.Session.Linq<UserAccountModel>()
                          where users.Email == email
                          select users;

            return results.Count() > 0 ? results.ElementAt(0) : null;
        }

        public UserAccountModel GetByUsername(string username)
        {
            var context = new ActiveRecordLinqContext();
            var results = from users in context.Session.Linq<UserAccountModel>()
                          where users.Username == username
                          select users;

            return results.Count() > 0 ? results.ElementAt(0) : null;
        }

        public int GetNumberOfUsersOnline(DateTime period)
        {
            var context = new ActiveRecordLinqContext();
            var results = from p in context.Session.Linq<UserAccountModel>()
                          where p.LastActiveDate >= period
                          select p;

            return results.Count();
        }

        public IEnumerable<UserAccountModel> GetByEmailAddress(string email, int pageIndex, int pageSize)
        {
            var context = new ActiveRecordLinqContext();
            var results = (from p in context.Session.Linq<UserAccountModel>()
                         where p.Email == email
                         select p);

            return PagedListExtensions.ToPagedList(results, pageIndex, pageSize);
        }

        public IEnumerable<UserAccountModel> GetByUsername(string username, int pageIndex, int pageSize)
        {
            var context = new ActiveRecordLinqContext();
            var results = (from p in context.Session.Linq<UserAccountModel>()
                           where p.Username == username
                           select p);

            return PagedListExtensions.ToPagedList(results, pageIndex, pageSize);
        }

        public IEnumerable<UserAccountModel> GetByUsernameAndQuestionAnswer(string username, string encodePasswordQuestionAnswer)
        {
            var context = new ActiveRecordLinqContext();
            var results = (from p in context.Session.Linq<UserAccountModel>()
                           where p.Username == username
                           where p.QuestionAnswer == encodePasswordQuestionAnswer
                           select p);

            return results;
        }
    }
}