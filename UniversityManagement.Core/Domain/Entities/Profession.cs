using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Core.Domain.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Faculty> Faculty { get; set; }

        internal void Add(Profession profession)
        {
            throw new NotImplementedException();
        }
    }
}
