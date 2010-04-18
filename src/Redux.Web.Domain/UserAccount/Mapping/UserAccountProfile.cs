using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace Redux.Web.Domain.UserAccount.Mapping
{
    public class UserAccountProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UserAccountModel, UserViewModel>();

            CreateMap<UserViewModel, UserAccountModel>();
        }
    }
}
