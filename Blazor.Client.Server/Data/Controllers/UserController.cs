using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamRedBlazor.Client.Server.Data.Models;
using TeamRedBlazor.Client.Server.Data.Services;

namespace TeamRedBlazor.Client.Server.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserService service;
        public UserController(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }
        /*
        [HttpGet]
        public async Task<UserModel[]> Get()
        {
            return await service.GetAllUsers();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Hello";
        }

        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "Hello World!";
        }


        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Hello Galaxy!";
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Hello Universe!";
        }*/
    }
}
