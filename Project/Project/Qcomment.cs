using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class Qcomment
    {
        public static void addQComment(int Qcode, string user, string comment)
        {
            string com = "insert into Qcomment (Qcode,Username,comment) VALUES (" + Qcode + ",'" + user + "','" + comment + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getByUser(string name)
        {
            string com = "select * from Qcomment where Username='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQcode(int Qcode)
        {
            string com = "select * from Qcomment where Qcode=" + Qcode + "";
            return oledbhelper.GetTable(com);
        }

        public static void DeleteComment(int code)
        {
            string com = "delete from Qcomment where QCcode=" + code + "";
            oledbhelper.Execute(com);
        }
    }
}
