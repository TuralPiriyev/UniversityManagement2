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
    public class SqlProfessionRepository : IProfessionRepository
    {
        private readonly string _connectionString;
        private List<Profession> profession;

        public SqlProfessionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlProfessionRepository()
        {
        }

        public void Add(Profession profession)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = "insert into professions values(name)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("name", profession.Name);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            const string query = "delete from professions where id = @id";
            SqlCommand cmd  = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
        public void Update(Profession profession)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = "update professions set name = @name ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", profession.Id);
            cmd.Parameters.AddWithValue("name", profession.Name);
            cmd.ExecuteNonQuery();
        }

        public Profession Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            const string query = "select * from professions where id = @id ";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Mapper.ProfessionMap(reader);
            }
            return null;
        }

        public List<Profession> Get()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            const string query = "select * from faculty where id = @id ";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Faculty> faculty = new List<Faculty>();
            while (reader.Read())
            {

                Mapper.ProfessionMap(reader).Add(Mapper.ProfessionMap(reader));
            }


            return profession;
        }

        
    }
}
