using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    public class TypeStore
    {
        public static void addTypeStore(int Scode, int Typee)
        {
            string com = "insert into TypeStore (Scode,Typee) VALUES (" + Scode + "," + Typee + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getByType(int t)
        {
            string com = "select * from TypeStore where Typee=" + t + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByScode(int code)
        {
            string com = "SELECT TypeStore.Scode, TypeStore.Typee, Typee.Tcode FROM Typee INNER JOIN TypeStore ON Typee.Tcode = TypeStore.Typee WHERE TypeStore.Scode=" + code + "";
            //string com = "select * from TypeStore where Scode=" + code + "";
            return oledbhelper.GetTable(com);
        }
        public static void DeleteTypeS(int t)
        {
            string com = "delete from TypeStore where Typee =" + t + "";
            oledbhelper.Execute(com);
        }
        public static int GetnumofTypes(int code)
        {
            string com = "select * from TypeStore Where Scode = " + code + "";
            DataTable dt = oledbhelper.GetTable(com);
            return dt.Rows.Count;
        }
        public static DataTable GatTaypesStore(int code)
        {
           string com= " SELECT TypeStore.Typee, Typee.Description FROM Typee INNER JOIN TypeStore ON Typee.Tcode = TypeStore.Type WHERE TypeStore.Scode=" + code + "";
            return oledbhelper.GetTable(com);
        }
        public static bool IsExist(int Typee, int Scode)
        {
            string com = "SELECT TypeStore.Scode, TypeStore.Typee FROM TypeStore WHERE TypeStore.Typee=" + Typee + " AND TypeStore.Scode=" + Scode + "";
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
    

