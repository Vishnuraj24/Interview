using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DataAccess_ADO
{
    public class DataAccess
    {
        private string _constr = "Server=LAPTOP-R713V9QM;Database=MyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public void GetData()
        {
            using (var conn = new SqlConnection(_constr))
            {
                conn.Open();
                string query = "Select Id, StudentName,FatherName,Age,Standard From Students";
                using (var cmd = new SqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID : {reader["Id"]}, Name: {reader["StudentName"]}, Fathername: {reader["FatherName"]} ");
                    }
                    reader.Close();
                }
            }
        }

        public void GetDataById(int id)
        {
            using (var conn = new SqlConnection(_constr))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_GetDataById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    //cmd.ExecuteNonQuery();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID : {reader["Id"]}, Name: {reader["StudentName"]}, Fathername: {reader["FatherName"]} ");
                    }
                    reader.Close();
                }

            }

        }

        public void GetCount()
        {
            using (var conn = new SqlConnection(_constr))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_GetCount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter outputcount = new SqlParameter("@count", System.Data.SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputcount);
                    cmd.ExecuteNonQuery();

                    int outputparam = (int)outputcount.Value;
                    Console.WriteLine($"Count: {outputparam}");

                }
            }
        }

        //usage of the transactions
        public void UpdateEmployee(int id, double sal)
        {
            string _connstr = _constr.Replace("MyDB", "Vishnu");
            using (var conn = new SqlConnection(_connstr))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                string updatequery = $"Update Employees set salary={sal} Where id = {id}";
                using (var cmd = new SqlCommand(updatequery, conn,transaction))
                {
                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        Console.WriteLine("Transaction committed successfully.");

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Transaction failed and rolled back.");
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
