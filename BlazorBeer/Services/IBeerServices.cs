using BlazorBeer.Models;

namespace BlazorBeer.Services;

public interface IBeerServices
{
    public Task<IEnumerable<Beer>> GetAllBeersAsync();
}