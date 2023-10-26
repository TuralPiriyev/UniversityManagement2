using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;

namespace UniversityManagement.Core.Domain.Repositories
{
    public interface IProfessionFacultyRepository
    {
        void Add(ProfessionFaculty professionfaculty);
        
        void Delete(int id);

      //  ProfessionFaculty Get(int id);
        List<ProfessionFaculty> GetByProfessionId(int id);
      //  List<ProfessionFaculty> GetByFaculty(int id);
        List<ProfessionFaculty> GetByFacultyId(int id);
    }
}
