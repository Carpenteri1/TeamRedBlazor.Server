using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using TeamRedBlazor.Client.Server.Data.Models;

namespace TeamRedBlazor.Client.Server.Data.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string _ApiBaseAdress = "http://localhost:5000/api/Users";

        public UserService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient ??
            throw new System.ArgumentNullException(nameof(httpClient));
            _httpContextAccessor = httpContextAccessor ??
            throw new System.ArgumentNullException(nameof(httpContextAccessor));
        } 

        public async Task<UserModel[]> GetAllUsers()
        {
            try
            {
                string respons = await _httpClient.GetStringAsync(_ApiBaseAdress);
                var users = JsonConvert.DeserializeObject<UserModel[]>(respons);
               return users;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
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
