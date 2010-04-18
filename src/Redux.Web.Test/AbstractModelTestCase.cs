using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Ninject;
using NUnit.Framework;
using Redux.Web.Config;
using Redux.Web.Config.Modules;
using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Test
{
    public class AbstractModelTestCase
    {
        public AbstractModelTestCase()
        {
            IKernel kernel = new StandardKernel(new DomainModule(), new ServiceModule());
            UserAccountRepository = kernel.Get<IUserAccountRepository>();
        }

        [Inject]
        public IUserAccountRepository UserAccountRepository
        {
            get;
            set;
        }

        private SessionScope _scope;

        [SetUp]
        public void Init()
        {
            EntitiesRegistration.RegisterAllEntities();
            ActiveRecordStarter.CreateSchema();
            CreateScope();
        }

        [TearDown]
        public void Terminate()
        {
            DisposeScope();
            ActiveRecordStarter.DropSchema();
        }

        protected void FlushAndRecreateScope()
        {
            DisposeScope();
            CreateScope();
        }

        protected void CreateScope()
        {
            _scope = new SessionScope();
        }

        protected void DisposeScope()
        {
            _scope.Dispose();
        }
    }
}
