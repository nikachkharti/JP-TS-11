using FastFood.Models;

namespace FastFood.Service.Interfaces
{
    public interface IGeneralRepository
    {
        Task<General> GetBalance();
    }
}
