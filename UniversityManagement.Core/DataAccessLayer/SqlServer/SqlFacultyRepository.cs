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
    public class SqlFacultyRepository : IFacultyRepository
    {
        private readonly string _connectionString;
        public SqlFacultyRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlFacultyRepository()
        {
        }

        public void Add(Faculty faculty)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();
            const string query = "insert into faculty values(name) ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("name", faculty.Name);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();
            const string query = "delete from faculty where id = @id ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
        public void Update(Faculty faculty)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = "update faculty set name = @name ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", faculty.Id);
            cmd.Parameters.AddWithValue("name", faculty.Name);
            cmd.ExecuteNonQuery();
        }

        public Faculty Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            const string query = "select * from faculty where id = @id ";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Mapper.FacultyMap(reader);
            }
            return null;
        }

        public List<Faculty> Get()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            const string query = "select * from faculty where id = @id ";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Faculty> faculty = new List<Faculty>();
            while (reader.Read())
            {

                Mapper.FacultyMap(reader).Add(Mapper.FacultyMap(reader));
            }


            return faculty;
        }

        
    }
}
