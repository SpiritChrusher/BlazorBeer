using BlazorBeer.Models;

namespace BlazorBeer.Services;

public interface IBeerServices
{
    public Task<List<Beer>> GetAllBeersAsync();
}