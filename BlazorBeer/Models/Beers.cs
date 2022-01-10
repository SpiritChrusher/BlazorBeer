namespace BlazorBeer.Models;

public record Beer(
    string name,
    decimal alcohol,
    IEnumerable<string> taste,
    string origin,
    IEnumerable<string> type,
    string manufacturer,
    string consumption,
    int price,
    decimal quality,
    IEnumerable<string> acquisition,
    decimal packFormat
);