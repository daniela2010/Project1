using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Store
    {
        public static void addStore(string Shop, int rate)
        {
            string com = "insert into Stores (Sname,Srate) VALUES ('" + Shop + "'," + rate + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallShops()
        {
            string com = "select * from Stores";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updateShopCode(int Scode)
        {
            string com = "update Stores set Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int Scode)
        {
            string com = "select * from Stores where Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBySname(string name)
        {
            string com = "select * from Stores where Sname='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBySrate(int num)
        {
            string com = "select * from Stores where Srate=" + num + "";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeleteShop(int code)
        {
            string com = "delete from Stores where Scode" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
