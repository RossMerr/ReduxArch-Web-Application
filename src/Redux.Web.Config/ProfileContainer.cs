using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Ninject;
using Redux.Web.Config.Modules;
using ReduxArch.Core.PersistenceSupport;

namespace Redux.Web.Config
{
    public class ProfileContainer<TRepository, TModel> : Profile where TRepository : IRepository<TModel, Guid>
    {
        private static volatile IKernel _instance;
        private static readonly object SyncRoot = new Object();

        static ProfileContainer()
        {
            Repository = Instance.Get<TRepository>();
        }

        public static IKernel Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new StandardKernel(new DomainModule(), new ServiceModule());
                    }
                }

                return _instance;
            }
        }

        [Inject]
        public static TRepository Repository
        {
            get;
            set;
        }

    }
}
