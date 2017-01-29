using AutoMapperTesting.Automapper.Config;
using AutoMapperTesting.Models.DTO;
using AutoMapperTesting.Models.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using YAXLib;

namespace AutoMapperTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            var xl = new XmlSerializer(typeof(XmlClause));
            var clause = BuildFakeClause();
            var mappedClause = new Configuration().MapClause(clause);
            
            var xml = string.Empty;

            //var serializer = new YAXSerializer(typeof(XmlClause));
            //xml = serializer.Serialize(mappedClause);

            using (var sw = new StringWriter())
            {
                using (var writer = XmlWriter.Create(sw))
                {
                    var ns = new XmlSerializerNamespaces();
                    ns.Add("", "");

                    xl.Serialize(writer, mappedClause, ns);
                    xml = sw.ToString();
                }
            }



        }

        private static Clause BuildFakeClause()
        {
            return new Clause()
            {
                Id = Guid.NewGuid(),
                Title = "Fake Clause Title",
                ClauseItems = new List<ClauseItem>()
                {
                     new ClauseItem()
                     {
                           Id = Guid.NewGuid(),
                           Title = "System manufacturer",
                           Value = "Custom made"
                     },
                     //new ClauseItem()
                     //{
                     //      Id = Guid.NewGuid(),
                     //      Title = "Cold water taps",
                     //      Value = "N/a"
                     //}
                 }
            };
        }


    }
}
