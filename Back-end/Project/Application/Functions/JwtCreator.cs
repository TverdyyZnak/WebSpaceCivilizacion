using Entities;
using Entities.Classes;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions
{
    public class JwtCreator
    {
        public string CreateJwt(User user)
        {
            var claim = new List<Claim> 
            {
                new Claim("Login", user.login),
                new Claim("Email", user.email),
                new Claim("Id", user.id.ToString()),
                new Claim("IsAdmin", user.isAdmin.ToString())
            };

            var jwt = new JwtSecurityToken
            (
                expires: DateTime.UtcNow.Add(Constants._timeSpan),
                claims: claim,
                signingCredentials: new SigningCredentials
                (
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constants._jwtKey)),
                    SecurityAlgorithms.HmacSha256
                ) 
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
