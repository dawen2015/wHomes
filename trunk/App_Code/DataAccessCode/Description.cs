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
/// Summary description for Description
/// </summary>
public class Description
{
    string _description;
    int _descriptionID;
    int _sourceId;
    int _descriptionType;

    public string Detail { get { return _description; } set { _description = value; } }
    public int DescriptionId { get { return _descriptionID; } set { _descriptionID = value; } }
    public int SourceId { get { return _sourceId; } set { _sourceId = value; } }
    public int DescriptionType { get { return _descriptionType; } set { _descriptionType = value; } }

    public void UpdateDescription()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateDescription", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@description", SqlDbType.NChar, 4000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Detail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@sourceId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SourceId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@descriptionType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DescriptionType;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
        }
    }

    public void AddADescription()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddDescription", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@descriptionId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 4000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Detail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@sourceId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SourceId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@descriptionType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DescriptionType;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }


}