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
/// Summary description for updateInfo
/// </summary>
public class updateInfo
{
    string _ipAddress;
    string _modifyBy;
    string _modifiedDate;
    string _modifyType;
    string _city;
    string _country;
    int _modifyId;
    string _fullName;
    string _chineseName;

    public string IPAddress { get { return _ipAddress; } set { _ipAddress = value; } }
    public string ModifyBy { get { return _modifyBy; } set { _modifyBy = value; } }
    public string ModiedDate { get { return _modifiedDate; } set { _modifiedDate = value; } }
    public string ModifyType { get { return _modifyType; } set { _modifyType = value; } }
    public int ModifyId { get { return _modifyId; } set { _modifyId = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string Country { get { return _country; } set { _country = value; } }
    public string FullName { get { return _fullName; } set { _fullName = value; } }
    public string ChineseName { get { return _chineseName; } set { _chineseName = value; } }

    public void AddUpdateInfo()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddUpdateInfo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@updateInfoId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ipAddress", SqlDbType.VarChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = IPAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedBy", SqlDbType.NVarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifyBy;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.NVarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedType", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifyType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifyId;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

}