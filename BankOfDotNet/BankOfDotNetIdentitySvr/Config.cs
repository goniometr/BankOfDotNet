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
                new ApiResource("bankOfDotNet.Api", "Customer API for bankOfDotNet")
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
                       AllowedScopes ={ "bankOfDotNet.Api" }
                }
            };
        }
    }
}
