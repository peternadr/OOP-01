namespace OOP_01.DeliveryManagementSystem;

 public struct DeliveryAdress
{
    #region Fields

    public string Street;
    public int BuildingNumber;
    public string City;

    #endregion

    #region Constructors
    public DeliveryAdress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }
    #endregion

    #region Methods
    public string GetFullAddress()
    {
        return $"{BuildingNumber} {Street}, {City}";
    }


    //public void printAdress()
    //{
    //    Console.WriteLine($"City: {City} Street: {Street} Building number is: {BuildingNumber} ");
    //} 
    #endregion
}

public struct Shipment
{
    #region Fields
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;




    #endregion

    #region Properties
    public DeliveryAdress Destination { get; set; }

    public string TrackingCode
    {
        get
        {
            return trackingCode;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                trackingCode = value;
            }
        }
    }
    public string Description
    {
        get
        {
            return description;
        }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }
    }

    public decimal Weight
    {
        get
        {
            return weight;
        }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }
        private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }

    public decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5);
        }
    }
    #endregion

    #region Constructors

    public Shipment(string trackingCode) : this()
    {
        TrackingCode = trackingCode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = default;
    }

    public Shipment(DeliveryAdress destination, string trackingCode, string description, decimal weight, decimal deliveryFee) : this()
    {
        Destination = destination;
        TrackingCode = trackingCode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
    }


    #endregion

    #region Methods
    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }
    }

    public void PrintShipment()
    {
        Console.WriteLine($"Tracking code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} KG");
        Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated cost: {EstimatedCost} EGP");
    }

    #endregion
}