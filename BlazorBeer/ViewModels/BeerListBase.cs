using System.Net.Http.Json;
using BlazorBeer.Models;
using BlazorBeer.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBeer.ViewModels;

public class BeerListBase : ComponentBase
{
    public IEnumerable<Beer> Beers { get; set; }

    [Inject]
    public IBeerServices BeerServices { get; set; }
    
    [Inject]
    public HttpClient Client { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Beers = await Client.GetFromJsonAsync<IEnumerable<Beer>>("/beers");
       // Beers = await BeerServices.GetAllBeersAsync();
    }

    protected static void DeleteAllBeers()
    {
        Console.WriteLine("beer");
    }
}