﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FinalProject_OOP
//{
//    public class DataProvider
//    {
//        private string connectionSTR = "Data Source=DINHKHOA;Initial Catalog=COFFEE;Integrated Security=True;Trust Server Certificate=True";
//        public DataTable ExecuteQuery(string query, object[] parameter = null)
//        {
//            DataTable data = new DataTable();

//            using (SqlConnection connection = new SqlConnection(connectionSTR))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand(query, connection);

//                if (parameter != null)
//                {
//                    string[] listPara = query.Split(' ');
//                    int i = 0;
//                    foreach (string item in listPara)
//                    {
//                        if (item.Contains('@'))
//                        {
//                            command.Parameters.AddWithValue(item, parameter[i]);
//                            i++;
//                        }
//                    }

//                    data = command.ExecuteNonQuery();

//                    connection.Close();
//                }
//                return data;
//            }

//        }
//        public int ExecuteNonQuery(string query, object[] parameter = null)
//        {
//            int data = 0;

//            using (SqlConnection connection = new SqlConnection(connectionSTR))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand(query, connection);

//                if (parameter != null)
//                {
//                    string[] listPara = query.Split(' ');
//                    int i = 0;
//                    foreach (string item in listPara)
//                    {
//                        if (item.Contains('@'))
//                        {
//                            command.Parameters.AddWithValue(item, parameter[i]);
//                            i++;
//                        }
//                    }

//                    data = command.ExecuteNonQuery();

//                    connection.Close();
//                }
//                return data;
//            }

//        }

//        public object ExecuteScalar(string query, object[] parameter = null)
//        {
//            object data = 0;

//            using (SqlConnection connection = new SqlConnection(connectionSTR))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand(query, connection);

//                if (parameter != null)
//                {
//                    string[] listPara = query.Split(' ');
//                    int i = 0;
//                    foreach (string item in listPara)
//                    {
//                        if (item.Contains('@'))
//                        {
//                            command.Parameters.AddWithValue(item, parameter[i]);
//                            i++;
//                        }
//                    }

//                    data = command.ExecuteScalar();

//                    connection.Close();
//                }
//                return data;
//            }

//        }

//    }
//}
