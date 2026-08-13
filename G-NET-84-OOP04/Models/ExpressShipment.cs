using SmartDeliveryManagementSystem.Contracts;

namespace SmartDeliveryManagementSystem.Models;

public class ExpressShipment : Shipment, ITrackable, IInsurable
{
    public ExpressShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        if (extraFee < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(extraFee),
                "The extra fee cannot be negative.");
        }

        ExtraFee = extraFee;
    }

    public decimal ExtraFee { get; }

    public override decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + ExtraFee;
        }
    }

    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} is Out for Delivery.";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.08m;
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment");
        Console.WriteLine();
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Extra Fee     : {ExtraFee:0.##} EGP");
        Console.WriteLine($"Estimated Cost: {EstimatedCost:0.##} EGP");
    }
}