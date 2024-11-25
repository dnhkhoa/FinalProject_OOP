//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing.Text;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text;
//using System.Data.SqlClient;
//namespace FinalProject_OOP
//{
//    public class Table
//    {
//        SqlConnection con = new SqlConnection("Data Source=DINHKHOA;Initial Catalog=COFFEE;Integrated Security=True;Trust Server Certificate=True");

//        public Table(int id, string name, string status)
//        {
//            this.ID = id;
//            this.Name = name;
//            this.Status = status;
//        }
//        private string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        private string status;
//        public string Status
//        {
//            get { return status; }
//            set { status = value; }
//        }

//        private int iD;
//        public int ID
//        {
//            get { return iD; }
//            set { iD = value; }
//        }
//    }
//    public class TableSet
//    {
//        private static TableSet instance;
//        public static TableSet Instance
//        {
//            get { if (instance == null) instance = new TableSet(); return TableSet.instance; }
//            private set { TableSet.instance = value; }
//        }
//        public List<Table> LoadTableList()
//        {
//            List<Table> list = new List<Table>();
//            DataTable data = DataProvider.Ins
            
//            return list;
//        }
//    }
//}