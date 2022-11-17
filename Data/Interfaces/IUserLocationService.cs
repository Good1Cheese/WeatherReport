using Data.Models;

namespace Data.Interfaces;

public interface IUserLocationService
{
    Task<UserLocation> Get();
}
