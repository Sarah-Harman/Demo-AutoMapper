using AutoMapper;
using AutoMapperTesting.Models.DTO;
using AutoMapperTesting.Models.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTesting.Automapper.Profiles
{
    public class ClauseItemProfile : Profile
    {
        public ClauseItemProfile()
        {
            ConfigureProfile();
        }

        private void ConfigureProfile()
        {
            CreateMap<ClauseItem, XmlClauseItem>()
                .ForMember(src=> src.KeywordInstanceId, opts=> opts.MapFrom(x=> x.Id));
            CreateMap<XmlClauseItem, ChildKeyword>();
           
        }
    }
}
