using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;

namespace UniversityManagement.Core.DataAccessLayer
{
    public static class Mapper
    {
        public static Branch BranchMap(IDataReader reader)
        {
            return new Branch
            {
                Name = (string)reader["Name"],
                Id = (int)reader["Id"],
                Address = (string)reader["Address"],
            };

        }
        public static Profession ProfessionMap(IDataReader reader)
        {
            return new Profession
            {
                Id = (int)reader["Id"], 
                Name = (string)reader["Name"]
            };
        }
        public static Faculty FacultyMap(IDataReader reader)
        {
            return new Faculty
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"]
            };
        }
        public static ProfessionFaculty ProfessionFacultyMap(IDataReader reader)
        {
            return new ProfessionFaculty
            {
                Id = (int)reader["Id"],
                ProfessionId = (int)reader["professionid"],
                Profession = new Profession
                {
                    Id = (int)reader["ProfessionId"],
                    Name = (string)reader["ProfessionName"]
                },
                
                FacultyId = (int)reader["FacultyId"],
                Faculty = new Faculty
                {
                    Id = (int)reader["FacultyId"],
                    Name= (string)reader["FacultyName"]
                }

            };
        }

    }
}
