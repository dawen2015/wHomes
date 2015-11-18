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
/// User class represents data access component to Users table.
/// </summary>
public class User
{
    #region "Member Variables"


    private string _firstApplicantName;
    private string _firstApplicantGender;
    private string _firstApplicantPhone;
    private string _firstApplicantEmail;
    private string _firstApplicantWeChat;
    private string _secondApplicantName;
    private string _secondApplicantGender;
    private string _secondApplicantPhone;
    private string _secondApplicantEmail;
    private string _secondApplicantWeChat;
    private string _thirdApplicantName;
    private string _thirdApplicantGender;
    private string _thirdApplicantPhone;
    private string _thirdApplicantEmail;
    private string _thirdApplicantWeChat;

    private string _arrivalFlighNo;
    private string _arrivalLuggages;
    private string _arrivalPeople;
    private string _flightArrivalTime;
    private string _hotelAddress;
    private string _contactPerson;
    private string _contactNUmber;
    private string _leavingFlightNo;
    private string _leavingLuggages;
    private string _leavingPeopleNo;
    private string _leavingTime;
    private string _leavingHotelAddress;
    private string _leavingContactPerson;
    private string _leavingContactPersonNo;

    private int _groupVisiting;
    private int _summerCamp;
    private int _educationalPlan;
    private int _accountingCounsel;
    private int _financialCounsel;
    private int _airportService;
    private int _eb5Visa;
    private int _usOfficeCounsel;
    private int _emergencyHelp;
    private int _otherService;
    private int _isChildSchool;

    private string _numberOfPropertiesName;
    private string _pictureUploaded;
    private string _driverLicenseUploaded;
    private string _realEstateInsuranceUploaded;
    private int _userCategory;
    private string _userCategoryName;
    private string _acFristName;
    private string _acLastName;
    private int _userId;
    private int _userRequestID;
    private string _userName;
    private string _password;
    private byte[] _portrait;
    private string _title1;
    private string _title2;
    private int _atlanta;
    private int _newYorkState;
    private int _california;
    private int _washington;
    private int _floridia;
    private int _massachusetts;
    private int _pennsylvania;
    private int _bothInvstmtment;
    private string _otherPropertyRequest;
    private int _fourthAgentID;
    private string _fourthAgentName;
    private int _fifthAgentID;
    private string _fifthAgentName;
    private int _sixthAgentID;
    private string _sixthAgentName;

    private string _AgentName;
    private string _title;
    private string _Phone;
    private string _Email;
    private string _detailed_information;

    private string _userEmail;
    private string _firstName;
    private string _lastName;
    private string _Address;
    private string _address2;
    private string _zipcode;
    private string _city;
    private string _country;
    private string _state;
    private bool _active;
    private bool _approve;
    private string _faxNumber;
    private string _userType;
    private string _modifiedDate;
    private int _modifiedBy;
    private string _creationDate;
    private int _assignedAgentId;
    private int _assignedAdminId;
    private string _assignedAgentName;
    private string _fullName;
    private string _ssn;
    private string _dob;
    private string _cellPhone;
    private string _companyName;
    private string _companyAddress;
    private string _companyCity;
    private string _companyState;
    private string _companyZipCode;
    private string _companyPhone;
    private string _companyEmail;
    private string _companyFax;
    private string _companyWebSite;
    private string _companyLicensedNumber;
    private string _agentLicensedNumber;
    private string _companyTaxID;
    private string _child1age;
    private string _child1Grade;

    private string _fullName2;
    private string _chineseName1;
    private string _ChineseName2;
    private int _numberofVisitingCities;
    private string _weChat;

    private string _whereBuyProperty;
    private string _specifyCityArea;
    private string _preferredSchoolDistrict;
    private string _leaseExpiredDate;
    private string _interestedProperty;
    private string _minPreferedPrice;
    private string _maxPreferredPrice;
    private string _needFinancing;
    private string _preferredTypeHome;
    private string _minPreferedFootage;
    private string _maxPreferredFootage;
    private string _preferredBedrooms;
    private string _preferredBathrooms;
    private string _preferredGarages;
    private string _chineseCompanyProvince;
    private string _preferredState;
    private string _preferredCity;

    private string _needtoSellProperty;
    private string _currentlyInLease;
    private string _assistanceLocalFinance;
    private string _haveLiquidAsset;
    private string _wantBasement;
    private string _timeToMoveIn;
    private string _agentChineseLocation;

    private string _skills1;
    private string _skills2;
    private string _skills3;
    private string _skills4;
    private string _skills5;
    private string _showInWebSite;
    private string _counselor;
    private int _counselorID;
    private string _department;
    private string _other;
    private string _createdClientDate;
    private string _createClientat;
    private string _assignedAdminName;
    private int _numberOfProperties;
    private string _arrivalDate;
    private string _departureDate;
    private string _destination;
    private string _secondDestination;
    private string _secondArrivalDate;
    private string _secondDepartDate;
    private string _thirdDestination;
    private string _thirdArrivalDate;
    private string _thirdDepartDate;
    private int _secondChildAge;
    private string _secondChildGrade;
    private int _thirdChildAge;
    private string _thirdChildGrade;
    private int _isStaff;
    private string _staffTitle;
    private string _chineseAddress;

