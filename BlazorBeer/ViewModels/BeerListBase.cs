using BlazorBeer.Models;
using BlazorBeer.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBeer.ViewModels;

public class BeerListBase : ComponentBase
{
    public IEnumerable<Beer> Beers { get; set; }

    [Inject]
    public IBeerServices BeerServices { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Beers = await BeerServices.GetAllBeersAsync();
    }

    protected static void DeleteAllBeers()
    {
        Console.WriteLine("beer");
    }
}