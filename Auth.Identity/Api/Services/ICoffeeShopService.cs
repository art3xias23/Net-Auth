using Api.Models;

namespace Api.Services
{
    public interface ICoffeeShopService
    {
        Task<List<CoffeeShopModel>> List();
    }
}