    public bool skillsTraining { get; set; }
    public bool jobPlanning { get; set; }
    public bool memberActivity { get; set; }
    public bool openAcccount { get; set; }
    public bool insuranceChoice { get; set; }
    public bool legalCounseling { get; set; }

    public int WLGlobalID { get; set; }
    public bool SchoolReports { get; set; }
    public bool RecommendedHousing { get; set; }
    public bool HousingPurchaseGuide { get; set; }
    public bool SkillsTraining { get; set; }
    public bool JobPlanning { get; set; }
    public bool CollegeCounseling { get; set; }
    public bool schoolReports { get; set; }

    public bool MemberActivity { get; set; }
    public bool AccountingRecommending { get; set; }
    public bool OpenAcccount { get; set; }
    public bool InsuranceChoice { get; set; }
    public bool PropertyManagement { get; set; }
    public bool LegalCounseling { get; set; }
  
    private string _counselWeChat;
    private string _counselPhone;
    private int _purchaseHouseforInvestment;
    private int _PurchaseHouseForSelf;
    private int _englishAbility;
    private int _schoolDistrictType;
    private int _interestedHouse;
    private int _interestedCondo;
    private int _interestedTownHouse;
    private int _interestedApartment;
    private int _excellentDistrict;
    private int _goodDistrict;
    private int _generalDistrict;
    private int _east;
    private int _west;
    private int _south;
    private int _north;
    private int _northEast;
    private int _southEast;
    private int _southWest;
    private int _northWest;
    private int _hawaii;
    private int _chicago;
    private int _miami;
    private int _sanDiego;
    private int _newJersey;
    private int _connecticut;
    private int _moveInImmediately;
    private int _threeYears;
    private int _fiveYears;
    private int _tenYears;
    private int _overTenYears;
    private int _newHouse;
    private int _assignedSecondAgent;
    private int _assignedThirdAgent;
    private int _assignedFourthAgent;
    private string _secondAgentName;
    private string _thirdAgentName;
    private string _firstVisitHouseTime;
    private string _secondVisitHouseTime;
    private string _thirdVisitHouseTime;
    private string _securityAnswer;

    #endregion

    #region "Properties"
    public string otherCity { get; set; }
    public int Portland { get; set; }
    public int LongIsland { get; set; }
    public int Orlando { get; set; }
    public string ArrivalCity { get; set; }
    public string ArrivalState { get; set; }
    public string ClosingAgent2 { get; set; }
    public string ClosingAgent3 { get; set; }
    public string ClosingAgent4 { get; set; }
    public string ClosingAgent5 { get; set; }
    public string ClosingAgent6 { get; set; }
    public string ClosingAgentID { get; set; }
    public bool ReferralSamplesUploaded { get; set; }
    public bool FirstAgentReferral { get; set; }
    public bool SecondAgentReferral { get; set; }
    public bool ThirdAgentReferral { get; set; }
    public bool FourthAgentReferral { get; set; }
    public bool FifthAgentReferral { get; set; }
    public bool SixthAgentReferral { get; set; }
    public bool DisplayInformationSheet { get; set; }
    public string ArrivalPickupDate { get; set; }
    public string ArrivalPickTime { get; set; }
    public string LeavingPickUpDate { get; set; }
    public string leavingPickupTime { get; set; }
    public string ArrivingAirport { get; set; }
    public string LeavingAirport { get; set; }

    public Boolean BuyerContract { get; set; }
    public string ProcessStatus { get; set; }
    public int Internal  { get; set; }
    public string BriefDesc { get; set; }
    public string FirstApplicantName { get { return _firstApplicantName; } set { _firstApplicantName = value; } }
    public string FirstApplicantGender { get { return _firstApplicantGender; } set { _firstApplicantGender = value; } }
    public string FirstApplicantPhone { get { return _firstApplicantPhone; } set { _firstApplicantPhone = value; } }
    public string FirstApplicantEmail { get { return _firstApplicantEmail; } set { _firstApplicantEmail = value; } }
    public string FirstApplicantWeChat { get { return _firstApplicantWeChat; } set { _firstApplicantWeChat = value; } }
    public string SecondApplicantName { get { return _secondApplicantName; } set { _secondApplicantName = value; } }
    public string SecondApplicantGender { get { return _secondApplicantGender; } set { _secondApplicantGender = value; } }
    public string SecondApplicantPhone { get { return _secondApplicantPhone; } set { _secondApplicantPhone = value; } }
    public string SecondApplicantEmail { get { return _secondApplicantEmail; } set { _secondApplicantEmail = value; } }
    public string SecondApplicantWeChat { get { return _secondApplicantWeChat; } set { _secondApplicantWeChat = value; } }
    public string ThirdApplicantName { get { return _thirdApplicantName; } set { _thirdApplicantName = value; } }
    public string ThirdApplicantGender { get { return _thirdApplicantGender; } set { _thirdApplicantGender = value; } }
    public string ThirdApplicantPhone { get { return _thirdApplicantPhone; } set { _thirdApplicantPhone = value; } }
    public string ThirdApplicantEmail { get { return _thirdApplicantEmail; } set { _thirdApplicantEmail = value; } }
    public string ThirdApplicantWeChat { get { return _thirdApplicantWeChat; } set { _thirdApplicantWeChat = value; } }

