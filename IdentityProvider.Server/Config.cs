// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityModel;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityProvider.Server
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource("country", new [] { "country" })
            };


        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("IdentityProviderServer",
                    "IdentityProvider Server", 
                    new [] { "country" })
            };


        public static IEnumerable<Client> Clients =>
            new Client[]
            { 
                new Client
                {
                    ClientId = "TeamRedBlazorClientServer",
                    ClientName = "TeamRedBlazor Client Server",
                    AllowedGrantTypes = GrantTypes.Hybrid, 
                    ClientSecrets = { new Secret("108B7B4F-BEFC-4DD2-82E1-7F025F0F75D0".Sha256()) },
                    RedirectUris = { "http://localhost:59420/signin-oidc" }, 
                    PostLogoutRedirectUris = { "http://localhost:59420/signout-callback-oidc" },
                    AllowOfflineAccess = true,
                    RequireConsent = false,
                    AllowedScopes = { "openid", "profile", "email", "IdentityProvider.Server", "country" } 
                }                 
            };
    }
}