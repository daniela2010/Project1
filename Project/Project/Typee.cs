using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class Typee
    {
        public static void addType(int Tcode, string des)
        {
            string com = "insert into Typee (Tcode,Description) VALUES (" + Tcode + ",'" + des + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallType()
        {
            string com = "select * from Typee";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByTcode(int t)
        {
            string com = "select * from Typee where Tcode=" + t + "";
            return oledbhelper.GetTable(com);
        }
        public static string getNameByCode(int code)
        {
            string com = "SELECT Description FROM Typee WHERE Tcode = " + code + "";
            DataTable TE = oledbhelper.GetTable(com);
            if (TE.Rows.Count > 0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["Description"].ToString());
            }
            return "";
        }
        public static string getCodeByname(String name)
        {
            string com = "SELECT Tcode FROM Typee WHERE Description ='" + name + "'";
            DataTable TE = oledbhelper.GetTable(com);
            if (TE.Rows.Count > 0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["Tcode"].ToString());
            }
            return "";
        }
        public static DataTable getByCommentByTYpe(int code)
        {
            string com = "SELECT Scomment.Scode, Scomment.Username, Scomment.Srate, Scomment.Comment, Scomment.Type, Scomment.Ccode, Scomment.dateC,Typee.Tcode, Typee.Description FROM Typee INNER JOIN Scomment (Typee INNER JOIN Scomment ON Typee.Tcode = Scomment.Type) ON Typee.Tcode = Scomment.Type WHERE Typee.Tcode= " + code + " ORDER BY Scomment.dateC";
            return oledbhelper.GetTable(com); ;
        }
        public static int GetTypeAmount()
        {
            string com = "SELECT * FROM Typee";
            DataTable dt = oledbhelper.GetTable(com);
            return dt.Rows.Count;
        }
        public static void DeleteType(int t)
        {
            string com = "delete from Typee where Tcode=" + t + "";
            oledbhelper.Execute(com);
        }
    }
}
