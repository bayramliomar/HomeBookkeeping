using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM
{
    public class ORMBase<TT> : IORM<TT> where TT : class
    {
        private string ClassName
        {
            get
            {
                return typeof(TT).Name;
            }
        }
       
        public DataTable Select()
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(TT entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.SelectInsertUpdateDelete<TT>(cmd, KomutTip.Insert, entity);
            return Tools.ExecuteNonQuery(cmd);

        }

        
        public bool Update(TT entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.SelectInsertUpdateDelete<TT>(cmd, KomutTip.Update, entity); 
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool Delete(TT entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.SelectInsertUpdateDelete<TT>(cmd, KomutTip.Delete, entity);
            return Tools.ExecuteNonQuery(cmd);
        }
       
    }
}