using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class bl
    {
        //public static DataTable sfdsfds(int scode)
        //{
        //    string s = " SELECT Stores.Scode, Scomment.Scode, Users.Password FROM Users INNER JOIN(Stores INNER JOIN Scomment ON Stores.Scode = Scomment.Scode) ON Users.Username = Scomment.Username WHERE Stores.Scode = " + scode;
        //    return oledbhelper.GetTable(s);
        //}
        //public static int AvgRate(int Scode)
        //{
        //    string com = "select AVG (Srate) From Scomment Where Scode ="+Scode+"";
        //    DataTable dt = oledbhelper.GetTable(com);
        //    return int.Parse(com);
        //}
        public static void GetCbyUser(string name)
        {
            string com = "SELECT Comment FROM Scomment Where Username='" + name + "'";
            DataTable dt = oledbhelper.GetTable(com);
            int rows = dt.Rows.Count;            
            if (rows > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    DataRow dr = dt.Rows[i];
                    Console.WriteLine(dr["comment"].ToString());                    
                }
                
            }
            else
                Console.WriteLine("no comments"); 
            
        }
        public static int CountProduct(int Scode)
        {
            string com = "SELECT Stores.Scode, Count(Product.Scode) AS CountOfScode FROM Stores INNER JOIN Product ON Stores.Scode = Product.Scode GROUP BY Stores.Scode HAVING Stores.Scode = " + Scode;
            DataTable dt = oledbhelper.GetTable(com);
            if(dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["CountOfScode"].ToString());
            }
            return -1;
        }
        //public static DataTable GetCbyQ(int code)
        //{
        //    string com = "SELECT Users.Username, Scomment.Scode FROM Users INNER JOIN Scomment ON Users.Username = Scomment.Username WHERE Users.Username = " + code;

        //}
    }
}
