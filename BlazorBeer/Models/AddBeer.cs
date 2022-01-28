namespace BlazorBeer.Models;

public class AddBeer
{
    public string Name { get; set; }
    public decimal Alcohol { get; set; }
    public IEnumerable<string> Taste { get; set; }
    public string Origin { get; set; }
    public IEnumerable<string> Type { get; set; }
    public string Manufacturer { get; set; }
    public string Consumption { get; set; }
    public int Price { get; set; }
    public decimal Quality { get; set; }
    public IEnumerable<string> Acquisition { get; set; }
    public decimal PackFormat { get; set; }
}