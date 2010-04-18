using System;
using System.Collections.Generic;
using Ninject;
using Redux.Membership;
using Redux.Web.Config.Modules;
using Redux.Web.Domain.UserAccount;
using ReduxArch.Data.Interface;

namespace Redux.Web.Membership
{
    public class UserMembershipProvider : ReduxMembershipProvider<UserAccountModel, Guid>
    {
        public UserMembershipProvider()
        {
            IKernel kernel = new StandardKernel(new DomainModule());
            
            UserFactory = kernel.Get<IUserFactory<UserAccountModel, Guid>>();
            UserAccountRepository = kernel.Get<IUserAccountRepository>(); 
        }

        public override UserAccountModel GetUser(string username)
        {
            return UserAccountRepository.GetByUsername(username);
        }

        public override UserAccountModel GetUserByEmail(string email)
        {
            return UserAccountRepository.GetByUsername(email);
        }

        public override void Save(UserAccountModel model)
        {
            UserAccountRepository.SaveOrUpdate(model);
        }

        public override UserAccountModel NewModel()
        {
            return UserAccountModel.CreateUserAccount();
        }

        public override UserAccountModel GetByUsername(string username)
        {
            return UserAccountRepository.GetByUsername(username);
        }

        public override void Delete(UserAccountModel user)
        {
            UserAccountRepository.Delete(user);
        }

        public override IEnumerable<UserAccountModel> GetByEmailAddress(string email, int pageIndex, int pageSize)
        {
            return UserAccountRepository.GetByEmailAddress(email, pageIndex, pageSize);
        }

        public override IEnumerable<UserAccountModel> GetByUsername(string username, int pageIndex, int pageSize)
        {
            return UserAccountRepository.GetByUsername(username, pageIndex, pageSize);
        }

        public override IEnumerable<UserAccountModel> GetAll()
        {
            return UserAccountRepository.GetAll();
        }

        public override UserAccountModel GetById(Guid id)
        {
            return UserAccountRepository.Get(id);
        }

        public override int GetNumberOfUsersOnline(DateTime period)
        {
            return UserAccountRepository.GetNumberOfUsersOnline(period);
        }

        public override IEnumerable<UserAccountModel> GetByUsernameAndQuestionAnswer(string username, string encodePasswordQuestionAnswer)
        {
            return UserAccountRepository.GetByUsernameAndQuestionAnswer(username, encodePasswordQuestionAnswer);
        }

        [Inject]
        public IUserAccountRepository UserAccountRepository
        {
            get; set;
        }
    }
}


