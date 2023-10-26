using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Domain.Entities;
using UniversityManagement.Core.Domain.Repositories;

namespace UniversityManagement.Core.DataAccessLayer.SqlServer
{
    public class SqlProfessionFacultyRepository : IProfessionFacultyRepository
    {
        private readonly string _connectionString;
        

        public SqlProfessionFacultyRepository(string connectionString)
        {
            _connectionString = connectionString;

        }

        public SqlProfessionFacultyRepository()
        {
        }

        public void Add(ProfessionFaculty professionfaculty)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            const string query = "insert into specialtyoffaculty(professionid,facultyid ) values(@professionid, @facultyid)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("professionid", professionfaculty.Id);
            cmd.Parameters.AddWithValue("facultyid", professionfaculty.Id);
            cmd.ExecuteNonQuery();
        }

       

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            const string query = "delete from professionfacult where id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }

        public List<ProfessionFaculty> GetByProfessionId(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            const string query = @"select * from ProfessionFaculty pf
join Profession p on p.Id = pf.ProfessionId
join Faculty f on f.Id = pf.FacultyId where p.id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);   
            SqlDataReader reader = cmd.ExecuteReader();
            List<ProfessionFaculty> professionfaculties = new List<ProfessionFaculty>();

            while (reader.Read())
            {
                ProfessionFaculty pf = Mapper.ProfessionFacultyMap(reader);

                professionfaculties.Add(pf);
            }
            return professionfaculties;
        }

        public List<ProfessionFaculty> GetByFacultyId(int id)
        {
            throw new NotImplementedException();
        }

        

       
    }
}