    public string ArrivalFlighNo { get { return _arrivalFlighNo; } set { _arrivalFlighNo = value; } }
    public string ArrivalLuggages { get { return _arrivalLuggages; } set { _arrivalLuggages = value; } }
    public string ArrivalPeople { get { return _arrivalPeople; } set { _arrivalPeople = value; } }
    public string FlightArrivalTime { get { return _flightArrivalTime; } set { _flightArrivalTime = value; } }
    public string HotelAddress { get { return _hotelAddress; } set { _hotelAddress = value; } }
    public string ContactPerson { get { return _contactPerson; } set { _contactPerson = value; } }
    public string ContactNUmber { get { return _contactNUmber; } set { _contactNUmber = value; } }
    public string LeavingFlightNo { get { return _leavingFlightNo; } set { _leavingFlightNo = value; } }
    public string LeavingLuggages { get { return _leavingLuggages; } set { _leavingLuggages = value; } }
    public string LeavingPeopleNo { get { return _leavingPeopleNo; } set { _leavingPeopleNo = value; } }
    public string LeavingTime { get { return _leavingTime; } set { _leavingTime = value; } }
    public string LeavingHotelAddress { get { return _leavingHotelAddress; } set { _leavingHotelAddress = value; } }
    public string LeavingContactPerson { get { return _leavingContactPerson; } set { _leavingContactPerson = value; } }
    public string LeavingContactPersonNo { get { return _leavingContactPersonNo; } set { _leavingContactPersonNo = value; } }

    public int GroupVisiting { get { return _groupVisiting; } set { _groupVisiting = value; } }
    public int SummerCamp { get { return _summerCamp; } set { _summerCamp = value; } }
    public int EducationalPlan { get { return _educationalPlan; } set { _educationalPlan = value; } }
    public int AccountingCounsel { get { return _accountingCounsel; } set { _accountingCounsel = value; } }
    public int FinancialCounsel { get { return _financialCounsel; } set { _financialCounsel = value; } }
    public int AirportService { get { return _airportService; } set { _airportService = value; } }
    public int Eb5Visa { get { return _eb5Visa; } set { _eb5Visa = value; } }
    public int UsOfficeCounsel { get { return _usOfficeCounsel; } set { _usOfficeCounsel = value; } }
    public int EmergencyHelp { get { return _emergencyHelp; } set { _emergencyHelp = value; } }
    public int OtherService { get { return _otherService; } set { _otherService = value; } }
    public int IsChildSchool { get { return _isChildSchool; } set { _isChildSchool = value; } }

    public string NumberOfPropertiesName { get { return _numberOfPropertiesName; } set { _numberOfPropertiesName = value; } }
    public string RealEstateInsuranceUploaded { get { return _realEstateInsuranceUploaded; } set { _realEstateInsuranceUploaded = value; } }
    public string DriverLicenseUploaded { get { return _driverLicenseUploaded; } set { _driverLicenseUploaded = value; } }
    public string PictureUploaded { get { return _pictureUploaded; } set { _pictureUploaded = value; } }
    public string UserCategoryName { get { return _userCategoryName; } set { _userCategoryName = value; } }
    public int UserCategory { get { return _userCategory; } set { _userCategory = value; } }
    public int NumberofVisitingCities { get { return _numberofVisitingCities; } set { _numberofVisitingCities = value; } }
    public int FourthAgentID { get { return _fourthAgentID; } set { _fourthAgentID = value; } }
    public string FourthAgentName { get { return _fourthAgentName; } set { _fourthAgentName = value; } }
    public int FifthAgentID { get { return _fifthAgentID; } set { _fifthAgentID = value; } }
    public string FifthAgentName { get { return _fifthAgentName; } set { _fifthAgentName = value; } }
    public int SixthAgentID { get { return _sixthAgentID; } set { _sixthAgentID = value; } }
    public string SixthAgentName { get { return _sixthAgentName; } set { _sixthAgentName = value; } }

