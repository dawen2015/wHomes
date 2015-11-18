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
/// Summary description for Property
/// </summary>
/// 
public class DisplayedProperty
{
    #region "Member Variables"

    private int _PropertyId;
    private string _start_date;
    private string _address;
    private string _city;
    private string _propertyTitle;
    private string _state;
    private int _agentId;
    private string _category;
    private string _agentName;
    private string _direction;
    private int _maintence_fees;
    private int _down_payment;
    private int _price;
    private string _listing_Type;
    private int _outdoorSpace;
    private int _rooms;
    private int _beds;
    private int _baths;
    private int _area_size;
    private float _bathRooms;
    private int _doorman;
    private int _elevator;
    private int _garage;
    private int _active;
    private int _realEstateTaxes;
    private string _propertyLocation;
    private string _propertyMoneyStr;
    private string _showinWebSite;
    private int _numberofGarages;
    private string _propertyLocationInChinese;


    #endregion

    #region "Properties"

    public int NumberofGarages { get { return _numberofGarages; } set { _numberofGarages = value; } }

    public string ShowInWebSite { get { return _showinWebSite; } set { _showinWebSite = value; } }

    public string PriceMoneyStr { get { return _propertyMoneyStr; } set { _propertyMoneyStr = value; } }

    public int Price { get { return _price; } set { _price = value; } }

    public string PropertyLocation { get { return _propertyLocation; } set { _propertyLocation = value; } }

    public string Listing_Type { get { return _listing_Type; } set { _listing_Type = value; } }

    public int Rooms { get { return _rooms; } set { _rooms = value; } }
    public int Beds { get { return _beds; } set { _beds = value; } }
    public int Baths { get { return _baths; } set { _baths = value; } }
    public int Area_size { get { return _area_size; } set { _area_size = value; } }

    public int Doorman { get { return _doorman; } set { _doorman = value; } }

    public int Elevator { get { return _elevator; } set { _elevator = value; } }
    public int Garage { get { return _garage; } set { _garage = value; } }

    public int Active { get { return _active; } set { _active = value; } }

    public int AgentId { get { return _agentId; } set { _agentId = value; } }
    public string Category { get { return _category; } set { _category = value; } }
    public string AgentName { get { return _agentName; } set { _agentName = value; } }
    public string ClientName { get { return _direction; } set { _direction = value; } }
    public int MaintenceFees { get { return _maintence_fees; } set { _maintence_fees = value; } }
    public int DownPayment { get { return _down_payment; } set { _down_payment = value; } }

