using AutoMapper;
using AutoMapperTesting.Automapper.Profiles;
using AutoMapperTesting.Models.DTO;
using AutoMapperTesting.Models.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTesting.Automapper.Config
{
    public class Configuration
    {
        private MapperConfiguration _mapper;

        public Configuration()
        {
            //_mapper = new MapperConfiguration();
        }

        public XmlClause MapClause(Clause item)
        {
            var configs = Config();

            var mappedItems = configs.Map<Clause, XmlClause>(item);

            mappedItems.ClauseItems.ForEach(x => x.InnerValue.ChildKeywords = configs.Map<List<XmlClauseItem>, List<ChildKeyword>>(mappedItems.ClauseItems));

            return mappedItems;
        }


        public IMapper Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClauseProfile());
                cfg.AddProfile(new ClauseItemProfile());
            });
            
            return config.CreateMapper();
        }
    }
}
