using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using ReduxArch.Data;

namespace Redux.Web.Domain.UserAccount
{
    [ActiveRecord]
    public class UserAccountMedaData 
    {        
        public Guid Id
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Username
        {
            get; set;
        }

        [Property(Length = 50, NotNull = true)]
        public string Password
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]
        public string Salt
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]
        public string PasswordQuestion
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]      
        public string QuestionAnswer
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]     
        public string Email
        {
            get; set;
        }

        [Property(Length = 255, NotNull = true)]     
        public string Comment
        {
            get; set;
        }

        [Property]
        public bool IsApproved
        {
            get; set;
        }

        [Property]
        public bool IsLockedOut
        {
            get; set;
        }

        [Property]
        public DateTime LastActiveDate
        {
            get; set;
        }

        [Property]
        public DateTime LastLockoutDate
        {
            get; set;
        }

        [Property]
        public DateTime LastLoginDate
        {
            get; set;
        }

        [Property]
        public DateTime LastPasswordChangedDate
        {
            get; set;
        }

        [Property]
        public DateTime DateCreated
        {
            get; set;
        }

        [Property]
        public int LoginTrys
        {
            get; set;
        }
    }
}