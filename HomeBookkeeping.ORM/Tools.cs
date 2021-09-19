using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace HomeBookkeeping.ORM
{
    public class Tools
    {
        //Singleton Pattern
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }

                return baglanti;
            }

        }
        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();
                return etk>0 ? true :false;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;

            }
            //catch (SqlException ex)
            //{

            //     if (ex.Number == 2627)
            //    {

            //    }
            //    return false;
            //}
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }
        public static void SelectInsertUpdateDelete<Tip>(SqlCommand cmd,KomutTip kt,Tip Ent)
        {
            Type getType = typeof(Tip);
            PropertyInfo[] properties = typeof(Tip).GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                string name = pi.Name;
                if((name.ToLower()=="id"|| name.ToLower()=="ıd") && kt == KomutTip.Insert)
                {
                    continue;
                }
                else if (kt == KomutTip.Delete && name.ToLower() != "id")
                {
                    continue;
                }
                object value = pi.GetValue(Ent);
                cmd.Parameters.AddWithValue("@" + name, value);

            }
        }

    }
}
