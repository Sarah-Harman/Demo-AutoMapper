using AutoMapperTesting.Models.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YAXLib;

namespace AutoMapperTesting.Models.Xml
{
    [XmlRoot("Pr")]
    public class XmlClauseItem
    {
        public XmlClauseItem()
        {
            InnerValue = new InnerClauseValue();
        }

        [XmlElement("id")]
        public string KeywordInstanceId { get; set; }

        [XmlElement("name")]
        public string Title { get; set; }

        [XmlElement("PrV")]
        public InnerClauseValue InnerValue { get; set; }

    }

    
    public class ChildKeyword
    {
        [XmlElement("id")]
        public string KeywordInstanceId { get; set; }

        [XmlElement("name")]
        public string Title { get; set; }
    }

    [XmlType("PrV")]
    public class InnerClauseValue
    {
        [XmlElement("Pr")]
        public List<ChildKeyword> ChildKeywords { get; set; }

        public string Value { get; set; }
    }

}
