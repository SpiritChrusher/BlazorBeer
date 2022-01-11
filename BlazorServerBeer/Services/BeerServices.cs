using System.Net.Http.Json;
using BlazorServerBeer.Models;

namespace BlazorServerBeer.Services;

public class BeerServices : IBeerServices
{
    private readonly HttpClient _client;
    
    public BeerServices(HttpClient client)
    {
        _client = client;
    }
    
    public async Task<List<Beer>> GetAllBeersAsync()
    {
        var list = await _client.GetFromJsonAsync<List<Beer>>("/beers");
        return list;
    }
}