    public string OtherPropertyRequest { get { return _otherPropertyRequest; } set { _otherPropertyRequest = value; } }
    public int Atlanta { get { return _atlanta; } set { _atlanta = value; } }
    public int NewYorkState { get { return _newYorkState; } set { _newYorkState = value; } }
    public int California { get { return _california; } set { _california = value; } }
    public int Washington { get { return _washington; } set { _washington = value; } }
    public int Floridia { get { return _floridia; } set { _floridia = value; } }
    public int Massachusetts { get { return _massachusetts; } set { _massachusetts = value; } }
    public int Pennsylvania { get { return _pennsylvania; } set { _pennsylvania = value; } }
    public int BothInvstmtment { get { return _bothInvstmtment; } set { _bothInvstmtment = value; } }

    public string AcFirstName { get { return _acFristName; } set { _acFristName = value; } }
    public string AcLastName { get { return _acLastName; } set { _acLastName = value; } }
    public int SanDiego { get { return _sanDiego; } set { _sanDiego = value; } }
    public int NewJersey { get { return _newJersey; } set { _newJersey = value; } }
    public int Connecticut { get { return _connecticut; } set { _connecticut = value; } }
    public string Title1 { get { return _title1; } set { _title1 = value; } }
    public string Title2 { get { return _title2; } set { _title2 = value; } }
    public string SecurityAnswer { get { return _securityAnswer; } set { _securityAnswer = value; } }
    public string ThirdVisitHouseTime { get { return _thirdVisitHouseTime; } set { _thirdVisitHouseTime = value; } }
    public string SecondVistiHouseTime { get { return _secondVisitHouseTime; } set { _secondVisitHouseTime = value; } }
    public string FirstVisitHouseTime { get { return _firstVisitHouseTime; } set { _firstVisitHouseTime = value; } }
    public string ChineseAddress { get { return _chineseAddress; } set { _chineseAddress = value; } }
    public string ThirdAgentName { get { return _thirdAgentName; } set { _thirdAgentName = value; } }
    public string SecondAgentName { get { return _secondAgentName; } set { _secondAgentName = value; } }
    public int AssignedFourthAgent { get { return _assignedFourthAgent; } set { _assignedFourthAgent = value; } }
    public int AssignedThirdAgent { get { return _assignedThirdAgent; } set { _assignedThirdAgent = value; } }
    public int AssignedSecondAgent { get { return _assignedSecondAgent; } set { _assignedSecondAgent = value; } }
    public int ExcellentDistrict { get { return _excellentDistrict; } set { _excellentDistrict = value; } }
    public int GoodDistrict { get { return _goodDistrict; } set { _goodDistrict = value; } }
    public int GeneralDistrict { get { return _generalDistrict; } set { _generalDistrict = value; } }
    public int East { get { return _east; } set { _east = value; } }
    public int West { get { return _west; } set { _west = value; } }
    public int South { get { return _south; } set { _south = value; } }
    public int North { get { return _north; } set { _north = value; } }
    public int NorthEast { get { return _northEast; } set { _northEast = value; } }
    public int SouthEast { get { return _southEast; } set { _southEast = value; } }
    public int SouthWest { get { return _southWest; } set { _southWest = value; } }
    public int NorthWest { get { return _northWest; } set { _northWest = value; } }
    public int Hawaii { get { return _hawaii; } set { _hawaii = value; } }
    public int Chicago { get { return _chicago; } set { _chicago = value; } }

    public int Miami { get { return _miami; } set { _miami = value; } }
    public int MoveInImmediately { get { return _moveInImmediately; } set { _moveInImmediately = value; } }
    public int ThreeYears { get { return _threeYears; } set { _threeYears = value; } }
    public int FiveYears { get { return _fiveYears; } set { _fiveYears = value; } }
    public int TenYears { get { return _tenYears; } set { _tenYears = value; } }
    public int OverTenYears { get { return _overTenYears; } set { _overTenYears = value; } }
    public int NewHouse { get { return _newHouse; } set { _newHouse = value; } }

    public string CounselWeChat { get { return _counselWeChat; } set { _counselWeChat = value; } }
    public string CounselPhone { get { return _counselPhone; } set { _counselPhone = value; } }
    public int PurchaseHouseforInvestment { get { return _purchaseHouseforInvestment; } set { _purchaseHouseforInvestment = value; } }
    public int PurchaseHouseForSelf { get { return _PurchaseHouseForSelf; } set { _PurchaseHouseForSelf = value; } }
    public int EnglishAbility { get { return _englishAbility; } set { _englishAbility = value; } }
    public int SchoolDistrictType { get { return _schoolDistrictType; } set { _schoolDistrictType = value; } }
    public int InterestedHouse { get { return _interestedHouse; } set { _interestedHouse = value; } }
    public int InterestedCondo { get { return _interestedCondo; } set { _interestedCondo = value; } }
    public int InterestedTownHouse { get { return _interestedTownHouse; } set { _interestedTownHouse = value; } }
    public int InterestedApartment { get { return _interestedApartment; } set { _interestedApartment = value; } }

