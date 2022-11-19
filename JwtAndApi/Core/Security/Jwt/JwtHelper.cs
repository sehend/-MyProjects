﻿using Core.Extensions;
using Core.Model;
using Core.Security.Encyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Core.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration configuration { get; set; }

        public TokenOptions _TokenOptions;

        DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            this.configuration = configuration;

            _TokenOptions = configuration.GetSection("TokenOptions").Get<TokenOptions>();

            _accessTokenExpiration = DateTime.Now.AddMinutes(_TokenOptions.AccessTokenExpiration);
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_TokenOptions.SecurityKey);

            var signingCredentials = SigningCredentialsHelper.CreateSigningCredential(securityKey);

            var jwt = CreateJwtSecurityToken(_TokenOptions, user, signingCredentials, operationClaims);

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,

                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var Jwt = new JwtSecurityToken(issuer: tokenOptions.Issuer, audience: tokenOptions.Audience, expires: _accessTokenExpiration, notBefore: DateTime.Now, claims: SetClaims(user, operationClaims), signingCredentials: signingCredentials);

            return Jwt;



        }

        public IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaim)
        {
            var claims = new List<Claim>();
            {
                claims.AddNameIdentifier(user.Id.ToString());

                claims.AddEmail(user.Email);

                claims.AddName($"{user.FirstName} {user.LastName}");

                claims.AddRoles(operationClaim.Select(c => c.Name).ToArray());

                return claims;


            }
        }


    }
}
