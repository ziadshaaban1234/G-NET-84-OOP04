namespace SmartDeliveryManagementSystem.Models;

public abstract class Shipment
{
    private string _trackingCode;
    private string _description;
    private decimal _weight;
    private decimal _deliveryFee;
    private DeliveryAddress _destination;

    protected Shipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        _trackingCode = ValidateText(trackingCode, nameof(trackingCode));
        _description = ValidateText(description, nameof(description));
        _weight = ValidatePositive(weight, nameof(weight));
        _deliveryFee = ValidateNonNegative(deliveryFee, nameof(deliveryFee));

        if (destination == null)
        {
            throw new ArgumentNullException(nameof(destination));
        }

        _destination = destination;
    }

    public string TrackingCode
    {
        get
        {
            return _trackingCode;
        }
        private set
        {
            _trackingCode = ValidateText(value, nameof(value));
        }
    }

    public string Description
    {
        get
        {
            return _description;
        }
        private set
        {
            _description = ValidateText(value, nameof(value));
        }
    }

    public decimal Weight
    {
        get
        {
            return _weight;
        }
        private set
        {
            _weight = ValidatePositive(value, nameof(value));
        }
    }

    public decimal DeliveryFee
    {
        get
        {
            return _deliveryFee;
        }
        private set
        {
            _deliveryFee = ValidateNonNegative(value, nameof(value));
        }
    }

    public DeliveryAddress Destination
    {
        get
        {
            return _destination;
        }
        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _destination = value;
        }
    }

    public abstract decimal EstimatedCost { get; }

    public abstract void PrintShipment();

    private static string ValidateText(string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(
                "A value is required.",
                parameterName);
        }

        return value.Trim();
    }

    private static decimal ValidatePositive(
        decimal value,
        string parameterName)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                "The value must be greater than zero.");
        }

        return value;
    }

    private static decimal ValidateNonNegative(
        decimal value,
        string parameterName)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                "The value cannot be negative.");
        }

        return value;
    }
}