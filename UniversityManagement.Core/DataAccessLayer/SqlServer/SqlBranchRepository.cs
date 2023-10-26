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
    public class SqlBranchRepository : IBranchRepository
    {
        private readonly string _connectionString;
        private string connectionString;

        public SqlBranchRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlBranchRepository()
        {
        }

        public void Add(Branch branch)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            
                connection.Open();
            const string query = "Insert into Branches values(@name,@address)";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("name", branch.Name);
            cmd.Parameters.AddWithValue("Address", branch.Address);

            cmd.ExecuteNonQuery();
        }

        

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);



            const string query = "Delete from branches where id = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);


            cmd.ExecuteNonQuery();
        }
            public void Update(Branch branch)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            const string query = "Update branches set name = @name, adress = @adress where id = @Id ";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", branch.Id);
            cmd.Parameters.AddWithValue("name", branch.Name);
            cmd.Parameters.AddWithValue("address", branch.Address);

            cmd.ExecuteNonQuery();
        }
        public Branch Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = "select * from branches where id = @id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            return Mapper.BranchMap(reader);
        }

        public List<Branch> Get()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = "select * from branches ";

            SqlCommand cmd = new SqlCommand(query, connection);


            SqlDataReader reader = cmd.ExecuteReader();

            List<Branch> result = new List<Branch>();
            while (reader.Read())
            {
                Branch branch = Mapper.BranchMap(reader);
                result.Add(branch);
            }
            return result;
        }

       
    }
}
