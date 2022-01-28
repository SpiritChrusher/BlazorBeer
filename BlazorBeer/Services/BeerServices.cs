using System.Net.Http.Json;
using BlazorBeer.Models;

namespace BlazorBeer.Services;

public class BeerServices : IBeerServices
{
    private readonly HttpClient _client;
    
    public BeerServices(HttpClient client)
    {
        _client = client;
    }
    
    public async Task<IEnumerable<Beer>> GetAllBeersAsync() => 
        await _client.GetFromJsonAsync<IEnumerable<Beer>>("/beers");

    public async Task PostBeersAsync(AddBeer addBeer) => 
        await _client.PostAsJsonAsync($"/beers", addBeer);
}