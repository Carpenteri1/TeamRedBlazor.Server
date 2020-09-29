using System.Threading.Tasks;
using TeamRedBlazor.Client.Server.Data.Models;

namespace TeamRedBlazor.Client.Server.Data.Services
{
    public interface IRealEstateService
    {
        Task<RealEstateModel[]> GetRealEstateAsync();
        Task<RealEstateModel> GetRealEstateDetailAsync(int id);
    }
}