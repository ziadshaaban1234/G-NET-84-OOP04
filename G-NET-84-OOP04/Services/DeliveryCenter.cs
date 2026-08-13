using SmartDeliveryManagementSystem.Contracts;
using SmartDeliveryManagementSystem.Models;

namespace SmartDeliveryManagementSystem.Services;

public class DeliveryCenter
{
    private readonly List<Shipment> _shipments = new List<Shipment>();

    public IReadOnlyList<Shipment> Shipments => _shipments;

    public void AddShipment(Shipment shipment)
    {
        ArgumentNullException.ThrowIfNull(shipment);
        _shipments.Add(shipment);
    }

    public void PrintShipmentDetails()
    {
        for (int index = 0; index < _shipments.Count; index++)
        {
            _shipments[index].PrintShipment();

            if (index < _shipments.Count - 1)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            }
        }
    }

    public void PrintTrackingStatuses()
    {
        foreach (Shipment shipment in _shipments)
        {
            ITrackable trackableShipment = (ITrackable)shipment;
            Console.WriteLine(trackableShipment.GetTrackingStatus());
        }
    }
}