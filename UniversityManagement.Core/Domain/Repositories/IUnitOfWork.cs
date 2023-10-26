using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Core.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public IProfessionFacultyRepository ProfessionFacultyRepository { get; set; }
        public IProfessionRepository ProfessionRepository { get; set; }
        public IFacultyRepository FacultyRepository { get; set;}
        public IBranchRepository BranchRepository { get; set; }
    }
}
