using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Script.Services;
using System.Collections.Generic;
using System.Linq;
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
using System.Web.Security;
using System.Collections.Generic;
using System.Web.Script.Serialization;

public class PropertyData
{
    public string Make;
    public string Model;
    public int Year;
    public int Doors;
    public string Colour;
    public float Price;
}

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

[ScriptService]
public class propertyService : WebService
{

    public DataSet Properties = new DataSet();
    public List<Property> properties = new List<Property>();
    public string userType;
    public List<Task> allTasks = new List<Task>();

    List<PropertyData> PropertyData = new List<PropertyData>{

    new PropertyData{Make="Audi",Model="A4",Year=1995,Doors=5,Colour="Red",Price=2995f},
    new PropertyData{Make="Ford",Model="Focus",Year=2002,Doors=5,Colour="Black",Price=3250f},
    new PropertyData{Make="BMW",Model="5 Series",Year=2006,Doors=4,Colour="Grey",Price=24950f},
    new PropertyData{Make="Renault",Model="Laguna",Year=2000,Doors=5,Colour="Red",Price=3995f},
    new PropertyData{Make="Toyota",Model="Previa",Year=1998,Doors=5,Colour="Green",Price=2695f},
    new PropertyData{Make="Mini",Model="Cooper",Year=2005,Doors=2,Colour="Grey",Price=9850f},
    new PropertyData{Make="Mazda",Model="MX 5",Year=2003,Doors=2,Colour="Silver",Price=6995f},
    new PropertyData{Make="Ford",Model="Fiesta",Year=2004,Doors=3,Colour="Red",Price=3759f},
    new PropertyData{Make="Honda",Model="Accord",Year=1997,Doors=4,Colour="Silver",Price=1995f}
    };

    [WebMethod]
    public List<PropertyData> GetAllPropertyData()
    {

        return PropertyData;
    }


    [WebMethod]
    public List<PropertyData> GetPropertyDatasByDoors(int doors)
    {
        var query = from c in PropertyData
                    where c.Doors == doors
                    select c;
        return query.ToList();
    }


