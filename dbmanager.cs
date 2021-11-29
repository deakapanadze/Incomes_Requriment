using InventoryManagement.Models;
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


        //შესყიდვების დამატების მეთოდი

        public void AddIcome(Income I)
        {
            SqlCommand cmd = new SqlCommand("AddIcome");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RequestId", I.RequestId);
            //cmd.Parameters.AddWithValue("@UserName", I.UserName);
            cmd.Parameters.AddWithValue("@DateCreated", I.DateCreated);


            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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



        //public Request GetReqById(int Id)
        //{
        //    Request req = new Request();
        //    SqlCommand cmd = new SqlCommand("[dbo].[GetReqById]");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@Id", Id);

        //    using (SqlConnection conn = new SqlConnection(Purchase))
        //    {
        //        cmd.Connection = conn;
        //        conn.Open();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                req.Id = Convert.ToInt32(reader["Id"]);

        //                req.Quantity = Convert.ToInt32(reader["Quantity"]);
        //                // joinp.UserId = Convert.ToInt32(reader["UserId"]);
        //                req.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
        //                req.Description = Convert.ToString(reader["Description"]);
        //                req.CategoryName = Convert.ToString(reader["CategoryName"]);
        //                req.StructureName = Convert.ToString(reader["StructureName"]);
        //                req.IsDone = Convert.ToBoolean(reader["isDone"]);

        //            }
        //            reader.Close();
        //        }
        //        return req;
        //    }
        //}


        public List<Stock> GetStockOfItems()
        {
            List<Stock> list = new List<Stock>();

            SqlCommand cmd = new SqlCommand("[GetStockOfItems]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Stock stock = new Stock();

                        stock.Id = Convert.ToInt32(reader["Id"]);
                        stock.DateOfOutItems = Convert.ToDateTime(reader["DateOfOutItems"]);
                        stock.UserName = Convert.ToString(reader["UserName"]);
                        stock.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        stock.Description = Convert.ToString(reader["Description"]);
                        stock.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stock.Quantity = Convert.ToInt32(reader["Quantity"]);
                        stock.StructureID = Convert.ToInt32(reader["StructureID"]);
                        stock.StructureName = Convert.ToString(reader["StructureName"]);
                        stock.CategoryName = Convert.ToString(reader["CategoryName"]);


                        list.Add(stock);

                    }
                    reader.Close();
                }

                return list;
            }
        }


    }
}
