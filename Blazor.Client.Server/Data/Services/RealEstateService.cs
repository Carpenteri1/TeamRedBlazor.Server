using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;
using TeamRedBlazor.Client.Server.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;

namespace TeamRedBlazor.Client.Server.Data.Services
{
    [Authorize]
    public class RealEstateService
    {
        private const string _ApiUrlBase = "http://localhost:5000/api/RealEstates";
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RealEstateService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<RealEstateModel> GetRealEstateDetailAsync(int id)
        {
            try
            {
                return await System.Text.Json.JsonSerializer.DeserializeAsync<RealEstateModel>
             (await _httpClient.GetStreamAsync(_ApiUrlBase), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                /*
                string respons = await _httpClient.GetStringAsync(_ApiUrlBase);
                RealEstateModel realEstate = JsonConvert.DeserializeObject<RealEstateModel>(respons);
                return realEstate;*/
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            return null;
        }


        public async Task<RealEstateModel[]> GetRealEstateAsync()
        {
            try
            {
                return await System.Text.Json.JsonSerializer.DeserializeAsync<RealEstateModel[]>
             (await _httpClient.GetStreamAsync(_ApiUrlBase), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                /*
                string respons = await _httpClient.GetStringAsync(_ApiUrlBase);
                RealEstateModel [] realEstates = JsonConvert.DeserializeObject<RealEstateModel[]>(respons);
                return realEstates;  */
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            return null;
        }
    }
}
