using SmartDeliveryManagementSystem.Contracts;
using SmartDeliveryManagementSystem.Models;
using SmartDeliveryManagementSystem.Services;

namespace SmartDeliveryManagementSystem;

internal static class Program
{
    private const string Separator = "==========================================";

    private static void Main()
    {
        StandardShipment standard = new StandardShipment(
            "SH001",
            "Laptop",
            2.5m,
            95m,
            new DeliveryAddress("10 Tahrir Street", "Cairo", "Egypt"));

        ExpressShipment express = new ExpressShipment(
            "SH002",
            "Medical Supplies",
            1.2m,
            70m,
            new DeliveryAddress("25 Nile Street", "Giza", "Egypt"),
            30m);

        InternationalShipment international = new InternationalShipment(
            "SH003",
            "Documents",
            0.8m,
            200m,
            new DeliveryAddress("12 Alexanderplatz", "Berlin", "Germany"));

        DeliveryCenter center = new DeliveryCenter();

        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);

        DeliveryReport report = new DeliveryReport();

        ITrackable[] trackingList =
        {
            standard,
            express,
            international
        };

        IInsurable[] insuranceList =
        {
            standard,
            express,
            international
        };

        Console.WriteLine(Separator);
        Console.WriteLine("Delivery Center");
        Console.WriteLine(Separator);
        Console.WriteLine();

        center.PrintShipmentDetails();

        Console.WriteLine();
        Console.WriteLine(Separator);
        Console.WriteLine("Tracking Status");
        Console.WriteLine(Separator);
        Console.WriteLine();

        foreach (ITrackable shipment in trackingList)
        {
            report.PrintShipment(shipment);
        }

        Console.WriteLine();
        Console.WriteLine(Separator);
        Console.WriteLine("Insurance");
        Console.WriteLine(Separator);
        Console.WriteLine();

        foreach (IInsurable shipment in insuranceList)
        {
            report.PrintInsurance(shipment);
        }

        Console.WriteLine();
        Console.WriteLine(Separator);
        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
    }
}