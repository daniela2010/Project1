using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Quser
    {
        public static void addQuestion(string User, int day, string Question, int Scode, int Qcode)
        {
            string com = "insert into Quser (Username,Day,Question,Scode,Qcode) VALUES ('" + User + "'," + day + ",'" + Question + "'," + Scode + "," + Qcode + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallQuestion()
        {
            string com = "select * from Quser";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updateUser(string user)
        {
            string com = "update Quser set UserName='" + user + "'";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByUser(string name)
        {
            string com = "select * from Quser where Username='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQcode(int Qcode)
        {
            string com = "select * from Quser where Qcode=" + Qcode + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQuestion(string Q)
        {
            string com = "select * from Quser where Question='" + Q + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int num)
        {
            string com = "select * from Quser where Scode=" + num + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByDate(DateTime date)
        {
            string com = "select * from Quser where Day='" + date + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable DeleteQuser(int code)
        {
            string com = "delete from Quser where Comment'" + code + "'";
            return oledbhelper.GetTable(com);
        }
    }
}
