using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Project
{
    public class SigninMethods
    {
        public static void addUser(string Name, string Password, int Rank, string first, string last)
        {
            string com = "insert into Users ([Username],[Password],Rank,Firstname,Lastname) VALUES ('" + Name + "','" + Password + "'," + Rank + ",'"+ first+ "', '" + last +"')";
            oledbhelper.Execute(com);
        }
        //public static DataTable updatePassword(string pass)
        //{
        //    string com = "update Users set Password='" + pass + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable getByUserName(string Name)
        {
            string com = "select * from Users where Username='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByFirstName(string Name)
        {
            string com = "select * from Users where Firstname='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBLastName(string Name)
        {
            string com = "select * from Users where Lastname='" + Name + "'";
             return oledbhelper.GetTable(com);
            
        }
        public static string getPassword(string UserName)
        {
            string com = "select [Password] from Users where Username = '" + UserName + "'";
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr[0].ToString();
            }
            return null;

        }
 
        public static void DeleteUserName(string Name)
        {
            string com = "delete from Users where Username='" + Name + "'";
            oledbhelper.Execute(com);
        }
        public static bool IsExist(string user)
        {
            string com = "select * from Users where Username = '" + user + "'";
            DataTable dt = oledbhelper.GetTable(com);
            if(dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        public static string getRankByName(String name)
        {
            string com = "SELECT Rank FROM Users WHERE Username = '" + name + "'";
            DataTable TE = oledbhelper.GetTable(com);
            if (TE.Rows.Count > 0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["Rank"].ToString());
            }
            return "";
        }
    }
}
