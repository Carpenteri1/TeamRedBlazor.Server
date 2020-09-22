using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;
using TeamRedBlazor.Client.Server.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace TeamRedBlazor.Client.Server.Data.Services
{
    [Authorize]
    public class RealEstateService
    {
        private const string _ApiUrlBase = "http://localhost:5000/";
        private readonly HttpClient _httpClient;
        public RealEstateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RealEstateModel> GetRealEstateDetailAsync(int id)
        {
            RealEstateModel realEstate;
            string sUrl = _ApiUrlBase + "api/RealEstate/"+id;
            try
            {
                string response = await _httpClient.GetStringAsync(sUrl);
                realEstate = JsonConvert.DeserializeObject<RealEstateModel>(response);
                return realEstate;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
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

            RealEstateModel [] realEstates;
            string sUrl = _ApiUrlBase + "api/RealEstates";

            try
            {
                    string respons = await _httpClient.GetStringAsync(sUrl);
                if(respons != null)
                {realEstates = JsonConvert.DeserializeObject<RealEstateModel[]>(respons);
                    return realEstates;
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(HttpRequestException e)
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
