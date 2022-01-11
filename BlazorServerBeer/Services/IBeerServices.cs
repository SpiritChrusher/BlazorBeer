using BlazorServerBeer.Models;

namespace BlazorServerBeer.Services;

public interface IBeerServices
{
    public Task<List<Beer>> GetAllBeersAsync();
}