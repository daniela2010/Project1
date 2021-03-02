using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Ages
    {
        public static void addAge(int Scode, string type)
        {
            string com = "insert into Ages (Scode,type) VALUES (" + Scode + ",'" + type + "')";
            oledbhelper.Execute(com);
        }
       
        public static DataTable updateScode(int c)
        {
            string com = "update Ages set Scode=" + c + "";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByTyper(string t)
        {
            string com = "select * from Ages where Type='" + t + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int Scode)
        {
            string com = "select * from Ages where Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
        

        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        
    }
}
