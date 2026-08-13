namespace SmartDeliveryManagementSystem.Models;

public class DeliveryAddress
{
    public DeliveryAddress(string street, string city, string country)
    {
        Street = ValidateValue(street, nameof(street));
        City = ValidateValue(city, nameof(city));
        Country = ValidateValue(country, nameof(country));
    }

    public string Street { get; }

    public string City { get; }

    public string Country { get; }

    public override string ToString()
    {
        return $"{Street}, {City}, {Country}";
    }

    private static string ValidateValue(string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(
                "A delivery address value is required.",
                parameterName);
        }

        return value.Trim();
    }
}