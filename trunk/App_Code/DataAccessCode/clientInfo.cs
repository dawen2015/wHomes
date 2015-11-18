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
/// Summary description for clientInfo
/// </summary>
public class clientInfo
{
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
    public bool cg_top25 { get; set; }
    public bool cg_top100 { get; set; }
    public bool cg_otherSchools { get; set; }
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

    public bool AddStudentSurveyData { get; set; }
    public bool AddStudentSummerCampData { get; set; }
    public bool AddHouseRequestData { get; set; }
    public bool AddAirportPickUp { get; set; }
    public bool AddInternalClient { get; set; }
    public int WLGlobalID { get; set; }

    public bool agentsReferral { get; set; }
    public bool SchoolReports { get; set; }
    public bool RecommendedHousing { get; set; }
    public bool HousingPurchaseGuide { get; set; }
    public bool SkillsTraining { get; set; }
    public bool JobPlanning { get; set; }
    public bool CollegeCounseling { get; set; }

    public bool MemberActivity { get; set; }
    public bool AccountingRecommending { get; set; }
    public bool OpenAcccount { get; set; }
    public bool InsuranceChoice { get; set; }
    public bool PropertyManagement { get; set; }
    public bool LegalCounseling { get; set; }

    public bool Portland { get; set; }
    public bool LongIsland { get; set; }
    public bool Orlando { get; set; }
    public string CounselorName { get; set; }

    public string CounselorWeChat { get; set; }
    public string CounselorPhone { get; set; }
    public string CounselorEmail { get; set; }

