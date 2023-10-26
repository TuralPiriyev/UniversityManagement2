using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Repositories;

namespace UniversityManagement.Core.DataAccessLayer.SqlServer
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly string _connectionString;
        public SqlUnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IProfessionFacultyRepository ProfessionFacultyRepository { get =>  new SqlProfessionFacultyRepository(); set => new SqlProfessionFacultyRepository(); }
        public IProfessionRepository ProfessionRepository { get => new SqlProfessionRepository(); set => new SqlProfessionRepository(); }
        public IFacultyRepository FacultyRepository { get => new SqlFacultyRepository();  set => new SqlFacultyRepository(); }
        public IBranchRepository BranchRepository { get => new SqlBranchRepository(); set => new SqlBranchRepository(); }
    }
}
