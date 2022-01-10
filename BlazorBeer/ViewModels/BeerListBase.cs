using BlazorBeer.Models;
using BlazorBeer.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBeer.ViewModels;

public class BeerListBase : ComponentBase
{
    public IEnumerable<Beer> Beers { get; set; }

    private IBeerServices _beerServices;

    protected override async Task OnInitializedAsync()
    {
        Beers = await _beerServices.GetAllBeersAsync();
    }

    protected void DeleteAllPatients()
    {
        Console.WriteLine("beer");
    }
}