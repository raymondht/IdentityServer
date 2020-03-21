using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class IdentityServer
    {
        public IEnumerable<ApiResource> GetApis() =>
            new List<ApiResource> 
            {
                new ApiResource("ApiOne"),
            };

        public static IEnumerable<Client> GetClients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client_id",
                    ClientSecrets = { new Secret("client_secret".ToSha256()) }
                }
            };
    }
}
