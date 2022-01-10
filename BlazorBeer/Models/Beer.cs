namespace BlazorBeer.Models;

public record Beer(
    string Name,
    decimal Alcohol,
    IEnumerable<string> Taste,
    string Origin,
    IEnumerable<string> Type,
    string Manufacturer,
    string Consumption,
    int Price,
    decimal Quality,
    IEnumerable<string> Acquisition,
    decimal PackFormat
);