    public string ImportCity { get; set; }
    public string ClientName { get; set; }
    public string GreenCardStatus { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string WeChat { get; set; }
    public string Email { get; set; }
    public string ArrivalCity { get; set; }
    public string ArrivalDate { get; set; }
    public int UserId { get; set; }
    public int UpdatedID { get; set; }
    public string ArrivalState { get; set; }

    public string Detailed_information { get; set; }
    public string Destination { get; set; }
    public string DepartureDate { get; set; }
    public string Gender { get; set; }
    public string userCategory { get; set; }

    public bool GroupVisiting { get; set; }
    public bool SummerCamp { get; set; }
    public bool EducationalPlan { get; set; }
    public bool AccountingCounsel { get; set; }
    public bool FinancialCounsel { get; set; }
    public bool AirportService { get; set; }
    public bool Eb5Visa { get; set; }
    public bool UsOfficeCounsel { get; set; }
    public bool EmergencyHelp { get; set; }
    public bool OtherService { get; set; }
    public string ArrivalFlighNo { get; set; }
    public string ArrivalLuggages { get; set; }
    public string ArrivalPeople { get; set; }
    public string ArrivalFlightNo { get; set; }
    public string FlightArrivalTime { get; set; }
    public string HotelAddress { get; set; }
    public string ContactPerson { get; set; }
    public string ContactNUmber { get; set; }
    public string LeavingFlightNo { get; set; }
    public string LeavingLuggages { get; set; }
    public string LeavingPeopleNo { get; set; }
    public string LeavingTime { get; set; }
    public string LeavingHotelAddress { get; set; }
    public string LeavingContactPerson { get; set; }
    public string LeavingContactPersonNo { get; set; }
    public string ArrivalPickupDate { get; set; }
    public string ArrivalPickTime { get; set; }
    public string LeavingPickUpDate { get; set; }
    public string leavingPickupTime { get; set; }
    public string ArrivingAirport { get; set; }
    public string LeavingAirport { get; set; }
    public string FirstClientName { get; set; }
    public string FirstClientGender { get; set; }
    public string FirstClientPhone { get; set; }
    public string FirstClientEmail { get; set; }
    public string FirstClientWeChat { get; set; }
    public string SecondClientName { get; set; }
    public string SecondClientGender { get; set; }
    public string SecondClientPhone { get; set; }
    public string SecondClientEmail { get; set; }
    public string SecondClientWeChat { get; set; }
    public string ThirdClientName { get; set; }
    public string ThirdClientGender { get; set; }
    public string ThirdClientPhone { get; set; }
    public string ThirdClientEmail { get; set; }
    public string ThirdClientWeChat { get; set; }
    public bool IsChildSchool { get; set; }
    public bool PurchaseHouseforInvestment { get; set; }
    public bool PurchaseHouseForSelf { get; set; }
    public bool EnglishAbility { get; set; }
    public bool SchoolDistrictType { get; set; }
    public bool InterestedHouse { get; set; }
    public bool InterestedCondo { get; set; }
    public bool InterestedTownHouse { get; set; }
    public bool InterestedApartment { get; set; }
    public bool ExcellentDistrict { get; set; }
    public bool GoodDistrict { get; set; }
    public bool GeneralDistrict { get; set; }
    public bool East { get; set; }
    public bool West { get; set; }
    public bool South { get; set; }
    public bool North { get; set; }
    public bool NorthEast { get; set; }
    public bool SouthEast { get; set; }
    public bool SouthWest { get; set; }
    public bool NorthWest { get; set; }
    public bool Hawaii { get; set; }
    public bool Chicago { get; set; }
    public bool Miami { get; set; }
    public bool SanDiego { get; set; }
    public bool NewJersey { get; set; }
    public bool Connecticut { get; set; }
    public bool MoveInImmediately { get; set; }
    public bool ThreeYears { get; set; }
    public bool FiveYears { get; set; }
    public bool TenYears { get; set; }
    public bool OverTenYears { get; set; }
    public bool NewHouse { get; set; }
    public bool Atlanta { get; set; }
    public bool NewYorkState { get; set; }
    public bool California { get; set; }
    public bool Washington { get; set; }
    public bool Floridia { get; set; }
    public bool Massachusetts { get; set; }
    public bool Pennsylvania { get; set; }
    public bool BothInvstmtment { get; set; }
    public string FirstVisitHouseTime { get; set; }

    public string PreferredTypeHome { get; set; }
    public string MinPreferedFootage { get; set; }
    public string MaxPreferredFootage { get; set; }
    public string PreferredBedrooms { get; set; }
    public string PreferredBathrooms { get; set; }
    public string PreferredGarages { get; set; }
    public string ChineseCompanyProvince { get; set; }
    public string PreferredState { get; set; }
    public string PreferredCity { get; set; }
    public string ReasonsToPurchase { get; set; }

    public string NeedtoSellProperty { get; set; }
    public string CurrentlyInLease { get; set; }
    public string AssistanceLocalFinance { get; set; }
    public string HaveLiquidAsset { get; set; }
    public string WantBasement { get; set; }
    public string NeedFinancing { get; set; }

    public string ChildAge { get; set; }
    public string ChildGrade { get; set; }
    public string MinPreferedPrice { get; set; }
    public string MaxPreferredPrice { get; set; }
    public string TimeToMoveIn { get; set; }

    public string otherCity { get; set; }
    public string ThirdVisitHouseTime { get; set; }
    public string SecondVistiHouseTime { get; set; }
    public int SecondChildAge { get; set; }
    public string SecondChildGrade { get; set; }
    public int ThirdChildAge { get; set; }
    public string ThirdChildGrade { get; set; }

    public void AddSummerCampStudent()
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; user id=dawen; password=Brooklyn2015; database=wacademy; pooling=false;charset=utf8;");
        try
        {
            string insertItems = "Insert into users (attendYear,cg_schoolCategory, cg_applicationType, cg_top25, cg_top100, cg_otherSchools, cg_preferredLiveArea, cg_preparedToBuyProperty, cg_school1, cg_school2, cg_school3, cg_expectedProfession, cg_sat, cg_act, cg_toefl, cg_gre, cg_question,hg_toefl,hg_ssat,hg_question,hg_preferredSchoolName,hg_preparedToBuyProperty,hg_preferredLiveArea,hg_needBoardingSchool,hg_schoolCategory,md_preferredLiveArea,md_question,md_preferredSchoolName,md_preparedToBuyProperty,md_needBoardingSchool,md_schoolCategory,sm_question,sm_preferredSchoolName,sm_preparedToBuyProperty,sm_preferredLiveArea,sm_needBoardingSchool,sm_schoolCategory,preferredSchoolType,grade2015,studyCity,studyProvince,zipCode,city,webChatID,name,address,cellPhone,email,username,userType,Gender,country,province)";
            string valueItems = " values (@cg_attendYear,@cg_schoolCategory, @cg_applicationType, @cg_top25, @cg_top100, @cg_otherSchools, @cg_preferredLiveArea, @cg_preparedToBuyProperty, @cg_school1, @cg_school2, @cg_school3, @cg_expectedProfession, @cg_sat, @cg_act, @cg_toefl, @cg_gre, @cg_question,@hg_toefl,@hg_ssa,@hg_question,@hg_preferredSchoolName,@hg_preparedToBuyProperty,@hg_preferredLiveArea,@hg_needBoardingSchool,@hg_schoolCategory,@md_preferredLiveArea,@md_question,@md_preferredSchoolName,@md_preparedToBuyProperty,@md_needBoardingSchool,@md_schoolCategory,@sm_question,@sm_preferredSchoolName,@sm_preparedToBuyProperty,@sm_preferredLiveArea,@sm_needBoardingSchool,@sm_schoolCategory,@preferredSchoolType,@grade2015,@studyCity,@studyProvince,@zipCode,@city,@webChatID,@Name,@Address,@Mobile,@Email,@username,5,@Gender,'1',@province)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insertItems + valueItems, conn);
            /* cg_schoolCategory, cg_applicationType, cg_top25, cg_top100, cg_otherSchools, cg_preferredLiveArea, cg_preparedToBuyProperty, cg_school1, cg_school2, cg_school3, cg_expectedProfession, cg_sat, cg_act, cg_toefl, cg_gre, cg_question,
            */

            cmd.Parameters.AddWithValue("@cg_attendYear", cg_attendYear);

            cmd.Parameters.AddWithValue("@cg_schoolCategory", cg_schoolCategory);
            cmd.Parameters.AddWithValue("@cg_applicationType", cg_applicationType);

            cmd.Parameters.AddWithValue("@cg_top25", cg_top25);

            cmd.Parameters.AddWithValue("@cg_top100", cg_top100);

            cmd.Parameters.AddWithValue("@cg_otherSchools", cg_otherSchools);

            cmd.Parameters.AddWithValue("@cg_preferredLiveArea", cg_preferredLiveArea);

            cmd.Parameters.AddWithValue("@cg_preparedToBuyProperty", cg_preparedToBuyProperty);

            cmd.Parameters.AddWithValue("@cg_school1", cg_school1);

            cmd.Parameters.AddWithValue("cg_school2", cg_school2);

            cmd.Parameters.AddWithValue("@cg_school3", cg_school3);

            cmd.Parameters.AddWithValue("@cg_expectedProfession", cg_expectedProfession);

            cmd.Parameters.AddWithValue("@cg_sat", cg_sat);

            cmd.Parameters.AddWithValue("@cg_act", cg_act);
            cmd.Parameters.AddWithValue("@cg_toefl", cg_toefl);
            cmd.Parameters.AddWithValue("@cg_gre", cg_gre);
            cmd.Parameters.AddWithValue("@cg_question", cg_question);
            cmd.Parameters.AddWithValue("@hg_toefl", hg_toefl);
            cmd.Parameters.AddWithValue("@hg_ssa", hg_ssat);

            cmd.Parameters.AddWithValue("@hg_question", hg_question);
            cmd.Parameters.AddWithValue("@hg_preferredSchoolName", hg_preferredSchoolName);
            cmd.Parameters.AddWithValue("@hg_preparedToBuyProperty", hg_preparedToBuyProperty);
            cmd.Parameters.AddWithValue("@hg_preferredLiveArea", hg_preferredLiveArea);
            cmd.Parameters.AddWithValue("@hg_needBoardingSchool", hg_needBoardingSchool);
            cmd.Parameters.AddWithValue("@hg_schoolCategory", hg_schoolCategory);
            cmd.Parameters.AddWithValue("@md_preferredLiveArea", md_preferredLiveArea);
            cmd.Parameters.AddWithValue("@md_question", md_question);
            cmd.Parameters.AddWithValue("@md_preferredSchoolName", md_preferredSchoolName);
            cmd.Parameters.AddWithValue("@md_preparedToBuyProperty", md_preparedToBuyProperty);
            cmd.Parameters.AddWithValue("@md_needBoardingSchool", md_needBoardingSchool);
            cmd.Parameters.AddWithValue("@md_schoolCategory", md_schoolCategory);
            cmd.Parameters.AddWithValue("@sm_question", sm_question);
            cmd.Parameters.AddWithValue("@sm_preferredSchoolName", sm_preferredSchoolName);
            cmd.Parameters.AddWithValue("@sm_preparedToBuyProperty", sm_preparedToBuyProperty);
            cmd.Parameters.AddWithValue("@sm_preferredLiveArea", sm_preferredLiveArea);
            cmd.Parameters.AddWithValue("@sm_needBoardingSchool", sm_needBoardingSchool);
            cmd.Parameters.AddWithValue("@sm_schoolCategory", sm_schoolCategory);
            cmd.Parameters.AddWithValue("@preferredSchoolType", preferredSchoolType);
            cmd.Parameters.AddWithValue("@grade2015", currentClass);
            cmd.Parameters.AddWithValue("@studyCity", currentStudyCity);
            cmd.Parameters.AddWithValue("@studyProvince", currentStudyProvience);
            cmd.Parameters.AddWithValue("@zipCode", ZipCode);
            cmd.Parameters.AddWithValue("@city", City);
            cmd.Parameters.AddWithValue("@webChatID", WeChat);
            cmd.Parameters.AddWithValue("@Name", ClientName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Mobile", Email);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@username", Email);
            cmd.Parameters.AddWithValue("@province", State);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
        catch (MySqlException ex)
        {

        }

        conn.Close();


    }

    public void AddClientAirportService()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddClientAirportService", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@userID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@webChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselor", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ImportCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipcode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@groupVisiting", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GroupVisiting;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@summerCamp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SummerCamp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@educationalPlan", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EducationalPlan;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@accountingCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AccountingCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@financialCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FinancialCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@airportService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AirportService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eb5Visa", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Eb5Visa;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usOfficeCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UsOfficeCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@emergencyHelp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EmergencyHelp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalFlighNo", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalFlighNo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalLuggages", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalLuggages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalPeople", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalPeople;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@flightArrivalTime", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FlightArrivalTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@hotelAddress", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HotelAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@contactPerson", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ContactPerson;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@contactNUmber", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ContactNUmber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingFlightNo", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingFlightNo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingLuggages", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingLuggages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingPeopleNo", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingPeopleNo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@LeavingTime", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingHotelAddress", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingHotelAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingContactPerson", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingContactPerson;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingContactPersonNo", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingContactPersonNo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenCardStatus", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenCardStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@destination", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Destination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@departDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DepartureDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@gender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Gender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arivalState", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalPickupDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalPickupDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalPickTime", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalPickTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingPickUpDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingPickUpDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingPickupTime", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = leavingPickupTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivingAirport", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivingAirport;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingAirport", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingAirport;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalCity", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalCity;
            cmd.Parameters.Add(parm);



            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userID"].Value.ToString());
        }
    }

    public void AddAnApplicant()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("addAnApplicant", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@webChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselor", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ImportCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@gender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Gender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipcode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@groupVisiting", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GroupVisiting;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@summerCamp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SummerCamp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@educationalPlan", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CollegeCounseling;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@accountingCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AccountingRecommending;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@financialCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyManagement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@airportService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AirportService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eb5Visa", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Eb5Visa;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usOfficeCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UsOfficeCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@emergencyHelp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EmergencyHelp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenCardStatus", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenCardStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@destination", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Destination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@departDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DepartureDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstClientGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstClientPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantEmail", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstClientEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstClientWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondClientGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondClientPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantEmail", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondClientEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondClientWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdClientGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdClientPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantEmail", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdClientEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdClientWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@UpdatedID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UpdatedID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ArrivalState", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wlglobalID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WLGlobalID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@RecommendedHousing", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RecommendedHousing;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@HousingPurchaseGuide", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HousingPurchaseGuide;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolReports", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SchoolReports;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skillsTraining", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SkillsTraining;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@jobPlanning", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = JobPlanning;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@memberActivity", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MemberActivity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openAcccount", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenAcccount;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@insuranceChoice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InsuranceChoice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@legalCounseling", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InsuranceChoice;
            cmd.Parameters.Add(parm);
            
            parm = new SqlParameter("@userCategory", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = userCategory;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());

        }
    }

    public void AddAnApplicantServices()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("addAnApplicantServices", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@summerCamp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SummerCamp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@educationalPlan", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EducationalPlan;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@accountingCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AccountingCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@financialCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FinancialCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@airportService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AirportService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usOfficeCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UsOfficeCounsel;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }


    public void AddClientHouseRequestService()
    {

        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddClientHouseRequestService", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = "client";
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = true;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@approve", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = true;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cellPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = "";
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@webChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselor", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ImportCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Gender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullname", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClientName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipcode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedCondo", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedCondo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedTownHouse ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedTownHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedApartment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedApartment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@excellentDistrict", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ExcellentDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@goodDistrict", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GoodDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@generalDistrict", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GeneralDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@east", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = East;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@west", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = West;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@south", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = South;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@north", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = North;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@northEast", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NorthEast;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@southEast", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SouthEast;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@southWest", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SouthWest;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@northWest", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NorthWest;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@moveInImmediately", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MoveInImmediately;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeYears", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeYears;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fiveYears", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FiveYears;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@tenYears", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TenYears;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@overTenYears", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OverTenYears;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@hawaii", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Hawaii;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chicago", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Chicago;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@miami", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Miami;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@sanDiego", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SanDiego;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newJersey", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewJersey;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@connecticut", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Connecticut;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@atlanta", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Atlanta;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newYorkState", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewYorkState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@california", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = California;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@washington", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Washington;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@floridia", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Floridia;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@massachusetts", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Massachusetts;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@pennsylvania", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Pennsylvania;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bothInvstmtment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BothInvstmtment;
            cmd.Parameters.Add(parm);

            int numberofVisitingCities = 1;

            if (SecondVistiHouseTime.Trim() != "") { numberofVisitingCities++; }
            if (ThirdVisitHouseTime.Trim() != "") { numberofVisitingCities++; }

            parm = new SqlParameter("@numberofVisitingCities", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = numberofVisitingCities;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredState", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@purchaseHouseforInvestment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PurchaseHouseforInvestment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@PurchaseHouseForSelf", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PurchaseHouseForSelf;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredBedrooms", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredBedrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredBathrooms", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredBathrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredGarages", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredGarages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@minPreferedFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MinPreferedFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@maxPreferredFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaxPreferredFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@minPreferedPrice", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MinPreferedPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@maxPreferredPrice", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaxPreferredPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@needFinancing", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeedFinancing;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@haveLiquidAsset", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HaveLiquidAsset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@TimeToMoveIn", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TimeToMoveIn;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@deoartureDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DepartureDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@destination", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Destination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1age", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1Grade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@groupVisiting", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GroupVisiting;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@summerCamp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SummerCamp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@educationalPlan", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CollegeCounseling;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@accountingCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AccountingRecommending;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@financialCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyManagement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@airportService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AirportService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eb5Visa", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Eb5Visa;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usOfficeCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UsOfficeCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@emergencyHelp", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EmergencyHelp;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenCardStatus", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenCardStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstVisitHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ReasonsToPurchase;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ArrivalState", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@longIsland", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LongIsland;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@portland", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Portland;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@orlando", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Orlando;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolReports", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SchoolReports;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@recommendedHousing", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RecommendedHousing;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@housingPurchaseGuide", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HousingPurchaseGuide;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skillsTraining", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SkillsTraining;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@jobPlanning", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = JobPlanning;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@memberActivity", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MemberActivity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@accountingRecommending", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AccountingRecommending;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@openAcccount", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenAcccount;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@insuranceChoice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InsuranceChoice;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@propertyManagement", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyManagement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@legalCounseling", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LegalCounseling;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselWeChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselPhone", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselEmail", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselorEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherCity", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = otherCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondVisitHouseTime", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondVistiHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdVisitHouseTime", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdVisitHouseTime;
            cmd.Parameters.Add(parm);

            /*
            parm = new SqlParameter("@secondChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondChildGrade", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter(" @thirdChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdChildGrade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value =ThirdChildGrade;
            cmd.Parameters.Add(parm);
            */
            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());

            Description d = new Description();

            d.Detail = Detailed_information;
            d.SourceId = UserId;
            d.DescriptionType = 1;
            d.AddADescription();

        }
    }

}