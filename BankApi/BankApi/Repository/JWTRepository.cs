using BankApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BankApi.Repository
{
    public class JWTRepository : IJWTRepository
    {
        private readonly UserManager<SystemUsers> _userManager;
        private readonly IConfiguration _configuration;
        public JWTRepository(UserManager<SystemUsers> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration; 
        }

        public async Task<List<Claim>> GetClaimsOFUserAsync(SystemUsers appUser)
        {
           List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name,appUser.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier,appUser.Id.ToString())); 
            IList<string> roles = await _userManager.GetRolesAsync(appUser);
            foreach (string role in roles) { 
            claims.Add(new Claim(ClaimTypes.Role,role));    
            }

            return claims;  
        }

        public async Task<string> GetJWTTokenAsync(SystemUsers appUser)
        {
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(1),
                signingCredentials: await GetSigningCredentialsAsync(),
                claims: await GetClaimsOFUserAsync(appUser)
                );
            string Token= new JwtSecurityTokenHandler().WriteToken(token);
            return Token;

          
        }

        public async Task<SigningCredentials> GetSigningCredentialsAsync()
        {

            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!));
            SigningCredentials signingCredentials=new SigningCredentials(symmetricSecurityKey,SecurityAlgorithms.HmacSha256);
            return signingCredentials;
        }
    }
}
