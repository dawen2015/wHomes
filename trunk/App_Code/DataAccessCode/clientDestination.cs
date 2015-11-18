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
/// Summary description for clientDestination
/// </summary>
public class clientDestination
{
    string _city;
    int _agentId;
    string _arrivateDate;
    string _departDate;
    string _visitingDate;
    int _clientID;
    int _nthDestination;

    public string City { get { return _city; } set { _city = value; } }
    public int AgentId { get { return _agentId; } set { _agentId = value; } }
    public string ArrivateDate { get { return _arrivateDate; } set { _arrivateDate = value; } }
    public string DepartDate { get { return _departDate; } set { _departDate = value; } }
    public string VisitingDate { get { return _visitingDate; } set { _visitingDate = value; } }
    public int ClientID { get { return _clientID; } set { _clientID = value; } }
    public int NthDestination { get { return _nthDestination; } set { _nthDestination = value; } }

    public void AddDestinationInfo()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddDestinationInfo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@city", SqlDbType.NChar, 35);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@agentID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivateDate", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivateDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@departDate", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DepartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@visitingDate", SqlDbType.NChar, 55);
            parm.Direction = ParameterDirection.Input;
            parm.Value = VisitingDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@clientID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@nthDestination", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NthDestination;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

}