﻿using System;
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
            string com = "insert into Users (Username,[Password],[Rank]) VALUES ('" + Name + "','" + Password + "'," + Rank + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallUser()
        {
            string com = "select * from Users";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePassword(string pass)
        {
            string com = "update Users set Password=" + pass + "";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByUserName(string Name)
        {
            string com = "select * from Users where Username='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByPassword(string Pass)
        {
            string com = "select * from Users where Password='" + Pass + "'";
            return oledbhelper.GetTable(com);
        }
        //public static DataTable getByRank(int who)
        //{
        //    string com = "select * from SigninMethods where Rank=" + who + "";
        //    return oledbhelper.GetTable(com);
        //}
       
        public static DataTable DeleteSigninMethods(string Name)
        {
            string com = "delete from Users where Username'" + Name + "'";
            return oledbhelper.GetTable(com);
        }
    }
}
