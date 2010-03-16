using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redux.Web.Domain.UserAccount;
using ReduxArch.Data.Castle.ActiveRecord;

namespace Redux.Web.Shared
{
    public class EntitiesRegistration
    {
        public static void RegisterAllEntities()
        {
            ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration.RegisterAllEntities(typeof(UserAccountModel));
        }

        public static void CreateSchema()
        {
            var registration = new ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration();
            registration.CreateSchema();
        }

        public static void DropSchema()
        {
            var registration = new ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration();
            registration.DropSchema();
        }
    }
}