    public string StaffTitle { get { return _staffTitle; } set { _staffTitle = value; } }
    public int IsStaff { get { return _isStaff; } set { _isStaff = value; } }
    public int SecondChildAge { get { return _secondChildAge; } set { _secondChildAge = value; } }
    public string SecondChildGrade { get { return _secondChildGrade; } set { _secondChildGrade = value; } }
    public int ThirdChildAge { get { return _thirdChildAge; } set { _thirdChildAge = value; } }
    public string ThirdChildGrade { get { return _thirdChildGrade; } set { _thirdChildGrade = value; } }
    public string ThirdDepartDate { get { return _thirdDepartDate; } set { _thirdDepartDate = value; } }
    public string ThirdArrivalDate { get { return _thirdArrivalDate; } set { _thirdArrivalDate = value; } }
    public string ThirdDestination { get { return _thirdDestination; } set { _thirdDestination = value; } }
    public string SecondDepartDate { get { return _secondDepartDate; } set { _secondDepartDate = value; } }
    public string SecondArrivalDate { get { return _secondArrivalDate; } set { _secondArrivalDate = value; } }
    public string SecondDestination { get { return _secondDestination; } set { _secondDestination = value; } }
    public string Destination { get { return _destination; } set { _destination = value; } }

    public string DepartureDate { get { return _departureDate; } set { _departureDate = value; } }
    public string ArrivalDate { get { return _arrivalDate; } set { _arrivalDate = value; } }
    public int NumberOfProperties { get { return _numberOfProperties; } set { _numberOfProperties = value; } }
    public string AssignedAdminName { get { return _assignedAdminName; } set { _assignedAdminName = value; } }
    public string CreateClientAt { get { return _createClientat; } set { _createClientat = value; } }
    public string CreatedClientDate { get { return _createdClientDate; } set { _createdClientDate = value; } }
    public string Other { get { return _other; } set { _other = value; } }
    public string Department { get { return _department; } set { _department = value; } }
    public int CounselorID { get { return _counselorID; } set { _counselorID = value; } }
    public string Counselor { get { return _counselor; } set { _counselor = value; } }

    public string ShowInWebSite { get { return _showInWebSite; } set { _showInWebSite = value; } }
    public string Skills1 { get { return _skills1; } set { _skills1 = value; } }
    public string Skills2 { get { return _skills2; } set { _skills2 = value; } }
    public string Skills3 { get { return _skills3; } set { _skills3 = value; } }
    public string Skills4 { get { return _skills4; } set { _skills4 = value; } }
    public string Skills5 { get { return _skills5; } set { _skills5 = value; } }

    public int UserRequestID { get { return _userRequestID; } set { _userRequestID = value; } }
    public string AgentChineseLocation { get { return _agentChineseLocation; } set { _agentChineseLocation = value; } }
    public string TimeToMoveIn { get { return _timeToMoveIn; } set { _timeToMoveIn = value; } }
    public string SpecifyCityArea { get { return _specifyCityArea; } set { _specifyCityArea = value; } }
    public string PreferredSchoolDistrict { get { return _preferredSchoolDistrict; } set { _preferredSchoolDistrict = value; } }
    public string LeaseExpiredDate { get { return _leaseExpiredDate; } set { _leaseExpiredDate = value; } }
    public string InterestedProperty { get { return _interestedProperty; } set { _interestedProperty = value; } }
    public string MinPreferedPrice { get { return _minPreferedPrice; } set { _minPreferedPrice = value; } }
    public string MaxPreferredPrice { get { return _maxPreferredPrice; } set { _maxPreferredPrice = value; } }

    public string PreferredTypeHome { get { return _preferredTypeHome; } set { _preferredTypeHome = value; } }
    public string MinPreferedFootage { get { return _minPreferedFootage; } set { _minPreferedFootage = value; } }
    public string MaxPreferredFootage { get { return _maxPreferredFootage; } set { _maxPreferredFootage = value; } }
    public string PreferredBedrooms { get { return _preferredBedrooms; } set { _preferredBedrooms = value; } }
    public string PreferredBathrooms { get { return _preferredBathrooms; } set { _preferredBathrooms = value; } }
    public string PreferredGarages { get { return _preferredGarages; } set { _preferredGarages = value; } }
    public string ChineseCompanyProvince { get { return _chineseCompanyProvince; } set { _chineseCompanyProvince = value; } }
    public string PreferredState { get { return _preferredState; } set { _preferredState = value; } }
    public string PreferredCity { get { return _preferredCity; } set { _preferredCity = value; } }

    public string NeedtoSellProperty { get { return _needtoSellProperty; } set { _needtoSellProperty = value; } }
    public string CurrentlyInLease { get { return _currentlyInLease; } set { _currentlyInLease = value; } }
    public string AssistanceLocalFinance { get { return _assistanceLocalFinance; } set { _assistanceLocalFinance = value; } }
    public string HaveLiquidAsset { get { return _haveLiquidAsset; } set { _haveLiquidAsset = value; } }
    public string WantBasement { get { return _wantBasement; } set { _wantBasement = value; } }
    public string NeedFinancing { get { return _needFinancing; } set { _needFinancing = value; } }

