using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;

namespace UniversityManagement.Core.Domain.Repositories
{
    public interface IFacultyRepository
    {
        void Add(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(int id);
        
        Faculty Get(int id);
        List<Faculty> Get();
    }
}
