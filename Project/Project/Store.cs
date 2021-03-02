using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
   public class Store
    {
        public static void addStore(string Shop, int rate, string aprove)
        {
            string com = "insert into Stores (Sname,Srate,IsAprove) VALUES ('" + Shop + "'," + rate + ",'" + aprove + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallShops()
        {
            string com = "SELECT Stores.Sname, Stores.Srate, Stores.Slink, Stores.Scode, Stores.IsAprove FROM Stores  ORDER BY Stores.Srate DESC";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getAproveShops()
        {
            string aprove = "yes";
            string com = "SELECT Stores.Sname, Stores.Srate, Stores.Slink, Stores.Scode, Stores.IsAprove FROM Stores WHERE Stores.IsAprove='" + aprove + "' ORDER BY Stores.Srate DESC";
             return oledbhelper.GetTable(com);
        }
        public static DataTable getNotAproveShops()
        {
            string aprove = "no";
            string com = "SELECT Stores.Sname, Stores.Srate, Stores.Slink, Stores.IsAprove, Stores.Scode FROM Stores WHERE Stores.IsAprove='" + aprove + "'";
            return oledbhelper.GetTable(com);
        }
        public static void updateShoprate(int Scode, int rate)
        {
            string com = "UPDATE Stores SET Stores.Srate =" + rate + " WHERE Stores.Scode =" + Scode + "";
            oledbhelper.Execute(com);
        }
        public static int GetStoreAmount()
        {
            string aprove = "yes";
            string com = "SELECT * FROM Stores where Stores.IsAprove = '" + aprove + "'";
            DataTable dt = oledbhelper.GetTable(com);
            return dt.Rows.Count;
        }
        public static DataTable getByScode(int Scode)
        {
            string com = "select * from Stores where Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
      
        public static DataTable getBySname(string name)
        {
            string com = "select * from Stores where Sname='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static int getCodeByName(string name)
        {
            string com = "select Scode from Stores where Sname='" + name + "'";
            DataTable dt = oledbhelper.GetTable(com);
            if(dt.Rows.Count >0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["Scode"].ToString());
            }
            return -1;

        }
        public static DataTable getBySrate(int num)
        {
            string com = "select * from Scomment where Srate=" + num + "";
            return oledbhelper.GetTable(com);
        }
        public static void DeleteShop(int code)
        {
            string com = "delete from Stores where Scode=" + code + "";
           oledbhelper.Execute(com);
        }
        public static bool IsExist(string name)
        {
            string com = "select * from Stores where Sname = '" + name + "'";
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static string getRateByCode(int code)
        {
            string com = "SELECT Srate FROM Stores WHERE Scode = " + code + "";
            DataTable TE = oledbhelper.GetTable(com);
            if(TE.Rows.Count>0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["Srate"].ToString());
            }
            return "";
        }
        public static string getNameByCode(int code)
        {
            string com = "SELECT Sname FROM Stores WHERE Scode = " + code + "";
            DataTable TE = oledbhelper.GetTable(com);
            if (TE.Rows.Count > 0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["Sname"].ToString());
            }
            return "";
        }
        public static string getAproveByCode(int code)
        {
            string com = "SELECT Stores.IsAprove FROM Stores WHERE Stores.Scode = " + code + "";
            DataTable TE = oledbhelper.GetTable(com);
            if (TE.Rows.Count > 0)
            {
                DataRow dr = TE.Rows[0];
                return (dr["IsAprove"].ToString());
            }
            return "";
        }
        public static void UpdateISAprove(int code)
        {
            string aprove = "yes";
            string com = "UPDATE Stores SET Stores.IsAprove ='" + aprove + "' WHERE Stores.Scode = " + code + "";
            oledbhelper.Execute(com);
        }
        public static DataTable Updateate(int code, int Srate)
        {
            string com = "UPDATE Stores SET Stores.Srate =" + Srate + " WHERE Stores.Scode=" + code + "";
            return oledbhelper.GetTable(com);
        }
    }
}
