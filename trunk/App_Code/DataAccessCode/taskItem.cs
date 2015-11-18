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
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for taskItem
/// </summary>
public class taskItem
{

    public int id { get; set; }
    public int taskID { get; set; }
    public string houseDate { get; set; }
    public string housetime { get; set; }
    public string houseAddress { get; set; }
    public string housePrice { get; set; }
    public int taskItemID { get; set; }

    public taskItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddATaskInfo()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddATaskItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@ID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskItemID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  taskItemID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = taskID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@houseDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = houseDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@housetime", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = housetime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@houseAddress", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = houseAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@housePrice", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = housePrice;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            id = int.Parse(cmd.Parameters["@ID"].Value.ToString());
        }
    }


}