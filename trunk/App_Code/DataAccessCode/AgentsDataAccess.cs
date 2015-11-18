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

public class AgentsDataAccess
{
    public static decimal GetAveragePrice()
    {
        string sql = "SELECT AVG(UnitPrice) FROM Products";
        object result;

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            result = command.ExecuteScalar();
        }

        return (decimal)result;
    }


    public static int UpdateAllPricesBy(decimal amount)
    {
        string sql = "UPDATE Products SET UnitPrice=UnitPrice + " + amount.ToString();
        int rowsAffected;

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            rowsAffected = command.ExecuteNonQuery();
        }

        return rowsAffected;
    }


    public static int DeleteProduct(int productID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand command = new SqlCommand("ttDeleteProduct", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productID;

            rowsAffected = command.ExecuteNonQuery();
        }
        return rowsAffected;
    }


    public static SqlDataReader GetAllPrices()
    {
        string sql = "SELECT ProductName, UnitPrice FROM Products";

        SqlConnection connection = ConnectionManager.GetDataBaseConnection();
        SqlCommand command = new SqlCommand(sql, connection);
        command.CommandType = CommandType.Text;

        SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
        return reader;
    }


    public static SqlDataReader GetProducts()
    {
        string sql = "SELECT * FROM Products";

        SqlConnection connection = ConnectionManager.GetDataBaseConnection();
        SqlCommand command = new SqlCommand(sql, connection);
        command.CommandType = CommandType.Text;

        SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
        return reader;
    }


    public static int InsertProduct(
                             int productID,
                             string productName, 
                             int supplierID, 
                             int categoryID, 
                             string quantityPerUnit,
                             decimal unitPrice,
                             int unitsInStock,
                             int unitsOnOrder,
                             int reorderLevel,
                             bool discontinued)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand command = new SqlCommand("ttInsertProduct", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductName",     SqlDbType.NVarChar, 40).Value = productName;
            command.Parameters.Add("@SupplierID",      SqlDbType.Int).Value = supplierID;
            command.Parameters.Add("@CategoryID",      SqlDbType.Int).Value = categoryID;
            command.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar, 20).Value = quantityPerUnit;
            command.Parameters.Add("@UnitPrice",       SqlDbType.Money).Value = unitPrice;
            command.Parameters.Add("@UnitsInStock",    SqlDbType.SmallInt).Value = unitsInStock;
            command.Parameters.Add("@UnitsOnOrder",    SqlDbType.SmallInt).Value = unitsOnOrder;
            command.Parameters.Add("@ReorderLevel",    SqlDbType.SmallInt).Value = reorderLevel;
            command.Parameters.Add("@Discontinued",    SqlDbType.Bit).Value = discontinued;

            rowsAffected = command.ExecuteNonQuery();
        }
        return rowsAffected;
    }


    public static int UpdateProduct(
                             int productID,
                             string productName,
                             int supplierID,
                             int categoryID,
                             string quantityPerUnit,
                             decimal unitPrice,
                             int unitsInStock,
                             int unitsOnOrder,
                             int reorderLevel,
                             bool discontinued)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand command = new SqlCommand("ttUpdateProduct", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productID;
            command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 40).Value = productName;
            command.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierID;
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryID;
            command.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar, 20).Value = quantityPerUnit;
            command.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = unitPrice;
            command.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt).Value = unitsInStock;
            command.Parameters.Add("@UnitsOnOrder", SqlDbType.SmallInt).Value = unitsOnOrder;
            command.Parameters.Add("@ReorderLevel", SqlDbType.SmallInt).Value = reorderLevel;
            command.Parameters.Add("@Discontinued", SqlDbType.Bit).Value = discontinued;

            rowsAffected = command.ExecuteNonQuery();
        }
        return rowsAffected;
    }

    public static DataSet GetProductsInCategory(int categoryID)
    {
        DataSet dataSet = new DataSet();

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            string sql = "SELECT * FROM Products WHERE CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryID;
            command.CommandType = CommandType.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet, "Products");
        }
        return dataSet;
    }

    public static DataSet GetProductsAndOrderDetails(int categoryID)
    {
        DataSet dataSet = new DataSet();

        using (SqlConnection connection = ConnectionManager.GetDataBaseConnection())
        {
            string sql = "SELECT * FROM Products WHERE CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryID;
            command.CommandType = CommandType.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet, "Products");

            command.CommandText = "SELECT * FROM [Order Details]";
            dataAdapter.Fill(dataSet, "OrderDetails");

            DataRelation relation = new DataRelation(
                "Products_OrderDetails",
                dataSet.Tables["Products"].Columns["ProductID"],
                dataSet.Tables["OrderDetails"].Columns["ProductID"]);

        }
        return dataSet;
    }
}

public class Agent
{
    #region "Member Variables"
    private int _AgentId;

    private string _AgentName;
    private string _title;
    private string _Phone;
    private string _Email;
    private string _detailed_information;
    private string _smalL_image;
          
    private byte[] _portrait;
    #endregion

    #region "Properties"
    public int AgentId
    {
        get { return _AgentId; }
        set { _AgentId = value; }
    }

    public string smalL_image
    {
        get { return _smalL_image; }
        set { _smalL_image = value; }
    }

    public string detailed_information
    {
        get { return _detailed_information; }
        set { _detailed_information = value; }
    }

    public string AgentName
    {
        get { return _AgentName; }
        set { _AgentName = value; }
    }

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }

    public string title
    {
        get { return _title; }
        set { _title = value; }
    }

    public byte[] Portrait
    {
        get { return _portrait; }
        set { _portrait = value; }
    }
    #endregion

    public void Create()
    {

        using (SqlConnection conn =    ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("Agents_Create2", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@AgentId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentName", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentName;
            cmd.Parameters.Add(parm);
            /*
            parm = new SqlParameter("@title", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = title;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Phone", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.VarChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.VarChar);
            parm.Direction = ParameterDirection.Input;
            parm.Value = detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@small_image", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = smalL_image;
            cmd.Parameters.Add(parm);

              */
            parm = new SqlParameter("@Portrait", SqlDbType.Image);
            parm.Direction = ParameterDirection.Input;
            parm.IsNullable = true;
            parm.Value = Portrait;
            cmd.Parameters.Add(parm);
          
            cmd.ExecuteNonQuery();
            AgentId = int.Parse(cmd.Parameters["@AgentId"].Value.ToString());
        }
    }

    public static byte[] GetPortrait(int AgentId)
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("Agent_Portrait_Retrieve", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@AgentId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentId;
            cmd.Parameters.Add(parm);
          
            byte[] data = (byte[])cmd.ExecuteScalar();
            return data;
        }
    }
}