    [WebMethod]
    public string RetrieveAllTasks(string agentID, string userRole, string superUser, string showAgentInWebSite)
    {
        string userID = agentID;
        DataSet Users = new DataSet();

        // return showAgentInWebSite;
        String queryString = "";
        if (userRole == "admin" || superUser == "true")
        {
            if (showAgentInWebSite == "Yes")
            {
                queryString = "SELECT [taskID], [taskDate], [title], [userId], propertyID,(SELECT fullName FROM users  WHERE users.userId = tasks.userId) as fullName,[userRequestID] ,[taskType] ,[status] ,(SELECT [UserName]  FROM [wlglobalcorp].[dbo].[usersList] where userId = tasks.userId),[closinghouseAmount], (SELECT state FROM users WHERE tasks.userId = users.userId) as state,(SELECT [taskType]  FROM [wlglobalcorp].[dbo].[taskTypes] where taskTypeID = tasks.taskType),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskTo),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskFor)  FROM [tasks] order by taskID";
            }
            else
            {
                queryString = "SELECT [taskID], [taskDate], [title], [userId], propertyID,(SELECT fullName FROM users  WHERE users.userId = tasks.userId) as fullName,[userRequestID] ,[taskType] ,[status] ,(SELECT [UserName]  FROM [wlglobalcorp].[dbo].[usersList] where userId = tasks.userId),[closinghouseAmount], (SELECT state FROM users WHERE tasks.userId = users.userId) as state,(SELECT [taskType]  FROM [wlglobalcorp].[dbo].[taskTypes] where taskTypeID = tasks.taskType) ,(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskTo),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskFor)  FROM [tasks] where  taskfor =" + agentID + " or taskTo =" + agentID + " or userId =" + agentID + " or clientId in (SELECT [UserId] FROM [wlglobalcorp].[dbo].[Users] where assignedAdminID = " + agentID + ") order by taskID";
            }
        }
        else
        {
            // queryString = "SELECT [taskID], [taskDate], [title], [userId], propertyID,(SELECT fullName FROM users  WHERE users.userId = tasks.userId) as fullName,[userRequestID] ,[taskType] ,[status] ,(SELECT [UserName]  FROM [wlglobalcorp].[dbo].[usersList] where userId = tasks.userId),[closinghouseAmount], (SELECT state FROM users WHERE tasks.userId = users.userId) as state,(SELECT [taskType]  FROM [wlglobalcorp].[dbo].[taskTypes] where taskTypeID = tasks.taskType),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskTo),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskFor)   FROM [tasks] where taskfor =" + agentID + " or taskTo =" + agentID + " or userId =" + agentID + " or clientId in (SELECT [UserId] FROM [wlglobalcorp].[dbo].[Users] where  assignedAgentID = " + agentID + ") order by taskID";
            queryString = "SELECT [taskID], [taskDate], [title], [userId], propertyID,(SELECT fullName FROM users  WHERE users.userId = tasks.userId) as fullName,[userRequestID] ,[taskType] ,[status] ,(SELECT [UserName]  FROM [wlglobalcorp].[dbo].[usersList] where userId = tasks.userId),[closinghouseAmount], (SELECT state FROM users WHERE tasks.userId = users.userId) as state,(SELECT [taskType]  FROM [wlglobalcorp].[dbo].[taskTypes] where taskTypeID = tasks.taskType),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskTo),(SELECT [fullName]  FROM [wlglobalcorp].[dbo].[Users] where userId = tasks.taskFor)  FROM [tasks] where taskfor =" + agentID + " or taskTo =" + agentID + " or userId =" + agentID + " or clientId in (SELECT [UserId] FROM [wlglobalcorp].[dbo].[Users] where  assignedAgentID = " + agentID + ") order by taskID";

        }

        String ConnStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

        SqlDataAdapter AgentAdpt = new SqlDataAdapter(queryString, ConnStr);
        AgentAdpt.Fill(Users);
        int x = 0;
        foreach (DataRow Task in Users.Tables[0].Rows)
        {
            Task taskInfo = new Task();
            Int32.TryParse(String.Format("{0:0}", Task[0]), out x);
            taskInfo.TaskId = x;

            taskInfo.TaskDate = String.Format("{0:c}", Task[1]).ToString().Trim();
            taskInfo.TaskTitle = String.Format("{0:c}", Task[2]).ToString().Trim();
            taskInfo.TaskDescription = String.Format("{0:c}", Task[3]).ToString().Trim();
            Int32.TryParse(String.Format("{0:0}", Task[3]), out x);
            taskInfo.UserId = x;
            Int32.TryParse(String.Format("{0:0}", Task[4]), out x);
            taskInfo.PropertyId = x;
            taskInfo.TaskUserFullname = String.Format("{0:0}", Task[5]).ToString().Trim();
            Int32.TryParse(String.Format("{0:0}", Task[6]), out x);
            taskInfo.UserRequestID = x;
            Int32.TryParse(String.Format("{0:c}", Task[7]), out x);
            taskInfo.TaskType = x;
            taskInfo.TaskStatus = String.Format("{0:c}", Task[8]).ToString().Trim();
            taskInfo.AgentUserName = String.Format("{0:c}", Task[9]).ToString().Trim();
            Int32.TryParse(String.Format("{0:0}", Task[10]), out x);
            taskInfo.CloseHouseAmount = x;
            taskInfo.TaskState = String.Format("{0:c}", Task[11]).ToString().Trim();
            taskInfo.TaskTypeName = String.Format("{0:c}", Task[12]).Trim();
            taskInfo.TaskToName = String.Format("{0:c}", Task[13]).Trim();
            taskInfo.TaskForName = String.Format("{0:c}", Task[14]).Trim();
            allTasks.Add(taskInfo);
        }

        JavaScriptSerializer TheSerializer = new JavaScriptSerializer();

        var TheJson = TheSerializer.Serialize(allTasks);

        return TheJson;
    }

