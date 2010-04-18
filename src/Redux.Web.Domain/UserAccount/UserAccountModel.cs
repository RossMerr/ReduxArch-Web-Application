using System;
using Castle.ActiveRecord;
using ReduxArch.Core.DomainModel;
using ReduxArch.Data.Interface;

namespace Redux.Web.Domain.UserAccount
{
    [ActiveRecord(Table = "UserAccount", Lazy = true)]
    [Serializable]
    public class UserAccountModel : User<Guid>
    {     
        protected UserAccountModel() { }

        public static UserAccountModel CreateUserAccount()
        {
            return new UserAccountModel();
        }

        public static UserAccountModel CreateUserAccount(string username, string password, string email)
        {
            var now = DateTime.UtcNow;
            var userAccount = new UserAccountModel
            {
                Username = username,
                Password = password,
                Email = email,
                DateCreated = now,
                LastLoginDate = now,
                LastActiveDate = now,
                LastLockoutDate = now,
                LastPasswordChangedDate = now,
                IsApproved = true,
                IsLockedOut = false,
                LoginTrys = 0
            };

            return userAccount;
        }

        public static UserAccountModel CreateUserAccount(string username, string password, string email, string passwordQuestion, string questionAnswer, bool isApproved, string salt)
        {
            var now = DateTime.UtcNow;
            var userAccount = new UserAccountModel
            {
                Username = username,
                Password = password,
                Email = email,
                PasswordQuestion = passwordQuestion,
                QuestionAnswer = questionAnswer,
                Salt = salt,
                DateCreated = now,
                LastLoginDate = now,
                LastActiveDate = now,
                LastLockoutDate = now,
                LastPasswordChangedDate = now,
                IsApproved = isApproved,
                IsLockedOut = false,
                LoginTrys = 0
            };

            return userAccount;
        }

        #region properties

        [PrimaryKey(Generator = PrimaryKeyType.GuidComb)]
        [DomainSignature]
        public new virtual Guid Id
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public override string Username
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public override string Password
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = false)]
        public override string Salt
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = false)]
        public override string PasswordQuestion
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = false)]
        public override string QuestionAnswer
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public override string Email
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = false)]
        public override string Comment
        {
            get;
            protected set;
        }

        [Property]
        public override bool IsApproved
        {
            get;
            protected set;
        }

        [Property]
        public override bool IsLockedOut
        {
            get;
            protected set;
        }

        [Property]
        public override DateTime LastActiveDate
        {
            get;
            protected set;
        }

        [Property]
        public override DateTime LastLockoutDate
        {
            get;
            protected set;
        }

        [Property]
        public override DateTime LastLoginDate
        {
            get;
            protected set;
        }

        [Property]
        public override DateTime LastPasswordChangedDate
        {
            get;
            protected set;
        }

        [Property]
        public override DateTime DateCreated
        {
            get;
            protected set;
        }

        [Property]
        public override int LoginTrys
        {
            get;
            protected set;
        }

        #endregion
    }


}

