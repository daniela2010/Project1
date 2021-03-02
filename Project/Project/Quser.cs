using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class Quser
    {
        public static void addQuestion(string User, string day, string Question, int Scode)
        {
            string com = "insert into Quser (Username,DateQ,Question,Scode) VALUES ('" + User + "','" +day + "','" + Question + "'," + Scode + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getByUser(string name)
        {
            string com = "SELECT Quser.Username, Quser.Scode, Quser.DateQ, Quser.Question, Quser.Qcode, Stores.Sname FROM Quser INNER JOIN Stores ON Quser.Scode = Stores.Scode WHERE Quser.Username ='" + name + "' ORDER BY Quser.DateQ";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByQcode(int Qcode)
        {
            string com = "select * from Quser where Qcode=" + Qcode + "";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByQuestion(string Q)
        //{
        //    string com = "select * from Quser where Question='" + Q + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable getByScode(int num)
        {
            string com = "select * from Quser where Scode=" + num + "";
            return oledbhelper.GetTable(com);
        }
        public static void DeleteQuser(int code)
        {
            string com = "delete from Quser where Question=" + code + "";
            oledbhelper.Execute(com);
        }
        
    }
}
