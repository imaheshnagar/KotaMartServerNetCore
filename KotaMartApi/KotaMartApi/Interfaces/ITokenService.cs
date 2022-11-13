using KotaMartApi.Entities;

namespace KotaMartApi.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(KmAppUser user);
    }
}
