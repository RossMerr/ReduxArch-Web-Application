using Redux.Web.Domain.UserAccount;

namespace Redux.Web.Config
{
    public class EntitiesRegistration
    {
        public static void RegisterAllEntities()
        {
            ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration.RegisterAllEntities(typeof(UserAccountModel));
        }

        public static void CreateSchema()
        {
            ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration.CreateSchemaStatic();
        }

        public static void DropSchema()
        {
            ReduxArch.Data.Castle.ActiveRecord.EntitiesRegistration.DropSchemaStatic();
        }
    }
}
