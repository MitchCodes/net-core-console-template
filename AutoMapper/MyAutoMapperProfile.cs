using System;
using AutoMapper;
using net_core_console_template.Models;

namespace net_core_console_template.AutoMapper
{
    public class MyAutoMapperProfile : Profile
    {
        public MyAutoMapperProfile()
        {
            CreateMap<Foo, FooDto>();
            // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
        }
    }
}
