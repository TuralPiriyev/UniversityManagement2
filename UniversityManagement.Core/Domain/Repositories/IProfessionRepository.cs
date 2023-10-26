using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;

namespace UniversityManagement.Core.Domain.Repositories
{
    public interface IProfessionRepository
    {
        void Add(Profession profession);
        void Update(Profession profession);
        void Delete(int id);

        Profession Get(int id);
        List<Profession> Get();

    }
}
