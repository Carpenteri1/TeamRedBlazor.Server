using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TeamRedBlazor.Server.Data.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient ??
            throw new System.ArgumentNullException(nameof(httpClient));
            _httpContextAccessor = httpContextAccessor ??
            throw new System.ArgumentNullException(nameof(httpContextAccessor));
        }

    }
}
