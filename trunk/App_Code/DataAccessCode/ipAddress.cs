using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for ipAddress
/// </summary>
public class ipAddress
{
    string _ipAddress;
    string _location;

    public string IPAddress { get { return _ipAddress; } set { _ipAddress = value; } }
    public string location { get { return _location; } set { _location = value; } }

    public void AddIPAddress()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddUpdateIPAddress", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@updateInfoId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ipAddress", SqlDbType.VarChar,30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = IPAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@location", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = location;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }
}