using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using ReduxArch.Core.DomainModel;
using ReduxArch.Data;

namespace Redux.Web.Domain.UserAccount
{
    [ActiveRecord]
    [Serializable]
    public class UserAccount : Entity, IUser<Guid>
    {     
        private UserAccount()
        {         
            DateCreated = DateTime.UtcNow;
            LastLoginDate = DateCreated;
            LastActiveDate = DateCreated;
            LastLockoutDate = DateCreated;
            LastPasswordChangedDate = DateCreated;
            IsApproved = true;
            IsLockedOut = false;
            LoginTrys = 0;                  
        }

        [PrimaryKey(Generator = PrimaryKeyType.GuidComb)]
        [DomainSignature]
        public Guid Id
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Username
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Password
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Salt
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string PasswordQuestion
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string QuestionAnswer
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Email
        {
            get;
            protected set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Comment
        {
            get;
            protected set;
        }

        [Property]
        public bool IsApproved
        {
            get;
            protected set;
        }

        [Property]
        public bool IsLockedOut
        {
            get;
            protected set;
        }

        [Property]
        public DateTime LastActiveDate
        {
            get;
            protected set;
        }

        [Property]
        public DateTime LastLockoutDate
        {
            get;
            protected set;
        }

        [Property]
        public DateTime LastLoginDate
        {
            get;
            protected set;
        }

        [Property]
        public DateTime LastPasswordChangedDate
        {
            get;
            protected set;
        }

        [Property]
        public DateTime DateCreated
        {
            get;
            protected set;
        }

        [Property]
        public int LoginTrys
        {
            get;
            protected set;
        }
    }
}

