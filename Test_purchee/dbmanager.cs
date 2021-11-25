using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_purchee.Models;
using Test_purchee.Models.JoinModels;

namespace Test_purchee
{

    public class dbmanager
    {
        public static string Purchase = ConfigurationManager.ConnectionStrings["Purchase"].ConnectionString;
        public static string TsgDB = ConfigurationManager.ConnectionStrings["TsgDB"].ConnectionString;


        //მოთხოვნის წამოღების მეთოდი
        public List<Incomes> GetInComes()
        {
            List<Incomes> list = new List<Incomes>();

            SqlCommand cmd = new SqlCommand("[GetInComes]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Incomes In_Come = new Incomes();



                        In_Come.ID = Convert.ToInt32(reader["Id"]);
                        In_Come.InventoryId = Convert.ToInt32(reader["InventoryId"]);
                        In_Come.Quantity = Convert.ToInt32(reader["Quantity"]);
                        In_Come.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                        In_Come.Date = Convert.ToDateTime(reader["Date"]);
                        In_Come.UserId = Convert.ToInt32(reader["UserId"]);
                        In_Come.RequirementId = Convert.ToInt32(reader["RequirementId"]);


                        list.Add(In_Come);

                    }
                    reader.Close();
                }
                return list.ToList();
            }
        }



        //შესყიდვების წამოღების მეთოდი

        public List<Requirements> GetRequirements()
        {
            List<Requirements> Requirements = new List<Requirements>();

            SqlCommand cmd = new SqlCommand("[GetRequirements]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Requirements Rqrnts = new Requirements();



                        Rqrnts.Id = Convert.ToInt32(reader["Id"]);
                        Rqrnts.InventoryId = Convert.ToInt32(reader["InventoryId"]);
                        Rqrnts.Quantity = Convert.ToInt32(reader["Quantity"]);
                        Rqrnts.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                        //Rqrnts.UserId = Convert.ToInt32(reader["UserId"]);
                        Rqrnts.Date = Convert.ToDateTime(reader["Date"]);
                        Rqrnts.Description = Convert.ToString(reader["Description"]);


                        Requirements.Add(Rqrnts);

                    }
                    reader.Close();
                }

                return Requirements.ToList();
            }
        }


        // ინვენტარის დამატების მეთოდი

        public void AddInventary(Inventories test)
        {
            SqlCommand cmd = new SqlCommand("AddInventary");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", test.Name);

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteScalar();
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

        public List<joinpurchase> GETpurchase()
        {
            List<joinpurchase> list = new List<joinpurchase>();

            SqlCommand cmd = new SqlCommand("[GETpurchase]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        joinpurchase joinp = new joinpurchase();



                        joinp.Id = Convert.ToInt32(reader["Id"]);
                        joinp.Quantity = Convert.ToInt32(reader["Quantity"]);
                        // joinp.UserId = Convert.ToInt32(reader["UserId"]);
                        joinp.Date = Convert.ToDateTime(reader["Date"]);
                        joinp.Description = Convert.ToString(reader["Description"]);
                        joinp.Name = Convert.ToString(reader["Name"]);
                        joinp.NameInv = Convert.ToString(reader["NameInv"]);



                        list.Add(joinp);

                    }
                    reader.Close();
                }
                return list.ToList();
            }
        }



        //req დამატება 

        public void AddRequirements(Requirements test)
        {
            SqlCommand cmd = new SqlCommand("AddRequirements");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@InventoryId", test.InventoryId);
            cmd.Parameters.AddWithValue("@DepartmentID", test.DepartmentID);
            cmd.Parameters.AddWithValue("@Quantity", test.Quantity);
            cmd.Parameters.AddWithValue("@Date", test.Date);
            cmd.Parameters.AddWithValue("@Description", test.Description);


            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
            }
        }

        // ინვენტარის წამოღება
        public List<Inventories> Getinventary()
        {
            List<Inventories> list = new List<Inventories>();

            SqlCommand cmd = new SqlCommand("[Getinventary]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inventories inve = new Inventories();



                        inve.Id = Convert.ToInt32(reader["Id"]);
                        inve.Name = Convert.ToString(reader["Name"]);



                        list.Add(inve);

                    }
                    reader.Close();
                }
                return list.ToList();
            }
        }


        // განყოფილებების წამოღება 
        public List<Departments> GetDepartaments2()
        {
            List<Departments> list = new List<Departments>();

            SqlCommand cmd = new SqlCommand("[GetDepartaments2]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Departments Depart = new Departments();
                        Depart.Id = Convert.ToInt32(reader["Id"]);
                        Depart.Name = Convert.ToString(reader["Name"]);
                        Depart.ParentID = Convert.ToInt32(reader["ParentID"]);



                        list.Add(Depart);

                    }
                    reader.Close();
                }
                return list.ToList();
            }
        }



    }
}
