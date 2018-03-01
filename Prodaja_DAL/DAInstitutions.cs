using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodaja_DAL
{
    public class DAInstitutions
    {
        public static void GetInstitutions(DSInstitutions.InstitutionDataTable dtInstitutions)
        {
            dtInstitutions.Clear();
            SqlConnection cn = Connection.getConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_INSTITUTIONS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtInstitutions);        
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetAllTerritories(DSInstitutions.InstitutionDataTable dtTerritories)
        {
            dtTerritories.Clear();
            SqlConnection cn = Connection.getConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_InstitutionsTerritory_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtTerritories);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetInstitutionsByName(DSInstitutions.InstitutionDataTable dtInstitutions, string Grad, string Institucija, string x)
        {

            dtInstitutions.Clear();
            SqlConnection cn = Connection.getConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_INSTITUCIJE_PO_MJESTU_NAZIVU", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Grad != "")
                    cmd.Parameters.Add("@MJESTO", SqlDbType.NVarChar).Value = '%'+Grad+'%';

                if (Institucija != "")
                    cmd.Parameters.Add("@NAZIV", SqlDbType.NVarChar).Value = '%'+Institucija + '%';

                if (x != "")
                    cmd.Parameters.Add("@territory", SqlDbType.NVarChar).Value = x;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtInstitutions);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
