using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Core.Domain.Entities
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Profession> Professions { get; set; }

        internal void Add(Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}
