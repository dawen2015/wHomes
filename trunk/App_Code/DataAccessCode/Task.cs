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
/// Summary description for Task
/// </summary>
public class Task
{
    //
    // TODO: Add constructor logic here
    //
    #region "Member Variables"

    private int _taskId;
    private int _userId;
    private string _taskTitle;
    private string _taskDescription;
    private string _taskDate;
    private string _assignedAgentId;
    private int _clientId;
    private bool _closeHouse;
    private int _closeHouseAmount;
    private int _propertyId;
    private string _modifiedDate;
    private int _modifiedBy;
    private int _userRequestID;
    private string _tasksStatus;
    private string _agentUserName;
    private int _taskType;
    private string _taskUserFullName;
    private string _taskState;
    private int _taskTo;
    private int _taskFrom;
    private string _taskTypeName;
    private string _taskToName;
    private string _taskForName;

    #endregion

    #region "Properties"

    public string TaskForName { get { return _taskForName; } set { _taskForName = value; } }
    public string TaskToName { get { return _taskToName; } set { _taskToName = value; } }
    public string TaskTypeName { get { return _taskTypeName; } set { _taskTypeName = value; } }
    public int TaskTo { get { return _taskTo; } set { _taskTo = value; } }
    public int TaskFor { get { return _taskFrom; } set { _taskFrom = value; } }
    public string TaskState { get { return _taskState; } set { _taskState = value; } }
    public string TaskUserFullname { get { return _taskUserFullName; } set { _taskUserFullName = value; } }
    public int TaskType { get { return _taskType; } set { _taskType = value; } }
    public string AgentUserName  { get { return _agentUserName; } set { _agentUserName= value; } }
    public int UserRequestID { get { return _userRequestID; } set { _userRequestID = value; } }
    public string TaskStatus { get { return _tasksStatus; } set { _tasksStatus = value; } }
    public int TaskId { get { return _taskId; } set { _taskId = value; } }
    public int ClientId { get { return _clientId; } set { _clientId = value; } }
    public bool CloseHouse { get { return _closeHouse; } set { _closeHouse = value; } }
    public int CloseHouseAmount { get { return _closeHouseAmount; } set { _closeHouseAmount = value; } }
    public int PropertyId { get { return _propertyId; } set { _propertyId = value; } }

    public string TaskTitle { get { return _taskTitle; } set { _taskTitle = value; } }
    public string TaskDescription { get { return _taskDescription; } set { _taskDescription = value; } }
    public string TaskDate { get { return _taskDate; } set { _taskDate = value; } }
    public int UserId { get { return _userId; } set { _userId = value; } }
    
    public string dateItems {get; set;}
	public string timeItems {get; set;}
    public string addressItems {get; set;}
	public string priceItems {get; set;}
    public int numberofHouses { get; set; }

    #endregion

    public int ModifiedBy
    {
        get { return _modifiedBy; }
        set { _modifiedBy = value; }
    }

    public string ModifiedDate
    {
        get { return _modifiedDate; }
        set { _modifiedDate = value; }
    }

    public void Create()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("CreateATask", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@taskId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 2000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskDate", SqlDbType.VarChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usertId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedBy", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedBy;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.VarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@clientId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CloseHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closinghouseAmount", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CloseHouseAmount;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskType;
            cmd.Parameters.Add(parm);

             parm = new SqlParameter("@status", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskTo", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskTo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskFor", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskFor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userRequestID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserRequestID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dateItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = dateItems;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@timeItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = timeItems;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@addressItems", SqlDbType.VarChar, 800);
            parm.Direction = ParameterDirection.Input;
            parm.Value = addressItems;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@priceItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = priceItems;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofHouses", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = numberofHouses;
            cmd.Parameters.Add(parm);


            cmd.ExecuteNonQuery();
            TaskId = int.Parse(cmd.Parameters["@taskId"].Value.ToString());
        }
    }

    public void UpdateUserRequest()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateUserRequestToATask", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@taskId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userRequestID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserRequestID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value =TaskType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@status", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskStatus;
            cmd.Parameters.Add(parm);

             parm = new SqlParameter("@agentUserName", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentUserName;
            cmd.Parameters.Add(parm);
 

            cmd.ExecuteNonQuery();

        }

    }
    
    public void Update()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateATask", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@taskId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 2000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedBy", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedBy;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.VarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@clientId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CloseHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closinghouseAmount", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CloseHouseAmount;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@status", SqlDbType.NChar, 25);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskTo", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskTo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@taskFor", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TaskFor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userRequestID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserRequestID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dateItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = dateItems;
            cmd.Parameters.Add(parm);
                        
            parm = new SqlParameter("@timeItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = timeItems;
            cmd.Parameters.Add(parm);
                        
            parm = new SqlParameter("@addressItems", SqlDbType.VarChar, 800);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  addressItems;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@priceItems", SqlDbType.VarChar, 200);
            parm.Direction = ParameterDirection.Input;
            parm.Value = priceItems;
            cmd.Parameters.Add(parm);
                        
            parm = new SqlParameter("@numberofHouses", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = numberofHouses;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }
}