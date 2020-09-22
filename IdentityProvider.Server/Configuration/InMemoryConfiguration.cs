using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProvider.Server.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResource()
        {
            return new[]{
                //defien api resource, the ip resource name needs to match ip with clientID, 
                //this is to protect not authorized users/client to access our API
                new ApiResource("FastNet","Fast Net")
            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[] {
                    new Client
                    {
                        ClientId = "FastNet",
                        ClientSecrets = new [] { new Secret("secret".Sha256())},//Specifiy secret secrets
                        //Specify what kind of flow we want to use, 
                        //we allow both client credentials allow us to get a token with only client secrets, 
                        //we also set the ablitiy to get username and password can be used to 
                        AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                        AllowedScopes = new [] {"FastNet"}
                    }
                };
        }

        public static IEnumerable<TestUser> TestUsers()
        {
            return new[] {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "mail@filipekberg.se",
                    Password = "password"
                },
                 new TestUser
                {
                    SubjectId = "2",
                    Username = "mail@niclastimle.se",
                    Password = "password"
                },
                 new TestUser
                {
                    SubjectId = "3",
                    Username = "mail@victoria.se",
                    Password = "password"
                },
                 new TestUser
                {
                    SubjectId = "4",
                    Username = "Ozzie@mail.com",
                    Password = "password"
                }
        };

        }
    }
}
