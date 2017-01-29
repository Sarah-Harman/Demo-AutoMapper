using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutoMapperTesting.Models.Xml
{
    [XmlRoot("Ent")]
    public class XmlClause
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        [XmlElement("Pr")]
        public List<XmlClauseItem> ClauseItems { get; set; }
    }
}
