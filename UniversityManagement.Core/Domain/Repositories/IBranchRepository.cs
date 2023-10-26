using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;

namespace UniversityManagement.Core.Domain.Repositories
{
    public interface IBranchRepository
    {
        void Add(Branch branch);
        void Update(Branch branch);
        void Delete(int id);

        Branch Get(int id);
        List<Branch> Get();
    }
}
