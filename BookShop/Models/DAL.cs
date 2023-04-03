using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Ajax.Utilities;

namespace BookShop.Models
{
    public class DAL
    {
       static string _con = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        DataSet dt = new DataSet();
          SqlConnection con = new SqlConnection(_con);
        public DataSet dbgetlogin(string name, string password)
        {
            

                con.Open();
                SqlCommand cmd = new SqlCommand("SP_LOGIN", con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@passord", password);
                cmd.Parameters.Add("@res", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                ada.Fill(dt);
                int contractID = Convert.ToInt32(cmd.Parameters["@res"].Value);
                con.Close();
                // Session["FirstName"] = "";
                return dt;
            }
           
            
            
            
        
        
        

    }
}