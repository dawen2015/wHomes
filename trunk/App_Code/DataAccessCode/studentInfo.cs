using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Mail;
using System.Net;
using System.IO;
using System.Web.Mail;
using System.Net;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for studentInfo
/// </summary>
public class studentInfo
{
    public Int32 ID { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string chineseName { get; set; }
    public string grade2015 { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string province { get; set; }
    public string zipCode { get; set; }
    public string country { get; set; }
    public string webChatID { get; set; }
    public string email { get; set; }
    public string cellPhone { get; set; }
    public string county { get; set; }
    public string parentName { get; set; }
    public string parentCellPhone { get; set; }
    public string parentWeChat { get; set; }
    public string parentEmail { get; set; }
    public string secondParentName { get; set; }
    public string secondParentEmail { get; set; }
    public string secondParentCellPhone { get; set; }
    public string secondParentWeChat { get; set; }
    public string userType { get; set; }
    public string gender { get; set; }
    public string dob { get; set; }
    public string assignedClass { get; set; }
    public string details { get; set; }
    public string studyProvince { get; set; }
    public string studyCity { get; set; }
    public string studyCounty { get; set; }
    public string guardianRelationship { get; set; }
    public string secondGuardianRelationship { get; set; }
    public string status { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int birthYear { get; set; }
    public int birthMonth { get; set; }
    public int birthDay { get; set; }
    public bool wacademyClient { get; set; }
    public bool whomesClient { get; set; }
    public bool wclubsClient { get; set; }
    public bool agentsReferral { get; set; }
    public bool schoolReports { get; set; }
    public bool recommendedHousing { get; set; }
    public bool housingPurchaseGuide { get; set; }
    public bool skillsTraining { get; set; }
    public bool collegeCounseling { get; set; }
    public bool jobPlanning { get; set; }
    public bool memberActivity { get; set; }
    public bool accountingRecommending { get; set; }
    public bool openAcccount { get; set; }
    public bool insuranceChoice { get; set; }
    public bool propertyManagement { get; set; }
    public bool legalCounseling { get; set; }
    public string arrivingDate { get; set; }
    public string leavingDatee { get; set; }
    public string password { get; set; }
    public string summerCamp { get; set; }
    public string airportService { get; set; }
    public string counselor { get; set; }
    public string counselCity { get; set; }
    public string counselWeChat { get; set; }
    public string counselPhone { get; set; }
    public string counselorEmail { get; set; }
    public string greenCardStatus { get; set; }
    public string officeVisit { get; set; }
    public string financialCounsel { get; set; }
    public string currentClass { get; set; }
    public string currentStudyProvience { get; set; }
    public string currentStudyCity { get; set; }
    public string preferredSchoolType { get; set; }
    public string sm_schoolCategory { get; set; }
    public string sm_needBoardingSchool { get; set; }
    public string sm_preferredLiveArea { get; set; }
    public string sm_preparedToBuyProperty { get; set; }
    public string sm_preferredSchoolName { get; set; }
    public string sm_question { get; set; }
    public string md_schoolCategory { get; set; }
    public string md_needBoardingSchool { get; set; }
    public string md_preferredLiveArea { get; set; }
    public string md_preparedToBuyProperty { get; set; }
    public string md_preferredSchoolName { get; set; }
    public string md_question { get; set; }
    public string hg_schoolCategory { get; set; }
    public string hg_needBoardingSchool { get; set; }
    public string hg_preferredLiveArea { get; set; }
    public string hg_preparedToBuyProperty { get; set; }
    public string hg_preferredSchoolName { get; set; }
    public string hg_question { get; set; }
    public string hg_ssat { get; set; }
    public string hg_toefl { get; set; }
    public string cg_schoolCategory { get; set; }
    public string cg_applicationType { get; set; }
    public string cg_top25 { get; set; }
    public string cg_top100 { get; set; }
    public string cg_otherSchools { get; set; }
    public string cg_preferredLiveArea { get; set; }
    public string cg_preparedToBuyProperty { get; set; }
    public string cg_school1 { get; set; }
    public string cg_school2 { get; set; }
    public string cg_school3 { get; set; }
    public string cg_expectedProfession { get; set; }
    public string cg_sat { get; set; }
    public string cg_act { get; set; }
    public string cg_toefl { get; set; }
    public string cg_gre { get; set; }
    public string cg_question { get; set; }
    public string cg_attendYear { get; set; }


    public studentInfo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddSummerCampStudent()
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; user id=dawen; password=Brooklyn2015; database=wacademy; pooling=false;");
        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into users (name,address,cellPhone,email,username,userType) values (@Name,@Address,@Mobile,@Email,@username,5)", conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Mobile", cellPhone);
            cmd.Parameters.AddWithValue("@Email", email);
        //  cmd.Parameters.AddWithValue("@chineseName", name);
            cmd.Parameters.AddWithValue("@username", email);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        catch (MySqlException ex)
        {

        }

        conn.Close();

        /*  SqlCommand cmd = new SqlCommand("AddClientAirportService", myConnection);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter parm = new SqlParameter("@userID", SqlDbType.Int);
          parm.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(parm);


          cmd.ExecuteNonQuery();
         ID = int.Parse(cmd.Parameters["@userID"].Value.ToString());
   */
    }


}