using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTesting.Models.DTO
{
    public class Clause
    {
        public Guid Id { get; set; }

        public List<ClauseItem> ClauseItems { get; set; }

        public string Title { get; set; }
    }
}
