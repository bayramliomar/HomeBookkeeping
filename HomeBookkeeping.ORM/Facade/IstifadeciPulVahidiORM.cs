using HomeBookkeeping.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Facade
{
   public class IstifadeciPulVahidiORM:ORMBase<IstifadeciPulVahidi>
    {
        public DataTable Select(IstifadeciPulVahidi ipv)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciPulVahidi_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", ipv.istifadeciid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Insert(IstifadeciPulVahidi ipv)
        {
            SqlCommand cmd = new SqlCommand("prc_IstifadeciPulVahidi_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pulVahidiid", ipv.pulVahidiid);
            return Tools.ExecuteNonQuery(cmd);

        }
    }
}
