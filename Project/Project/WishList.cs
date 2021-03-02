using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class WishList
    {
        public static void AddWishList(int Scode, string user)
        {
            string com = "insert into WishList (Scode ,Username) VALUES (" + Scode + ",'" + user + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallStores(string username)
        {
            string com = "SELECT WishList.Scode, WishList.Username, Stores.Sname, Stores.Srate, Stores.Slink FROM Stores INNER JOIN WishList ON Stores.Scode = WishList.Scode WHERE WishList.Username='" + username + "'";
            //string com = "SELECT Store from WishList Where Username='" + username+"'";
            return oledbhelper.GetTable(com);
        }
        public static bool IsExist(int Store, string username)
        {
            string com = "select * FROM WishList WHERE WishList.Scode=" + Store + " AND(WishList.Username)='" + username + "'"; ;
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static void DeleteFromWishList(int Store, string username)
        {
            string com = "DELETE WishList.Scode, WishList.Username FROM WishList WHERE WishList.Scode=" + Store + " AND(WishList.Username)='" + username + "'";
            oledbhelper.Execute(com);

        }
    }
}
