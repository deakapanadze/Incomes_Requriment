using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_purchee.Models;

namespace Test_purchee
{

    public class dbmanager
    {
        public static string Purchase = ConfigurationManager.ConnectionStrings["Purchase"].ConnectionString;
        public static string TsgDB = ConfigurationManager.ConnectionStrings["TsgDB"].ConnectionString;


        //შესყიდვების წამოღების მეთოდი
        public List<Income> GetIncomes()
        {
            List<Income> list = new List<Income>();

            SqlCommand cmd = new SqlCommand("[GetIncomes]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Income income = new Income();

                        income.ID = Convert.ToInt32(reader["Id"]);
                        income.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        income.Quantity = Convert.ToInt32(reader["Quantity"]);
                        income.StructureID = Convert.ToInt32(reader["StructureID"]);
                        income.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        income.UserName = Convert.ToString(reader["UserName"]);
                        income.RequestId = Convert.ToInt32(reader["RequestId"]);
                        income.CategoryName = Convert.ToString(reader["CategoryName"]);
                        income.StructureName = Convert.ToString(reader["StructureName"]);


                        list.Add(income);

                    }
                    reader.Close();
                }

                return list;
            }
        }




        // ინვენტარის დამატების მეთოდი

        public void AddCategory(Category c)
        {
            SqlCommand cmd = new SqlCommand("AddCategory");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", c.Name);

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        //დეპარტამენტების დამატება 

        //public void Adddepartament(Departments test)
        //{
        //    SqlCommand cmd = new SqlCommand("Adddepartament");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@NameDep", test.NameDep);

        //    using (SqlConnection conn = new SqlConnection(Purchase))
        //    {
        //        cmd.Connection = conn;
        //        conn.Open();
        //        cmd.ExecuteScalar();
        //        conn.Close();
        //    }
        //}

        // დაჯოინებულის წმაოღება

        public List<Request> GetRequests()
        {
            List<Request> list = new List<Request>();

            SqlCommand cmd = new SqlCommand("[GetRequests]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Request r = new Request();



                        r.Id = Convert.ToInt32(reader["Id"]);
                        r.Quantity = Convert.ToInt32(reader["Quantity"]);
                        // joinp.UserId = Convert.ToInt32(reader["UserId"]);
                        r.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        r.Description = Convert.ToString(reader["Description"]);
                        r.CategoryName = Convert.ToString(reader["CategoryName"]);
                        r.StructureName = Convert.ToString(reader["StructureName"]);
                        r.IsDone = Convert.ToBoolean(reader["isDone"]);



                        list.Add(r);

                    }
                    reader.Close();
                }
                return list;
            }
        }



        //req დამატება 

        public void AddRequirements(Request r)
        {
            SqlCommand cmd = new SqlCommand("AddRequest");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CategoryId", r.CategoryId);
            cmd.Parameters.AddWithValue("@StructureID", r.StructureID);
            cmd.Parameters.AddWithValue("@Quantity", r.Quantity);
            cmd.Parameters.AddWithValue("@DateCreated", r.DateCreated);
            cmd.Parameters.AddWithValue("@Description", r.Description);


            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // კატეგორიების წამოღება
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();

            SqlCommand cmd = new SqlCommand("[GetCategories]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category c = new Category();



                        c.Id = Convert.ToInt32(reader["Id"]);
                        c.Name = Convert.ToString(reader["Name"]);



                        list.Add(c);

                    }
                    reader.Close();
                }
                return list;
            }
        }


        // სტრუქტურების წამოღება 
        public List<Structure> GetStructures()
        {
            List<Structure> list = new List<Structure>();

            SqlCommand cmd = new SqlCommand("[GetStructures]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Structure Depart = new Structure();
                        Depart.Id = Convert.ToInt32(reader["Id"]);
                        Depart.Name = Convert.ToString(reader["Name"]);
                        Depart.ParentID = Convert.ToInt32(reader["ParentID"]);



                        list.Add(Depart);

                    }
                    reader.Close();
                }
                return list;
            }
        }



    }
}
