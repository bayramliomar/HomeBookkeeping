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
   public class IstifadeciORM: ORMBase<Istifadeci>
    {
        public static Istifadeci aktivUser;
        public Istifadeci UserCatch(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_UserCatch", Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciAd", i.istifadeciAd);
            da.SelectCommand.Parameters.AddWithValue("@sifre", i.sifre);
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            Istifadeci aktiv = new Istifadeci();
            foreach (DataRow dr in dt.Rows )
            {
                aktiv.ID = (int)dr["ID"];
                aktiv.istifadeciAd = dr["istifadeciAd"].ToString();
                aktiv.sifre = dr["sifre"].ToString();
            }
            return aktiv;
        }
        public DataTable SelectAccountName(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciAd_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
