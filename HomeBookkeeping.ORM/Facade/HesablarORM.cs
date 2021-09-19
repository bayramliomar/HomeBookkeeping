using HomeBookkeeping.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HomeBookkeeping.ORM.Facade
{
    public class HesablarORM : ORMBase<Hesablar>
    {   
        public DataTable Select(Hesablar h,string CommandText)
        {
            SqlDataAdapter da = new SqlDataAdapter(CommandText, Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", h.istifadeciid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //public DataTable SelectCombobox(Hesablar h)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("prc_HesablarCombobox_Select", Tools.Baglanti);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.AddWithValue("@istifadeciid", h.istifadeciid);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}
    }
}
