using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DE.IDP
{
    public class Config
    {
        public static List<TestUser> GetUsers()
           {
               return new List<TestUser>
               {
                   new TestUser
                   {
                       SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                       Username = "Frank",
                       Password = "password",
                       Claims = new List<Claim>
                       {
                          new Claim("given_name", "Frank"),
                          new Claim("family_name", "Underwood"),
                       }
                    },
                    new TestUser
                    {
                        SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                        Username = "Claire",
                        Password = "password",
                        Claims = new List<Claim>
                        {
                           new Claim("given_name", "Claire"),
                           new Claim("family_name", "Underwood"),
                        }
                   }                   
               };
           }

         public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
               {
                   new Client
                   {
                       ClientName = "Diamond Edge Service",
                       AccessTokenType = AccessTokenType.Reference,
                       AllowedGrantTypes = GrantTypes.Implicit,
                       AllowAccessTokensViaBrowser = true,
                       RedirectUris = new List<string>
                   {
                       "http://localhost:8080"
                   },
                   PostLogoutRedirectUris = new List<string>
                   {
                        "http://localhost:8080/Unauthorized"
                   },
                   AllowedCorsOrigins = new List<string>
                   {
                         "http://localhost:8080"
                   },
                   AllowedScopes =  new List<string>
                   {
                       "openid",
                       "dataEventRecords",
                       "dataeventrecordsscope",
                       "securedFiles",
                       "securedfilesscope",
                       "role"
                   }

               }
           };
        }
    }
}
