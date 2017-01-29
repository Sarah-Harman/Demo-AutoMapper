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
    public class ClauseProfile : Profile
    {
        public ClauseProfile()
        {
            ConfigureProfile();
        }
        
        private void ConfigureProfile()
        {
            CreateMap<Clause, XmlClause>();
            
        }
    }
}
