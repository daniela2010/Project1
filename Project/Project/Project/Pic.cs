using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Pic
    {
        public static void addComment(int Scode, string Pname, int Pcode)
        {
            string com = "insert into Pic (Scode,Pname,Pcode) VALUES (" + Scode + ",'" + Pname + "'," + Pcode + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallPics()
        {
            string com = "select * from Pic";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePCode(int code)
        {
            string com = "update Pic set Pcode=" + code + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int Scode)
        {
            string com = "select * from Pic where Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPname(string name)
        {
            string com = "select * from Pic where Pname='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPcode(int code)
        {
            string com = "select * from Pic where Pcode=" + code + "";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeletePic(int code)
        {
            string com = "delete from Pic where Pcode" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
