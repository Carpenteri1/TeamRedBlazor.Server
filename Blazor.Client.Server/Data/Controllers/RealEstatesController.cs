using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamRedBlazor.Client.Server.Data.Models;
using TeamRedBlazor.Client.Server.Data.Services;

namespace TeamRedBlazor.Client.Server.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstatesController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        RealEstateModel realEstate = new RealEstateModel();
        public RealEstatesController(HttpClient httpClient, IHttpContextAccessor httpContextAccessor) 
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<RealEstateModel[]> GetRealEstates()
        {
            RealEstateService service = new RealEstateService(_httpClient);
            var realEstateFromRepo = await service.GetRealEstateAsync();
            return realEstateFromRepo;
        }

        [HttpGet("{id}")]
        public  async Task<RealEstateModel> Get(int id)
        {
            RealEstateService  service = new RealEstateService(_httpClient);
            realEstate = await service.GetRealEstateDetailAsync(id);
            return  realEstate;
        }/*

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
