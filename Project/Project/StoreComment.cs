using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class StoreComment
    {
        public static void addComment(int Scode, string user, int rate, string comment, int type, string date)
        {
            string com = "insert into Scomment (Scode,Username,Srate,Comment,Type,dateC) VALUES (" + Scode + ",'" + user + "'," + rate + ",'" + comment + "'," + type + ", '" + date + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable updateShopCode(int Scode)
        {
            string com = "update Scomment set Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByShopCode(int Scode)
        {
            string com = "SELECT Scomment.Scode, Scomment.Username, Scomment.Srate, Scomment.Comment, Scomment.Type, Scomment.Ccode, Scomment.dateC, Typee.Description FROM Typee INNER JOIN Scomment ON Typee.Tcode = Scomment.Type WHERE Scomment.Scode =" + Scode + " ORDER BY Scomment.dateC ";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByShopType(int Scode, int t)
        {
            string com = "SELECT Scomment.Scode, Scomment.Username, Scomment.Srate, Scomment.Comment, Scomment.Type, Scomment.Ccode, Scomment.dateC, Typee.Description FROM Typee INNER JOIN Scomment ON Typee.Tcode = Scomment.Type WHERE Scomment.Scode=" + Scode + " AND(Scomment.Type)=" + t + "";
            //string com = "SELECT Scomment.Scode, Scomment.Username, Scomment.Srate, Scomment.Comment, Scomment.Type, Scomment.Ccode, Scomment.dateC, Typee.Description FROM Typee INNER JOIN Scomment ON Typee.Tcode = Scomment.Type WHERE WHERE Scomment.Scode=" + Scode + " AND(Scomment.Type=" + t + ") ORDER BY Scomment.dateC ";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByShopName(string n)
        {
            string com = "select * from Scomment where Sname='" + n + "'";
            return oledbhelper.GetTable(com);
        }
        public static int Getnumofcommments(int code)
        {
            string com = "select * from Scomment Where Scode = " + code + "";
            DataTable dt = oledbhelper.GetTable(com);
            return dt.Rows.Count;
        }
        public static DataTable getByUserName(string user)
        {
            string com = "SELECT Scomment.Scode, Scomment.Username, Scomment.Srate, Scomment.Comment, Scomment.Type,Scomment.Ccode,Scomment.dateC, Stores.Sname, Typee.Description FROM Typee INNER JOIN (Stores INNER JOIN Scomment ON Stores.Scode = Scomment.Scode) ON Typee.Tcode = Scomment.Type WHERE Scomment.Username ='" + user + "' ORDER BY Scomment.dateC";
            return oledbhelper.GetTable(com);
        }

        public static string getCommentByCode(int code)
        {
            string com = "select Comment from Scomment where Ccode=" + code + "";
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return (dr["Comment"].ToString());
            }
            return "";

        }
        public static int getAVGRate(int code)
        {
            string com = "SELECT Stores.Scode, Avg(Scomment.Srate) AS AvgSrate FROM Stores INNER JOIN Scomment ON Stores.Scode = Scomment.Scode GROUP BY Stores.Scode HAVING Stores.Scode=" + code + "";
            DataTable dt = oledbhelper.GetTable(com);
            if(dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return Convert.ToInt32(Double.Parse(dr["AvgSrate"].ToString()));
            }
            return -1;
        }
        public static void DeleteScomment(int code)
        {
           string com= "Delete from Scomment where Ccode=" + code + "";
            oledbhelper.Execute(com);
        }
    }
}
