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
/// Summary description for product
/// </summary>
public class Product
{
	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
    }

    #region "Member Variables"
    private int _productId;
	private int _agentId;
	private string _agentName;
	private string _title;
	private string _description;
	private int _active;
	private float _price;
	private string _category;
	private string _uploaddate;
	private string _showinWebSite;
	private string _briefDescI;
	private string _productSize;
	private string _briefDescII;
    private string _showInWebSite;
    private string _color;

    #endregion

    #region "Products Memership"

    public  int ProductId { get { return _productId; } set { _productId = value; } }
	public int AgentId { get { return _agentId; } set { _agentId = value; } }
	public  string AgentName { get { return _agentName; } set { _agentName = value; } }
	public  string ProductTitle { get { return _title; } set {  _title= value; } }
	public  string ProductDescription { get { return _description; } set { _description = value; } }
	public  int Active { get { return  _active; } set { _active = value; } }
	public  float Price { get { return _price; } set { _price = value; } }
	public  string Category { get { return _category; } set {_category  = value; } }
	public  string Uploaddate { get { return _uploaddate; } set { _uploaddate = value; } }
	public  string ShowinWebSite { get { return _showinWebSite; } set { _showinWebSite = value; } }
	public  string BriefDescI { get { return _briefDescI; } set { _briefDescI = value; } }
	public  string BriefDescII { get { return _briefDescII; } set { _briefDescII = value; } }
    public  string ProductSize { get { return _productSize; } set { _productSize = value; } }
    public string ShowInWebSite { get { return _showInWebSite; } set { _showInWebSite = value; } }
    public string Color { get { return _color; } set { _color = value; } }

#endregion

    public void Update()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateProductValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@productId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 500);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productDescI", SqlDbType.NChar, 40);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BriefDescI;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productDescII", SqlDbType.NChar, 40);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BriefDescII;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productSize", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductSize;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@color", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Color;
            cmd.Parameters.Add(parm);   

            cmd.ExecuteNonQuery();

        }
    }

    public void Create()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("CreateProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@ProductId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 500);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProductDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@uploadDate", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Uploaddate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productDescI", SqlDbType.NChar, 40);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BriefDescI;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productDescII", SqlDbType.NChar, 40);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BriefDescII;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@productSize", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  ProductSize;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@color", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Color;
            cmd.Parameters.Add(parm);   

      
            cmd.ExecuteNonQuery();
            ProductId = int.Parse(cmd.Parameters["@productId"].Value.ToString());
        }
    }



}