    public int PropertyId { get { return _PropertyId; } set { _PropertyId = value; } }
    public string StartDate { get { return _start_date; } set { _start_date = value; } }
    public string Address { get { return _address; } set { _address = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string PropertyTitle { get { return _propertyTitle; } set { _propertyTitle = value; } }
    public string State { get { return _state; } set { _state = value; } }
    public int RealEstateTaxes { get { return _realEstateTaxes; } set { _realEstateTaxes = value; } }
    public string PropertyLocationInChinese { get { return _propertyLocationInChinese; } set { _propertyLocationInChinese = value; } }


    #endregion

}
public class Property
{
    #region "Member Variables"

    private string _lotSize;
    private int _patio;
    private int _PropertyId;
    private string _start_date;
    private string _address;
    private string _city;
    private string _propertyTitle;
    private string _propertyDescription;
    private string _state;
    private string _zipCode;
    private int _agentId;
    private string _category;
    private string _agentName;
    private string _direction;
    private int _pet_friendly;
    private int _maintence_fees;
    private int _down_payment;

    private int _price;
    private string _closingPrice;

    private string _listing_Type;

    private int _outdoorSpace;

    private int _rooms;
    private int _beds;
    private int _baths;
    private int _area_size;
    private float _bathRooms;

    private int _doorman;

    private int _elevator;
    private int _garage;

    private int _active;

    private int _realEstateTaxes;
    private int _commonChanges;
    private int _valet;
    private int _parkView;
    private int _oceanView;
    private int _laundry;
    private int _buildingUnits;
    private int _buildingYear;
    private int _greenBuilding;
    private int _newDevelopment;
    private int _studioApartmentRentPrice;
    private int _studioApartmentSalePrice;
    private int _oneBedroomApartmentRentPrice;
    private int _oneBedroomApartmentSalePrice;
    private int _twoBedroomApartmentRentPrice;
    private int _twoBedroomApartmentSalePrice;
    private int _threeBedroomApartmentRentPrice;
    private int _threeBedroomApartmentSalePrice;
    private int _fourBedroomApartmentRentPrice;
    private int _fourBedroomApartmentSalePrice;
    private string _buildingSpecifrics;
    private string _similarbuildingsIds;
    private string _neighborhoodTitle;
    private string _neighborhookDescription;
    private string _buildingOwnership;
    private string _propertyLocation;
    private string _propertyMoneyStr;
    private string _propertyBriefDesc;
    private string _showinWebSite;
    private int _numberofGarages;
    private int _diningRoom;
    private int _furnished;
    private int _dishwasher;
    private int _hardwood;
    private int _highCeilings;
    private int _marbleBath;
    private int _graniteKitchen;
    private int _eatInKitchen;
    private int _walkInCloset;
    private int _healthClub;
    private int _bicycleRoom;
    private int _storage;
    private int _wiFi;
    private int _laundryInUnit;
    private int _pool;
    private int _garden;
    private int _commonOutdoorSpace;
    private int _openView;
    private int _privateDeck;
    private int _balcony;
    private int _terrace;


    private int _Lounge;
    private int _fireplace;
    private string _chineseDesc;
    private string _propertyLocationInChinese;
    private int _basement;
    private int _triplex;
    private int _outdoorArea;
    private int _centralAir;
    private int _skylineView;
    private int _securityGuard;
    private int _excellentLight;
    private int _fullCityView;
    private int _library;
    private int _newWindows;
    private int _modernKitchen;
    private int _securitySystem;
    private int _wheelChairAccessible;
    private int _duplex;
    private int _julietBalcony;
    private int _office;
    private int _oversizedWindows;
    private int _concierge;
    private int _gasFireplace;
    private int _partialCityView;
    private int _partialParkView;
    private int _partialRiverView;
    private int _cableReady;
    private int _commonCourtYard;
    private int _commonGarden;
    private int _packageRoom;
    private int _commonRoofDeck;
    private int _highSpeedInternet;
    private int _renovatedBathRoom;
    private string _propertyViewType;
    private string _propertyDirection;
    private string _chineseStateName;
    private int _numberOfFloors;
    private int _livingrooms;
    private float _chineseYenPrice;
    private string _constructionType;
    private int _parkingSlots;
    private int _heat;
    private int _courtYard;
    private int _penthouse;

    private string _apartmentNumber;
    private string _coAgentUsername;
    private int _mlNumber;
    private string _amenities;
    private int _attic;
    private string _auxilaryRooms;
    private int _beachRights;
    private string _brokerPhone;
    private string _basementSufloor;
    private string _condition;
    private string _construction;
    private int _dockingRights;
    private int _carpet;
    private int _driveWay;
    private int _dryer;
    private string _floor1;
    private string _floor2;
    private string _floor3;
    private string _fees;
    private int _fence;
    private string _heatType;
    private string _kitchenType;
    private string _lotSquareFeet;
    private string _modelname;
    private int _porch;
    private int _privateEntrance;
    private string _schoolDistrictNumber;
    private string _schoolDistrictName;
    private string _style;

    #endregion

    #region "Properties"

    public string LotSize  { get { return _lotSize; } set { _lotSize = value; } }
    public int Patio { get { return _patio; } set { _patio = value; } }
    public string Style { get { return _style; } set { _style = value; } }

    public string SchoolDistrictNumber { get { return _schoolDistrictNumber; } set { _schoolDistrictNumber = value; } }
    public string SchoolDistricttName { get { return _schoolDistrictName; } set { _schoolDistrictName = value; } }
    public int PrivateEntrance { get { return _privateEntrance; } set { _privateEntrance = value; } }
    public int Porch { get { return _porch; } set { _porch = value; } }
    public string ModelName { get { return _modelname; } set { _modelname = value; } }
    public string LotSquareFeet { get { return _lotSquareFeet; } set { _lotSquareFeet = value; } }

    public string KitchenType { get { return _kitchenType; } set { _kitchenType = value; } }

    public string HeatType { get { return _heatType; } set { _heatType = value; } }
    public string Floor1 { get { return _floor1; } set { _floor1 = value; } }
    public string Floor2 { get { return _floor2; } set { _floor2 = value; } }
    public string Floor3 { get { return _floor3; } set { _floor3 = value; } }
    public string Fees { get { return _fees; } set { _fees = value; } }
    public int Fence { get { return _fence; } set { _fence = value; } }

    public int Dryer { get { return _dryer; } set { _dryer = value; } }

    public int DriveWay { get { return _driveWay; } set { _driveWay = value; } }

    public int Carpet { get { return _carpet; } set { _carpet = value; } }


    public int DockingRights { get { return _dockingRights; } set { _dockingRights = value; } }

    public string Construction { get { return _construction; } set { _construction = value; } }

    public string Condition { get { return _condition; } set { _condition = value; } }

    public string BasementSufloor { get { return _basementSufloor; } set { _basementSufloor = value; } }

    public string BrokerPhone { get { return _brokerPhone; } set { _brokerPhone = value; } }
    public int BeachRights { get { return _beachRights; } set { _beachRights = value; } }
    public string AuxilaryRooms { get { return _auxilaryRooms; } set { _auxilaryRooms = value; } }
    public int Attic { get { return _attic; } set { _attic = value; } }
    public string Amenities { get { return _amenities; } set { _amenities = value; } }
    public int MlNumber { get { return _mlNumber; } set { _mlNumber = value; } }
    public string CoAgentUsername { get { return _coAgentUsername; } set { _coAgentUsername = value; } }
    public string ApartmentNumber { get { return _apartmentNumber; } set { _apartmentNumber = value; } }
    public float BathRooms { get { return _bathRooms; } set { _bathRooms = value; } }
    public int PentHouse { get { return _penthouse; } set { _penthouse = value; } }
    public int CourtYard { get { return _courtYard; } set { _courtYard = value; } }
    public int Heat { get { return _heat; } set { _heat = value; } }
    public string ConstructionType { get { return _constructionType; } set { _constructionType = value; } }
    public int ParkingSlots { get { return _parkingSlots; } set { _parkingSlots = value; } }

    public float ChineseYenPrice { get { return _chineseYenPrice; } set { _chineseYenPrice = value; } }
    public int Livingrooms { get { return _livingrooms; } set { _livingrooms = value; } }
    public int NumberOfFloors { get { return _numberOfFloors; } set { _numberOfFloors = value; } }
    public string ChineseStateName { get { return _chineseStateName; } set { _chineseStateName = value; } }

    public string PropertyViewType { get { return _propertyViewType; } set { _propertyViewType = value; } }
    public string PropertyDirection { get { return _propertyDirection; } set { _propertyDirection = value; } }
    public int CentralAir { get { return _centralAir; } set { _centralAir = value; } }
    public int SkylineView { get { return _skylineView; } set { _skylineView = value; } }
    public int SecurityGuard { get { return _securityGuard; } set { _securityGuard = value; } }
    public int ExcellentLight { get { return _excellentLight; } set { _excellentLight = value; } }
    public int FullCityView { get { return _fullCityView; } set { _fullCityView = value; } }
    public int Library { get { return _library; } set { _library = value; } }
    public int NewWindows { get { return _newWindows; } set { _newWindows = value; } }
    public int ModernKitchen { get { return _modernKitchen; } set { _modernKitchen = value; } }
    public int SecuritySystem { get { return _securitySystem; } set { _securitySystem = value; } }
    public int WheelChairAccessible { get { return _wheelChairAccessible; } set { _wheelChairAccessible = value; } }
    public int Duplex { get { return _duplex; } set { _duplex = value; } }
    public int JulietBalcony { get { return _julietBalcony; } set { _julietBalcony = value; } }
    public int Office { get { return _office; } set { _office = value; } }
    public int OversizedWindows { get { return _oversizedWindows; } set { _oversizedWindows = value; } }
    public int Concierge { get { return _concierge; } set { _concierge = value; } }
    public int GasFireplace { get { return _gasFireplace; } set { _gasFireplace = value; } }
    public int PartialCityView { get { return _partialCityView; } set { _partialCityView = value; } }
    public int PartialParkView { get { return _partialParkView; } set { _partialParkView = value; } }
    public int PartialRiverView { get { return _partialRiverView; } set { _partialRiverView = value; } }
    public int CableReady { get { return _cableReady; } set { _cableReady = value; } }
    public int CommonCourtYard { get { return _commonCourtYard; } set { _commonCourtYard = value; } }
    public int CommonGarden { get { return _commonGarden; } set { _commonGarden = value; } }
    public int PackageRoom { get { return _packageRoom; } set { _packageRoom = value; } }
    public int CommonRoofDeck { get { return _commonRoofDeck; } set { _commonRoofDeck = value; } }
    public int HighSpeedInternet { get { return _highSpeedInternet; } set { _highSpeedInternet = value; } }
    public int RenovatedBathRoom { get { return _renovatedBathRoom; } set { _renovatedBathRoom = value; } }

    public int OutdoorArea { get { return _outdoorArea; } set { _outdoorArea = value; } }
    public int Basement { get { return _basement; } set { _basement = value; } }
    public string PropertyLocationInChinese { get { return _propertyLocationInChinese; } set { _propertyLocationInChinese = value; } }
    public string ChineseDesc { get { return _chineseDesc; } set { _chineseDesc = value; } }
    public int DiningRoom { get { return _diningRoom; } set { _diningRoom = value; } }
    public int Furnished { get { return _furnished; } set { _furnished = value; } }
    public int Dishwasher { get { return _dishwasher; } set { _dishwasher = value; } }
    public int Hardwood { get { return _hardwood; } set { _hardwood = value; } }
    public int HighCeilings { get { return _highCeilings; } set { _highCeilings = value; } }
    public int MarbleBath { get { return _marbleBath; } set { _marbleBath = value; } }
    public int GraniteKitchen { get { return _graniteKitchen; } set { _graniteKitchen = value; } }
    public int EatInKitchen { get { return _eatInKitchen; } set { _eatInKitchen = value; } }
    public int WalkInCloset { get { return _walkInCloset; } set { _walkInCloset = value; } }
    public int HealthClub { get { return _healthClub; } set { _healthClub = value; } }
    public int BicycleRoom { get { return _bicycleRoom; } set { _bicycleRoom = value; } }
    public int Storage { get { return _storage; } set { _storage = value; } }
    public int WiFi { get { return _wiFi; } set { _wiFi = value; } }
    public int LaundryInUnit { get { return _laundryInUnit; } set { _laundryInUnit = value; } }
    public int Pool { get { return _pool; } set { _pool = value; } }
    public int Garden { get { return _garden; } set { _garden = value; } }
    public int CommonOutdoorSpace { get { return _commonOutdoorSpace; } set { _commonOutdoorSpace = value; } }
    public int OpenView { get { return _openView; } set { _openView = value; } }
    public int PrivateDeck { get { return _privateDeck; } set { _privateDeck = value; } }
    public int Balcony { get { return _balcony; } set { _balcony = value; } }
    public int Terrace { get { return _terrace; } set { _terrace = value; } }
    public int OutdoorSpace { get { return _outdoorSpace; } set { _outdoorSpace = value; } }
    public int Lounge { get { return _Lounge; } set { _Lounge = value; } }
    public int Fireplace { get { return _fireplace; } set { _fireplace = value; } }
    public int Triplex { get { return _triplex; } set { _triplex = value; } }

    public int NumberofGarages { get { return _numberofGarages; } set { _numberofGarages = value; } }

    public string ShowInWebSite { get { return _showinWebSite; } set { _showinWebSite = value; } }

    public string PropertyBriefDesc { get { return _propertyBriefDesc; } set { _propertyBriefDesc = value; } }

    public string PriceMoneyStr { get { return _propertyMoneyStr; } set { _propertyMoneyStr = value; } }

    public int Price { get { return _price; } set { _price = value; } }

    public string PropertyLocation { get { return _propertyLocation; } set { _propertyLocation = value; } }

    public string ClosingPrice { get { return _closingPrice; } set { _closingPrice = value; } }

    public string Listing_Type { get { return _listing_Type; } set { _listing_Type = value; } }



    public int Rooms { get { return _rooms; } set { _rooms = value; } }
    public int Beds { get { return _beds; } set { _beds = value; } }
    public int Baths { get { return _baths; } set { _baths = value; } }
    public int Area_size { get { return _area_size; } set { _area_size = value; } }

    public int Doorman { get { return _doorman; } set { _doorman = value; } }

    public int Elevator { get { return _elevator; } set { _elevator = value; } }
    public int Garage { get { return _garage; } set { _garage = value; } }

    public int Active { get { return _active; } set { _active = value; } }

    public int AgentId { get { return _agentId; } set { _agentId = value; } }
    public string Category { get { return _category; } set { _category = value; } }
    public string AgentName { get { return _agentName; } set { _agentName = value; } }
    public string ClientName { get { return _direction; } set { _direction = value; } }
    public int PetFriendly { get { return _pet_friendly; } set { _pet_friendly = value; } }
    public int MaintenceFees { get { return _maintence_fees; } set { _maintence_fees = value; } }
    public int DownPayment { get { return _down_payment; } set { _down_payment = value; } }

    public int PropertyId { get { return _PropertyId; } set { _PropertyId = value; } }
    public string StartDate { get { return _start_date; } set { _start_date = value; } }
    public string Address { get { return _address; } set { _address = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string PropertyTitle { get { return _propertyTitle; } set { _propertyTitle = value; } }
    public string PropertyDescription { get { return _propertyDescription; } set { _propertyDescription = value; } }
    public string State { get { return _state; } set { _state = value; } }
    public string ZipCode { get { return _zipCode; } set { _zipCode = value; } }

    public int RealEstateTaxes { get { return _realEstateTaxes; } set { _realEstateTaxes = value; } }
    public int CommonChanges { get { return _commonChanges; } set { _commonChanges = value; } }
    public int Valet { get { return _valet; } set { _valet = value; } }
    public int ParkView { get { return _parkView; } set { _parkView = value; } }
    public int OceanView { get { return _oceanView; } set { _oceanView = value; } }
    public int Laundry { get { return _laundry; } set { _laundry = value; } }
    public int BuildingUnits { get { return _buildingUnits; } set { _buildingUnits = value; } }
    public int BuildingYear { get { return _buildingYear; } set { _buildingYear = value; } }
    public int GreenBuilding { get { return _greenBuilding; } set { _greenBuilding = value; } }
    public int NewDevelopment { get { return _newDevelopment; } set { _newDevelopment = value; } }
    public int StudioApartmentRentPrice { get { return _studioApartmentRentPrice; } set { _studioApartmentRentPrice = value; } }
    public int StudioApartmentSalePrice { get { return _studioApartmentSalePrice; } set { _studioApartmentSalePrice = value; } }
    public int OneBedroomApartmentRentPrice { get { return _oneBedroomApartmentRentPrice; } set { _oneBedroomApartmentRentPrice = value; } }
    public int OneBedroomApartmentSalePrice { get { return _oneBedroomApartmentSalePrice; } set { _oneBedroomApartmentSalePrice = value; } }
    public int TwoBedroomApartmentRentPrice { get { return _twoBedroomApartmentRentPrice; } set { _twoBedroomApartmentRentPrice = value; } }
    public int TwoBedroomApartmentSalePrice { get { return _twoBedroomApartmentSalePrice; } set { _twoBedroomApartmentSalePrice = value; } }
    public int ThreeBedroomApartmentRentPrice { get { return _threeBedroomApartmentRentPrice; } set { _threeBedroomApartmentRentPrice = value; } }
    public int ThreeBedroomApartmentSalePrice { get { return _threeBedroomApartmentSalePrice; } set { _threeBedroomApartmentSalePrice = value; } }
    public int FourBedroomApartmentRentPrice { get { return _fourBedroomApartmentRentPrice; } set { _fourBedroomApartmentRentPrice = value; } }
    public int FourBedroomApartmentSalePrice { get { return _fourBedroomApartmentSalePrice; } set { _fourBedroomApartmentSalePrice = value; } }
    public string BuildingSpecifrics { get { return _buildingSpecifrics; } set { _buildingSpecifrics = value; } }
    public string SimilarbuildingsIds { get { return _similarbuildingsIds; } set { _similarbuildingsIds = value; } }
    public string NeighborhoodTitle { get { return _neighborhoodTitle; } set { _neighborhoodTitle = value; } }
    public string NeighborhookDescription { get { return _neighborhookDescription; } set { _neighborhookDescription = value; } }
    public string BuildingOwnership { get { return _buildingOwnership; } set { _buildingOwnership = value; } }


    #endregion

    public void Update()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdatePropertyValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@propertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@address", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipCode", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@areaSize", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Area_size;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@listingType", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Listing_Type;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mainteenceFee", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaintenceFees;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@downPayment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DownPayment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@rooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Rooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beds", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Beds;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@baths", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Baths;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@realEstateTaxes", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RealEstateTaxes;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonChanges", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonChanges;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhoodTitle", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhoodTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhookDescription", SqlDbType.NChar, 500);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhookDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@doorman", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Doorman;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@petFriendly", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PetFriendly;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@elevator", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Elevator;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@valet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Valet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oceanView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OceanView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundry", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Laundry;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenBuilding", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenBuilding;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newDevelopment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewDevelopment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingUnits", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingUnits;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingYear", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingYear;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentRentPrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentSalePrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingOwnership", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingOwnership;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingSpecifrics", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingSpecifrics;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocation", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocation;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofGarages", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofGarages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@diningRoom ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DiningRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@furnished", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Furnished;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dishwasher ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Dishwasher;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@hardwood ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Hardwood;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highCeilings", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighCeilings;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@marbleBath", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MarbleBath;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@graniteKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GraniteKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eatInKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EatInKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@walkInCloset", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WalkInCloset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@healthClub", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HealthClub;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bicycleRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BicycleRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@storage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Storage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wiFi", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WiFi;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundryInUnit", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LaundryInUnit;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@pool", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Pool;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garden", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garden;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonOutdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonOutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@privateDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PrivateDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@balcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Balcony;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@terrace ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Terrace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Lounge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Lounge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@triplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Triplex;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocationinChinese", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocationInChinese;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@basement", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Basement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorArea", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securityGuard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecurityGuard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oversizedWindows", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OversizedWindows;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@concierge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Concierge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@gasFireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GasFireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modernKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModernKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newWindows", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewWindows;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highSpeedInternet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighSpeedInternet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@renovatedBathRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RenovatedBathRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@centralAir", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CentralAir;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wheelChairAccessible", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WheelChairAccessible;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@excellentLight", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ExcellentLight;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@duplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Duplex;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@office", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Office;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@packageRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PackageRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@julietBalcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = JulietBalcony;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skylineView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SkylineView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialCityView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialCityView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialParkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialParkView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialRiverView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialRiverView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonRoofDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonRoofDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullCityView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullCityView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyViewType", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyViewType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyDirection", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDirection;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securitySystem", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;

            parm.Value = SecuritySystem;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@library", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Library;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cableReady", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CableReady;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofFloors", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberOfFloors;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@livingRooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Livingrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkingSlots", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkingSlots;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@constructionType", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ConstructionType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heat", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Heat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@courtYard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CourtYard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@penthouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PentHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bathrooms", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BathRooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@apartmentNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ApartmentNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@coAgentUsername", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CoAgentUsername;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lotSize", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value =  LotSize;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beachRights", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BeachRights;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@patio", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Patio;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

    public void Create()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("CreateProperty", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@PropertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@address", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipCode", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@areaSize", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Area_size;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@listingType", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Listing_Type;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mainteenceFee", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaintenceFees;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@downPayment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DownPayment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@rooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Rooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beds", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Beds;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@baths", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Baths;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@doorman", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Doorman;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@elevator", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Elevator;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@petFriendly", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PetFriendly;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@realEstateTaxes", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RealEstateTaxes;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonChanges", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonChanges;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@valet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Valet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oceanView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OceanView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundry", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Laundry;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingUnits", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingUnits;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingYear", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingYear;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenBuilding", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenBuilding;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newDevelopment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewDevelopment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentRentPrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentSalePrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingOwnership", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingOwnership;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhoodTitle", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhoodTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhookDescription", SqlDbType.NChar, 500);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhookDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingSpecifrics", SqlDbType.VarChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingSpecifrics;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@uploadDate", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocation", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocation;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofGarages", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofGarages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@diningRoom ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DiningRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@furnished", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Furnished;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dishwasher ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Dishwasher;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@hardwood ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Hardwood;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highCeilings", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighCeilings;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@marbleBath", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MarbleBath;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@graniteKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GraniteKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eatInKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EatInKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@walkInCloset", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WalkInCloset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@healthClub", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HealthClub;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bicycleRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BicycleRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@storage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Storage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wiFi", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WiFi;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundryInUnit", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LaundryInUnit;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@pool", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Pool;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garden", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garden;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonOutdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonOutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@privateDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PrivateDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@balcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Balcony;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@terrace ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Terrace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Lounge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Lounge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@triplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Triplex;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocationinChinese", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocationInChinese;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@basement", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Basement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorArea", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyViewType", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyViewType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyDirection", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDirection;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securitySystem", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecuritySystem;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@library", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Library;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cableReady", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CableReady;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofFloors", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberOfFloors;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@livingRooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Livingrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkingSlots", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkingSlots;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@constructionType", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ConstructionType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heat", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Heat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@courtYard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CourtYard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@penthouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PentHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bathrooms", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BathRooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@apartmentNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ApartmentNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@coAgentUsername", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CoAgentUsername;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lotSize", SqlDbType.NChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LotSize;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beachRights", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BeachRights;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@patio", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Patio;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();
            PropertyId = int.Parse(cmd.Parameters["@propertyId"].Value.ToString());
        }
    }

    public void UpdateMLProperty()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("UpdateMLPropertyValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@propertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyId;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@address", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@title", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipCode", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@areaSize", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Area_size;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@listingType", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Listing_Type;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mainteenceFee", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaintenceFees;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@downPayment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DownPayment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@rooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Rooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beds", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Beds;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@baths", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Baths;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@realEstateTaxes", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RealEstateTaxes;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonChanges", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonChanges;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhoodTitle", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhoodTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhookDescription", SqlDbType.NChar, 500);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhookDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@doorman", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Doorman;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@petFriendly", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PetFriendly;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@elevator", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Elevator;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@valet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Valet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oceanView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OceanView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundry", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Laundry;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@greenBuilding", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenBuilding;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newDevelopment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewDevelopment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingUnits", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingUnits;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingYear", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingYear;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentRentPrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentSalePrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingOwnership", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingOwnership;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingSpecifrics", SqlDbType.VarChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingSpecifrics;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocation", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocation;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofGarages", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofGarages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@diningRoom ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DiningRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@furnished", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Furnished;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dishwasher ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Dishwasher;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@hardwood ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Hardwood;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highCeilings", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighCeilings;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@marbleBath", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MarbleBath;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@graniteKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GraniteKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eatInKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EatInKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@walkInCloset", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WalkInCloset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@healthClub", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HealthClub;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bicycleRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BicycleRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@storage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Storage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wiFi", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WiFi;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundryInUnit", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LaundryInUnit;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@pool", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Pool;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garden", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garden;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonOutdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonOutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@privateDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PrivateDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@balcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Balcony;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@terrace ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Terrace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Lounge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Lounge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@triplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Triplex;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocationinChinese", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocationInChinese;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@basement", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Basement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@outdoorArea", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securityGuard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecurityGuard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oversizedWindows", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OversizedWindows;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@concierge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Concierge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@gasFireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GasFireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modernKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModernKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newWindows", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewWindows;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highSpeedInternet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighSpeedInternet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@renovatedBathRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RenovatedBathRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@centralAir", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CentralAir;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wheelChairAccessible", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WheelChairAccessible;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@excellentLight", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ExcellentLight;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@duplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Duplex;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@office", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Office;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@packageRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PackageRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@julietBalcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = JulietBalcony;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@skylineView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SkylineView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialCityView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialCityView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialParkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialParkView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@partialRiverView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PartialRiverView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonRoofDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonRoofDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fullCityView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FullCityView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyViewType", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyViewType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyDirection", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDirection;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securitySystem", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;

            parm.Value = SecuritySystem;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@library", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Library;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cableReady", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CableReady;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofFloors", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberOfFloors;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@livingRooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Livingrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkingSlots", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkingSlots;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@constructionType", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ConstructionType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heat", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Heat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@courtYard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CourtYard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@penthouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PentHouse;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bathrooms", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BathRooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@apartmentNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ApartmentNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@coAgentUsername", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CoAgentUsername;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mlNumber", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MlNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Amenities", SqlDbType.VarChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Amenities;
            cmd.Parameters.Add(parm);

            cmd.ExecuteNonQuery();

        }
    }

    public void CreateMLProperty()
    {
        using (SqlConnection conn = ConnectionManager.GetDataBaseConnection())
        {
            SqlCommand cmd = new SqlCommand("CreateMLProperty", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@PropertyId", SqlDbType.Int);
            parm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@AgentName", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AgentName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@description", SqlDbType.NChar, 1000);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@active", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Active;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Price", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Price;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@address", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Address;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@city", SqlDbType.VarChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = City;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@state", SqlDbType.VarChar, 2);
            parm.Direction = ParameterDirection.Input;
            parm.Value = State;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@zipCode", SqlDbType.VarChar, 12);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ZipCode;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@areaSize", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Area_size;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@rooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Rooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beds", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Beds;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bathrooms", SqlDbType.Float);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BathRooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@apartmentNumber", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ApartmentNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@basement", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Basement;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mlNumber", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MlNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@uploadDate", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StartDate;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@showinWebSite", SqlDbType.VarChar, 4);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ShowInWebSite;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@Amenities", SqlDbType.VarChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Amenities;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@attic", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Attic;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@auxilaryRooms", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = AuxilaryRooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@beachRights", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BeachRights;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@brokerPhone", SqlDbType.VarChar, 13);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BrokerPhone;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@basementSufloor", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BasementSufloor;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@cableReady", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CableReady;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@downPayment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DownPayment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@coAgentUsername", SqlDbType.NChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CoAgentUsername;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@category", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Category;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonChanges", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonChanges;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@condition", SqlDbType.VarChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Condition;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@construction", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Construction;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@privateDeck", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PrivateDeck;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dishwasher ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Dishwasher;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dockingRights", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DockingRights;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@carpet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Carpet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@driveWay", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DriveWay;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@dryer", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Dryer;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@eatInKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = EatInKitchen;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@elevator", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Elevator;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fees", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fees;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@furnished", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Furnished;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@floor1", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Floor1;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@floor2", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Floor2;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@floor3", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Floor3;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fence", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fence;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wheelChairAccessible", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WheelChairAccessible;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heat", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Heat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heatType", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HeatType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@kitchenType", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = KitchenType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@lotSquareFeet", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LotSquareFeet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@listingType", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Listing_Type;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@mainteenceFee", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MaintenceFees;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@modelName", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ModelName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@numberofFloors", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberOfFloors;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@terrace ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Terrace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@petFriendly", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PetFriendly;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@pool", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Pool;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@porch", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Porch;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@privateEntrance", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PrivateEntrance;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolDistrictName", SqlDbType.VarChar, 30);
            parm.Direction = ParameterDirection.Input;
            parm.Value = _schoolDistrictName;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@schoolDistrictNumber", SqlDbType.VarChar, 10);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SchoolDistrictNumber;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@style", SqlDbType.VarChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Style;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@realEstateTaxes", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = RealEstateTaxes;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundry", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Laundry;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oceanView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OceanView;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingYear", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingYear;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocation", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocation;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyLocationinChinese", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyLocationInChinese;
            cmd.Parameters.Add(parm);

            /*
             * 
             *      parm = new SqlParameter("@baths", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Baths;
            cmd.Parameters.Add(parm);
             * 
            parm = new SqlParameter("@outdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorSpace;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@listingType", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Listing_Type;
            cmd.Parameters.Add(parm);




            parm = new SqlParameter("@doorman", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Doorman;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@elevator", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Elevator;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@garage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garage;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@valet", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Valet;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkView;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@buildingUnits", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingUnits;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@greenBuilding", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GreenBuilding;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@newDevelopment", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NewDevelopment;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@studioApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = StudioApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@oneBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OneBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@twoBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = TwoBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentRentPrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@threeBedroomApartmentSalePrice ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ThreeBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentRentPrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentRentPrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fourBedroomApartmentSalePrice", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = FourBedroomApartmentSalePrice;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingOwnership", SqlDbType.NChar, 50);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingOwnership;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhoodTitle", SqlDbType.NChar, 100);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhoodTitle;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@neighborhookDescription", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NeighborhookDescription;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@buildingSpecifrics", SqlDbType.NChar, 255);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BuildingSpecifrics;
            cmd.Parameters.Add(parm);

           


            parm = new SqlParameter("@numberofGarages", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = NumberofGarages;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@diningRoom ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = DiningRoom;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@hardwood ", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Hardwood;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@highCeilings", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HighCeilings;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@marbleBath", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = MarbleBath;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@graniteKitchen", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = GraniteKitchen;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@walkInCloset", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WalkInCloset;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@healthClub", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = HealthClub;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@bicycleRoom", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = BicycleRoom;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@storage", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Storage;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@wiFi", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = WiFi;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@laundryInUnit", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = LaundryInUnit;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@garden", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Garden;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@commonOutdoorSpace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CommonOutdoorSpace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@openView", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OpenView;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@balcony", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Balcony;
            cmd.Parameters.Add(parm);


            parm = new SqlParameter("@Lounge", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Lounge;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@fireplace", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Fireplace;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@triplex", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Triplex;
            cmd.Parameters.Add(parm);



            parm = new SqlParameter("@outdoorArea", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = OutdoorArea;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyViewType", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyViewType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@propertyDirection", SqlDbType.NChar, 20);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PropertyDirection;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@securitySystem", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = SecuritySystem;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@library", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Library;
            cmd.Parameters.Add(parm);



            parm = new SqlParameter("@livingRooms", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Livingrooms;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@parkingSlots", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ParkingSlots;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@constructionType", SqlDbType.NChar, 15);
            parm.Direction = ParameterDirection.Input;
            parm.Value = ConstructionType;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@heat", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = Heat;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@courtYard", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = CourtYard;
            cmd.Parameters.Add(parm);

            parm = new SqlParameter("@penthouse", SqlDbType.Int);
            parm.Direction = ParameterDirection.Input;
            parm.Value = PentHouse;
            cmd.Parameters.Add(parm);



      
            */
            cmd.ExecuteNonQuery();
            PropertyId = int.Parse(cmd.Parameters["@propertyId"].Value.ToString());
        }
    }


}