    public string ChildAge { get { return _child1age; } set { _child1age = value; } }
    public string ChildGrade { get { return _child1Grade; } set { _child1Grade = value; } }

    public string WeChat { get { return _weChat; } set { _weChat = value; } }

    public string FullName2 { get { return _fullName2; } set { _fullName2 = value; } }
    public string ChineseName1 { get { return _chineseName1; } set { _chineseName1 = value; } }
    public string ChineseName2 { get { return _ChineseName2; } set { _ChineseName2 = value; } }

    public string CompanyTaxID
    {
        get { return _companyTaxID; }
        set { _companyTaxID = value; }
    }

    public string CompanyPhone
    {
        get { return _companyPhone; }
        set { _companyPhone = value; }
    }

    public string CompanyEmail
    {
        get { return _companyEmail; }
        set { _companyEmail = value; }
    }

    public string CompanyFax
    {
        get { return _companyFax; ; }
        set { _companyFax = value; }
    }

    public string CompanyWebSite
    {
        get { return _companyWebSite; }
        set { _companyWebSite = value; }
    }

    public string CompanyLicensedNumber
    {
        get { return _companyLicensedNumber; }
        set { _companyLicensedNumber = value; }
    }

    public string AgentLicensedNumber
    {
        get { return _agentLicensedNumber; }
        set { _agentLicensedNumber = value; }
    }


    public string CompanyName
    {
        get { return _companyName; }
        set { _companyName = value; }
    }

    public string CompanyAddress
    {
        get { return _companyAddress; }
        set { _companyAddress = value; }

    }

    public string CompanyCity
    {
        get { return _companyCity; }
        set { _companyCity = value; }
    }

    public string CompanyState
    {
        get { return _companyState; }
        set { _companyState = value; }
    }

    public string CompanyZipCode
    {
        get { return _companyZipCode; }
        set { _companyZipCode = value; }

    }

    public string CellPhone
    {
        get { return _cellPhone; }
        set { _cellPhone = value; }
    }

    public string SSN
    {
        get { return _ssn; }
        set { _ssn = value; }
    }

    public string DOB
    {
        get { return _dob; }
        set { _dob = value; }
    }


    public int ModifiedBy
    {
        get { return _modifiedBy; }
        set { _modifiedBy = value; }
    }

    public string FullName
    {
        get { return _fullName; }
        set { _fullName = value; }
    }

    public string AssignedAgentName
    {
        get { return _assignedAgentName; }
        set { _assignedAgentName = value; }
    }

    public int AssignedAgentID
    {
        get { return _assignedAgentId; }
        set { _assignedAgentId = value; }
    }

    public int AssignedAdminID
    {
        get { return _assignedAdminId; }
        set { _assignedAdminId = value; }
    }

    public string CreationDate
    {
        get { return _creationDate; }
        set { _creationDate = value; }
    }

    public string ModifiedDate
    {
        get { return _modifiedDate; }
        set { _modifiedDate = value; }
    }

    public int UserId
    {
        get { return _userId; }
        set { _userId = value; }
    }

    public string UserEmail
    {
        get { return _userEmail; }
        set { _userEmail = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Address { get { return _Address; } set { _Address = value; } }

    public string Address2 { get { return _address2; } set { _address2 = value; } }

    public string ZipCode { get { return _zipcode; } set { _zipcode = value; } }

    public string City { get { return _city; } set { _city = value; } }

    public string Country { get { return _country; } set { _country = value; } }

    public string State { get { return _state; } set { _state = value; } }

    public bool Approve { get { return _approve; } set { _approve = value; } }

    public bool Active { get { return _active; } set { _active = value; } }

    public string FaxNumber { get { return _faxNumber; } set { _faxNumber = value; } }

    public string UserType { get { return _userType; } set { _userType = value; } }

    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }

    public byte[] Portrait
    {
        get { return _portrait; }
        set { _portrait = value; }
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

    #endregion

    public void AddAnClientApplication()
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
            parm.Value = Counselor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreateClientAt;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 80);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseAddress;
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

            parm = new SqlParameter("@HousingPurchaseGuide", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HousingPurchaseGuide;
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
            parm.Value = detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenCardStatus", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyAddress;
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
            parm.Value = FirstApplicantName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstApplicantGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstApplicantPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantEmail", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstApplicantEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstApplicantWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondApplicantName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondApplicantGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondApplicantPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantEmail", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondApplicantEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondApplicantWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdApplicantName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantGender", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdApplicantGender;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdApplicantPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantEmail", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdApplicantEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdApplicantWeChat", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdApplicantWeChat;
            cmd.Parameters.Add(parm);


            cmd.ExecuteNonQuery();
            UserRequestID = int.Parse(cmd.Parameters["@userID"].Value.ToString());
        }
    }

