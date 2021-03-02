using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Qcomment
    {
        public static void addQComment(int Qcode, string user, string comment)
        {
            string com = "insert into Qcomment (Qcode,Username,comment) VALUES (" + Qcode + ",'" + user + "','" + comment + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallComments()
        {
            string com = "select * from Qcomment";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updateComment(string c)
        {
            string com = "update Qcomment set comment=" + c + "";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByUser(string name)
        {
            string com = "select * from Qcomment where Username='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQcode(int Qcode)
        {
            string com = "select * from Qcomment where Qcode='" + Qcode + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByComment(string c)
        {
            string com = "select * from Qcomment where comment=" + c + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQCcode(string c)
        {
            string com = "select * from Qcomment where QCcode=" + c + "";
            return oledbhelper.GetTable(com);
        }
      
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeleteComment(int code)
        {
            string com = "delete from Qcomment where QCcode" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
