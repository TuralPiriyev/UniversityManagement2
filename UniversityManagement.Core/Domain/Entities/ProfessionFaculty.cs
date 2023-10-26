using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Core.Domain.Entities
{
    public class ProfessionFaculty
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int ProfessionId { get; set; }

        public Faculty Faculty { get; set; }
        public Profession Profession { get; set; }
    }
}
