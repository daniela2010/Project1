using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Project
{
    class SigninMethods
    {
        public static void addUser(string Name, string Password, int Rank)
        {
            string com = "insert into SigninMethods (Username,Password,Rank) VALUES (" + Name + ",'" + Password + "','" + Rank + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallUser()
        {
            string com = "select * from SigninMethods";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePassword(string pass)
        {
            string com = "update SignIn set Password=" + pass + "";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByUserName(string Name)
        {
            string com = "select * from SigninMethods where Username='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPassword(string Pass)
        {
            string com = "select * from SigninMethods where Password='" + Pass + "'";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByRank(int who)
        //{
        //    string com = "select * from SigninMethods where Rank=" + who + "";
        //    return oledbhelper.GetTable(com);
        //}
       
        public static DataTable DeleteSigninMethods(string Name)
        {
            string com = "delete from Assesment where Username" + Name + "";
            return oledbhelper.GetTable(com);
        }
    }
}
