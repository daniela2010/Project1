using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class WishList
    {
        public static void AddWishList(int P, string user)
        {
            string com = "insert into WishList (Product,Username) VALUES (" + P + ",'" + user + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallProduct(string username)
        {
            string com = "SELECT Product from WishList Where Username='" + username+"'";
            return oledbhelper.GetTable(com);
        }
        
  
        //public static DataTable getByDate(DateTime date)
        //{
        //    string com = "select * from Lessons where LessonsDate='" + date + "'";
        //    return oledbhelper.GetTable(com);
        //}
        public static DataTable DeleteProduct(int p, string username)
        {
            string com = "delete from WishList where Username '" + username + "' and Product ="+p+"";
            return oledbhelper.GetTable(com);
        }
    }
}