    [WebMethod]
    public List<Property> RetrieveAllPropertyData(string agentID)
    {

        String queryString = "SELECT [propertyId] ,[start_date],[Title] ,[Price] ,[city] ,[state] ,[Category] ,[listing_Type],[agentId] ,[agentName],[rooms],[beds] ,[baths] ,[area_size],[propertyLocation] ,[outdoorSpace] ,[showinWebSite],[numberofGarages],[propertyLocationinChinese],[propertyViewType],[propertyDirection] ,[numberofFloors] FROM [wlglobalcorp].[dbo].[properties] order by propertyId desc ";
        String ConnStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

        string userID = agentID;

        if (userID != "0")
        {
            queryString = "SELECT [propertyId] ,[start_date],[Title] ,[Price] ,[city] ,[state] ,[Category] ,[listing_Type],[agentId] ,[agentName],[rooms],[beds] ,[baths] ,[area_size],[propertyLocation] ,[outdoorSpace] ,[showinWebSite],[numberofGarages],[propertyLocationinChinese],[propertyViewType],[propertyDirection] ,[numberofFloors] FROM [wlglobalcorp].[dbo].[properties] where agentId=" + userID + " order by propertyId desc ";
        }

        SqlDataAdapter AgentAdpt = new SqlDataAdapter(queryString, ConnStr);
        AgentAdpt.Fill(Properties);
        int x = 0;
        foreach (DataRow Property in Properties.Tables[0].Rows)
        {
            Property propertyInfo = new Property();
            Int32.TryParse(String.Format("{0:0}", Property[0]), out x);
            propertyInfo.PropertyId = x;

            propertyInfo.StartDate = String.Format("{0:c}", Property[1]).ToString().Trim();

            propertyInfo.PropertyTitle = String.Format("{0:c}", Property[2]).ToString().Trim();
            Int32.TryParse(String.Format("{0:0}", Property[3]), out x);
            propertyInfo.Price = x;
            Int32.TryParse(String.Format("{0:0}", Property[3]), out x);
            //  propertyInfo.City = String.Format("{0:c}", Property[4]);
            propertyInfo.State = String.Format("{0:c}", Property[5]).ToString().Trim();
            //   propertyInfo.Category = String.Format("{0:c}", Property[6]);

            Int32.TryParse(String.Format("{0:0}", Property[12]), out x);
            propertyInfo.Baths = x;
            Int32.TryParse(String.Format("{0:0}", Property[13]), out x);
            propertyInfo.Area_size = x;

            propertyInfo.PropertyLocation = String.Format("{0:0}", Property[14]).ToString().Trim();
            propertyInfo.ShowInWebSite = String.Format("{0:0}", Property[16]).ToString().Trim();
            Int32.TryParse(String.Format("{0:0}", Property[10]), out x);
            propertyInfo.Rooms = x;
            Int32.TryParse(String.Format("{0:0}", Property[11]), out x);
            propertyInfo.Beds = x;
            Int32.TryParse(String.Format("{0:0}", Property[8]), out x);
            propertyInfo.AgentId = x;
            propertyInfo.AgentName = String.Format("{0:0}", Property[9]).ToString().Trim();

            /*
        
            propertyInfo.Listing_Type = String.Format("{0:c}", Property[7]);
            propertyInfo.PropertyDirection = String.Format("{0:c}", Property[20]);
            Int32.TryParse(String.Format("{0:0}", Property[21]), out x);
            propertyInfo.NumberOfFloors = x;
            Int32.TryParse(String.Format("{0:0}", Property[16]), out x);
            propertyInfo.NumberofGarages = x;
         
            propertyInfo.PropertyLocationInChinese = String.Format("{0:c}", Property[18]);
            propertyInfo.PropertyViewType = String.Format("{0:c}", Property[19]);
           
            */
            properties.Add(propertyInfo);
        }
        return properties;
    }

}
