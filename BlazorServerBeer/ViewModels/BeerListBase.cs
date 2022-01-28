using System.Net.Http.Json;
using BlazorServerBeer.Models;
using BlazorServerBeer.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerBeer.ViewModels;

public class BeerListBase : ComponentBase
{
    public List<Beer> Beers { get; set; }

    [Inject]
    public IBeerServices BeerServices { get; set; }
    
    [Inject]
    public HttpClient Client { get; set; }

    protected override async Task OnInitializedAsync()
    {
       // Beers = await Client.GetFromJsonAsync<IEnumerable<Beer>>("/beers");
        Beers = await BeerServices.GetAllBeersAsync();
    }

    protected static void DeleteAllBeers()
    {
        Console.WriteLine("beer");
    }
}