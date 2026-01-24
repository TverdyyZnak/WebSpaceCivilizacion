using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions
{
    public static class AuthExtensions
    {
        public static IServiceCollection AddAuth(this IServiceCollection services) 
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
            {
                o.TokenValidationParameters = new()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constants._jwtKey))
                };

                o.Events = new JwtBearerEvents 
                {
                    OnMessageReceived = context =>
                    {
                        context.Token = context.Request.Cookies["MCook"];

                        return Task.CompletedTask;
                    }
                };

            });

            services.AddAuthorization();
            return services;
        }

    }
}
