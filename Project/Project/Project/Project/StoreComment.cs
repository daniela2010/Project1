using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class StoreComment
    {
        public static void addComment(int Scode, string user, int rate, string comment, string type)
        {
            string com = "insert into StoreComment (Scode,Username,Srate,Comment, Type) VALUES (" + Scode + ",'" + user + "','" + rate + "'," + comment + "'," + type + "'," + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallComment()
        {
            string com = "select * from Scomment";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updateShopCode(int Scode)
        {
            string com = "update Scomment set Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByShopCode(int Scode)
        {
            string com = "select * from Scomment where Scode='" + Scode + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByCcode(int Ccode)
        {
            string com = "select * from Scomment where Ccode='" + Ccode + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByUserName(string user)
        {
            string com = "select * from Scomment where Username=" + user + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBySrate(int num)
        {
            string com = "select * from Scomment where Srate=" + num + "";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeleteScomment(int code)
        {
            string com = "delete from Scomment where Ccode" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
