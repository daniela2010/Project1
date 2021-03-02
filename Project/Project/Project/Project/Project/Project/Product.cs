using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Product
    {
        public static void addProduct(int Scode, string Pname, string Ptype, int price)
        {
            string com = "insert into Pic (Scode,Pname,Ptype,Price) VALUES (" + Scode + ",'" + Pname + "','" + Ptype + "','" + price + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallProduct()
        {
            string com = "select * from Product";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePice(int p)
        {
            string com = "update Product set Price=" + p + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePname(string n)
        {
            string com = "update Product set Pname=" + n + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int Scode)
        {
            string com = "select * from Product where Scode='" + Scode + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPname(string name)
        {
            string com = "select * from Product where Pname=" + name + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPcode(int code)
        {
            string com = "select * from Product where Pcode=" + code + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByType(string t)
        {
            string com = "select * from Product where Ptype=" + t + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPrice(int p)
        {
            string com = "select * from Product where Price=" + p + "";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeleteProduct(int code)
        {
            string com = "delete from Product where Pcode" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
