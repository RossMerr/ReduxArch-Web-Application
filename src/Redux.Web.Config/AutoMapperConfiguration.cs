using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Redux.Web.Domain.UserAccount.Mapping;

namespace Redux.Web.Config
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
                                  {
                                      x.AddProfile<UserAccountProfile>();
                                  }
                );
        }
    }
}
