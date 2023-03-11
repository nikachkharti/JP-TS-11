using FastFood.Models;

namespace FastFood.Service.Interfaces
{
    public interface IDataConnection
    {
        Task<General> GetBalance();
    }
}