    public void UpdateAirportService()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateAirportService", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserId;
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
            parm.Value = Counselor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreateClientAt;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseAddress;
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
            parm.Value = detailed_information;
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
            parm.Value = CompanyAddress;
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

            parm = new SqlParameter("@status", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ProcessStatus;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@adminName", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedAdminName;
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

            parm = new SqlParameter("@wlglobalID ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  WLGlobalID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalCity", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalState", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalState;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

    public void AddAirportService()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddAirportService", conn);
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
            parm.Value = Counselor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreateClientAt;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseAddress;
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

            parm = new SqlParameter("@RecommendedHousing", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RecommendedHousing;
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

            parm = new SqlParameter("@HousingPurchaseGuide", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HousingPurchaseGuide;
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
            parm.Value = detailed_information;
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

            parm = new SqlParameter("@flightArrivalTime", SqlDbType.NChar, 10);
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

            parm = new SqlParameter("@contactNUmber", SqlDbType.NChar, 20);
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

            parm = new SqlParameter("@LeavingTime", SqlDbType.NChar, 10);
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

            parm = new SqlParameter("@leavingContactPersonNo", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingContactPersonNo;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenCardStatus", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyAddress;
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

            parm = new SqlParameter("@arrivalPickupDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalPickupDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalPickTime", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  ArrivalPickTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingPickUpDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeavingPickUpDate ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leavingPickupTime", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = leavingPickupTime ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalCity", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@arrivalState", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ArrivalState;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserRequestID = int.Parse(cmd.Parameters["@userID"].Value.ToString());
        }
    }



    public void AddAUserRequest()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AddAUserRequest", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userRequestID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@requestDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreationDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@TimeToMoveIn", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TimeToMoveIn;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@specifyCityArea", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SpecifyCityArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredSchoolDistrict", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredSchoolDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedProperty", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedProperty;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@minPreferedPrice", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MinPreferedPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@maxPreferredPrice", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaxPreferredPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredTypeHome", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredTypeHome;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@minPreferedFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MinPreferedFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@maxPreferredFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaxPreferredFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wantBasement", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WantBasement;
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

            parm = new SqlParameter("@preferredState", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredSchoolDistrict", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredSchoolDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherPropertyRequest;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserRequestID = int.Parse(cmd.Parameters["@userRequestID"].Value.ToString());
        }
    }

    public void SavePassWord()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("SavePassWord", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@password", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Password;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());
        }
    }



    public void RegisterAUser()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("RegisterAUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userEmail", SqlDbType.NChar, 256);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@creationDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreationDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@approve", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Approve;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cellPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CellPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@webChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createdClientDate", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreatedClientDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securityAnswer", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecurityAnswer;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());
        }
    }

