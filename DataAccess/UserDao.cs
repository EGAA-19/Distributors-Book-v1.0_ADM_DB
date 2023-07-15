using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Common;



namespace DataAccess
{

    public class UserDao : ConnectionToSql
    {   
        
        public /*static*/ List<Entity> ListDistributors(string NameCompany)
        {
            List<Entity> list = new List<Entity>();
            

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("ListDistributors", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Company", NameCompany);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(ObtainDistributor(reader));
                    }
                }
            }
            return list;
        }

        public /*static*/ Entity ObtainDistributor(int Id)
        {
            Entity entity = new Entity();
            

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("ObtainDistributor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        entity = ObtainDistributor(reader);
                    }

                }
                return entity;
            }
        }
        public /*static*/ Entity ObtainDistributor(SqlDataReader reader)
        {
            Entity entity = new Entity();

            entity.Id = Convert.ToInt32(reader["Id"]);       
            entity.Company = Convert.ToString(reader["Company"]);
            entity.Phone = Convert.ToString(reader["Phone"]);
            entity.Representative = Convert.ToString(reader["Representative"]);
            entity.Email = Convert.ToString(reader["Email"]);
            entity.City = Convert.ToString(reader["City"]);
            entity.Adress = Convert.ToString(reader["Adress"]);
            entity.Transport = Convert.ToBoolean(reader["Transport"]);
        
            return entity;
        }

        public /*static*/ Entity UploadDistributor(Entity entity)
        {
            Entity Entity = entity;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("UploadDistributor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Company", entity.Company);
                    command.Parameters.AddWithValue("@Phone", entity.Phone);
                    command.Parameters.AddWithValue("@Representative", entity.Representative);
                    command.Parameters.AddWithValue("@Email", entity.Email);
                    command.Parameters.AddWithValue("@City", entity.City);
                    command.Parameters.AddWithValue("@Adress", entity.Adress);
                    command.Parameters.AddWithValue("@Transport", entity.Transport);

                    command.ExecuteNonQuery();

                    return Entity;
                }
            }
        }

        public /*static*/ void DeleteUpdate(int Id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("DeleteDistributor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public /*static*/ Entity ModifyDistributor(Entity entity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("ModifyDistributor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", entity.Id);
                    command.Parameters.AddWithValue("@Company", entity.Company);
                    command.Parameters.AddWithValue("@Phone", entity.Phone);
                    command.Parameters.AddWithValue("@Representative", entity.Representative);
                    command.Parameters.AddWithValue("@Email", entity.Email);
                    command.Parameters.AddWithValue("@City", entity.City);
                    command.Parameters.AddWithValue("@Adress", entity.Adress);
                    command.Parameters.AddWithValue("@Transport", entity.Transport);

                    command.ExecuteNonQuery();
                    return entity;
                }
            }

        }
    }
}
