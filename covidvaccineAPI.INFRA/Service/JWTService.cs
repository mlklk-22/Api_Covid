﻿using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository reposiytory;

        public JWTService(IJWTRepository reposiytory)
        {
            this.reposiytory = reposiytory;
        }

        public string login(Useraccount useraccount)
        {

            var result = reposiytory.login(useraccount);
            if (result == null)
            {
                return null;
            }
            else
            {

                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name, result.Username),
                     new Claim(ClaimTypes.Role, result.Roleid.ToString())
                };

                var tokeOptions = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddSeconds(60),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;

            }
        }
    }
}