    public void UpdateAssignedAgentID()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("AssignedAgent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedAgentID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedAgentID;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
        }

    }

    public void UpdateClient()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateAClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userEmail", SqlDbType.NChar, 256);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@creationDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreationDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@approve", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Approve;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cellPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CellPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@webChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createdClientDate", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreatedClientDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securityAnswer", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecurityAnswer;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselor", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Counselor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselWeChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselPhone", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreateClientAt;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ChineseName2", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullname", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@englishAbility", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EnglishAbility;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseAddress;
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

            parm = new SqlParameter("@faxNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FaxNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@department", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Department;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolDistrictType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SchoolDistrictType;
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

            parm = new SqlParameter("@newHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedSecondAgent", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedSecondAgent;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedThirdAgent", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedThirdAgent;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstVisitHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondVistiHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdVisitHouseTime;
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

            parm = new SqlParameter("@numberofVisitingCities", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofVisitingCities;
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

            parm = new SqlParameter("@secondDestination ", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondDestination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondArrivalDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondDepartDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondDepartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdDestination", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdDestination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdArrivalDate ", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ThirddepartDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdDepartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondChildGrade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdChildGrade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1age", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1Grade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@other", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Other;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyAddress;
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

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = detailed_information;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());
        }

    }

    public void Update()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateAUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lastName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LastName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = title;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.VarChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherPropertyRequest;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@faxNumber", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FaxNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Address", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@country", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Country;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipcode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedAgentID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedAgentID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedAgentName", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedAgentName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedBy", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedBy;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.VarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cellPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CellPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullname", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyCity", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyState", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyZipCode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyPhone", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyWebSite", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyFax", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyFax;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondFullName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullName2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ChineseName2", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@weChatNo", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1age", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@child1Grade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@TimeToMoveIn", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TimeToMoveIn;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@specifyCityArea", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SpecifyCityArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredSchoolDistrict", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredSchoolDistrict;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@needtoSellProperty", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeedtoSellProperty;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@currentlyInLease", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CurrentlyInLease;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@leaseExpiredDate", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LeaseExpiredDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@interestedProperty", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = InterestedProperty;
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

            parm = new SqlParameter("@assistanceLocalFinance", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssistanceLocalFinance;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@haveLiquidAsset", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HaveLiquidAsset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredTypeHome", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredTypeHome;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@minPreferedFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MinPreferedFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@maxPreferredFootage", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaxPreferredFootage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wantBasement", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WantBasement;
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

            parm = new SqlParameter("@chineseCompanyProvince", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseCompanyProvince;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredState", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@preferredCity", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PreferredCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedAdminID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedAdminID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselor", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Counselor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@department", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Department;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@other", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Other;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createdClientDate", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreatedClientDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@createClientat", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CreateClientAt;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showAgentInWebSite", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
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

            parm = new SqlParameter("@secondDestination ", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondDestination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondArrivalDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondDepartDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondDepartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdDestination", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdDestination;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdArrivalDate ", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdArrivalDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ThirddepartDate", SqlDbType.NChar, 14);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdDepartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondChildGrade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdChildAge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdChildAge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdChildGrade", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdChildGrade;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselWeChat", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselWeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@counselPhone", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CounselPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@purchaseHouseforInvestment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PurchaseHouseforInvestment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@PurchaseHouseForSelf", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PurchaseHouseForSelf;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@englishAbility", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EnglishAbility;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolDistrictType", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SchoolDistrictType;
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

            parm = new SqlParameter("@newHouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedSecondAgent", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedSecondAgent;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@assignedThirdAgent", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AssignedThirdAgent;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstVisitHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@secondVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecondVistiHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@thirdVisitHouseTime", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThirdVisitHouseTime;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title1", SqlDbType.NChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title2", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Title2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@acFirstName", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AcFirstName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@acLastName", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AcLastName;
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

            parm = new SqlParameter("@numberofVisitingCities", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofVisitingCities;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userCategory", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserCategory;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@internal", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Internal;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@briefDesc", SqlDbType.NChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BriefDesc;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@RecommendedHousing", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RecommendedHousing;
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

            parm = new SqlParameter("@HousingPurchaseGuide", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HousingPurchaseGuide;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@usOfficeCounsel", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UsOfficeCounsel;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolReports", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = schoolReports;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherService", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OtherService;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgentID", SqlDbType.VarChar,5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClosingAgentID ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgent2", SqlDbType.VarChar,5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClosingAgent2 ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgent3", SqlDbType.VarChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClosingAgent3 ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgent4", SqlDbType.VarChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  ClosingAgent4 ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgent5", SqlDbType.VarChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ClosingAgent5 ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@closingAgent6", SqlDbType.VarChar, 5);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  ClosingAgent6;
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
            parm.Value = Orlando ;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wlGlobalID", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WLGlobalID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skillsTraining", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = skillsTraining;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@jobPlanning", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = jobPlanning;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@memberActivity", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = memberActivity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openAcccount", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = openAcccount;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@insuranceChoice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = insuranceChoice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@legalCounseling", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = legalCounseling;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@otherCity", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = otherCity;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

    public void UpdateAnAgent()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateAnAgent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lastName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LastName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar,30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.VarChar, 60);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@faxNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FaxNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Address", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@country", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Country;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipcode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedDate", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modifiedBy", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModifiedBy;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@ssn", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SSN;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dob", SqlDbType.VarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DOB;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cellPhone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CellPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyAddress", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyAddress;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyCity", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyCity;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyState", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyState;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyZipCode", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyZipCode;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@companyPhone", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyEmail", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyWebSite", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyTaxID", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyTaxID;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyLicenseNumber", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyLicensedNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@agentLicensedNumber", SqlDbType.VarChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentLicensedNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@companyFax", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CompanyFax;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@agentChineseLocation", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentChineseLocation;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@chineseName1", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ChineseName1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skills1", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Skills1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skills2", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Skills2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skills3", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Skills3;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skills4", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Skills4;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skills5", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Skills5;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showAgentInWebSite", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@weChatNo", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WeChat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserType;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

    public void Create()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("Users_Create", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = title;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@phone", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Phone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Email", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Email;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@detailed_information", SqlDbType.NChar, 400);
            parm.Direction = ParameterDirection.Input;
            parm.Value = detailed_information;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@firstName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FirstName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userType", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Bit);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lastName", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LastName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Address", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@country", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Country;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.NChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@userEmail", SqlDbType.NChar, 256);
            parm.Direction = ParameterDirection.Input;
            parm.Value = UserEmail;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@faxNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FaxNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@portrait", SqlDbType.Image);
            parm.Direction = ParameterDirection.Input;
            parm.IsNullable = true;
            parm.Value = Portrait;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            UserId = int.Parse(cmd.Parameters["@userId"].Value.ToString());
        }
    }

    public static byte[] GetPortrait(int userId)
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("User_Portrait_Retrieve", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter("@userId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = userId;
            cmd.Parameters.Add(parm);
            //      conn.Open();
            byte[] data = (byte[])cmd.ExecuteScalar();
            return data;
        }
    }
}
