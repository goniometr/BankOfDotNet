using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfDotNetIdentitySvr
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("bankOfDotNetApi", "Customer API for bankOfDotNetApi")
            };
        }

        public static List<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
                {
                    new IdentityResource()   { Name = "bankOfDotNetApi" },
                    new IdentityResources.Profile(),
                    new IdentityResources.OpenId()
                };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                       ClientId = "client",
                       AllowedGrantTypes = GrantTypes.ClientCredentials,
                       ClientSecrets =
                       {
                            new Secret("secret".ToSha256())
                       },
                       AllowedScopes = new List<string>() {"bankOfDotNetApi" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
            new ApiScope("bankOfDotNetApi", "Read Access to API #1"),
                        new ApiScope("api1.write", "Write Access to API #1")
        };
        }
    }
}
