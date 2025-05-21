using BankApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace BankApi.Repository
{
    public interface IJWTRepository
    {
        Task<string> GetJWTTokenAsync( SystemUsers appUser);
        Task<List<Claim>> GetClaimsOFUserAsync(SystemUsers appUser);
        Task<SigningCredentials> GetSigningCredentialsAsync();
    }
}
