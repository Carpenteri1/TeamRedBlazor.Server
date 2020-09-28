using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TeamRedBlazor.Client.Server.Data.Models
{
    public class MockDataService 
    {
        private List<UserModel> _users;
        private List<RealEstateModel> _realEstate;

        private IEnumerable<UserModel> Users
        {
            get
            {
                if (_users == null)
                    InitializeEmployees();
                return _users;
            }
        }

        private List<RealEstateModel> RealEstates
        {
            get
            {
                if (_realEstate == null)
                    InitializeCountries();
                return _realEstate;
            }
        }

        private void InitializeCountries()
        {
            _realEstate = new List<RealEstateModel>
            {
                new RealEstateModel {Id=1,
                    Title="Bästa platsen på jorden",
                    Address = "Tonavägen",
                    adCreated =DateTime.Now,
                    CanBePurchased = false,
                    CanBeRented =true,
                    ConstructionYear ="1989",
                    Contact ="someone",
                    Description="something",
                    PurchasePrice= 0,
                    RentingPrice=7000,
                    Type=0},
                  new RealEstateModel {Id=2,
                    Title="Grymplats",
                    Address = "Agustvägen 12",
                    adCreated =DateTime.Now,
                    CanBePurchased = false,
                    CanBeRented =true,
                    ConstructionYear ="1952",
                    Contact ="someone",
                    Description="something",
                    PurchasePrice= 0,
                    RentingPrice=7000,
                    Type=1},
                    new RealEstateModel {Id=3,
                    Title="Fint utsikt",
                    Address = "Grusgatan 21",
                    adCreated =DateTime.Now,
                    CanBePurchased = true,
                    CanBeRented =false,
                    ConstructionYear ="2020",
                    Contact ="someone",
                    Description="something",
                    PurchasePrice= 1101000,
                    RentingPrice=0,
                    Type=2},
                      new RealEstateModel {Id=4,
                    Title="ett två tree grymt att see",
                    Address = "Grimfredsgatan",
                    adCreated =DateTime.Now,
                    CanBePurchased = true,
                    CanBeRented =false,
                    ConstructionYear ="2010",
                    Contact ="someone",
                    Description="something",
                    PurchasePrice= 800000,
                    RentingPrice=0,
                    Type=0}
            };
        }

        private void InitializeEmployees()
        {
            if (_users == null)
            {
                _users = new List<UserModel>
                {
                    new UserModel{Id = 1,UserName = "Scriptmaster3000",Email ="script@portas.com",Password="password"},
                    new UserModel{Id = 2,UserName = "Niclastimle",Email = "niclast@gmail.com",Password = "password"},
                    new UserModel{Id = 3,UserName = "Victoria89",Email="ToricaÄrBäst@gmail.com", Password = "password"},
                    new UserModel{Id = 4, UserName = "Döden",Email = "Döden@hotmail.com", Password ="password"},
                    new UserModel{Id = 5, UserName = "Jesus", Email = "jagärGudsson@.com", Password ="password"},
                    new UserModel{Id = 6,UserName = "HasseArro", Email = "HasseArro@hotmail.com", Password = "password"},
                    new UserModel{Id = 7, UserName = "Gurra12", Email ="Gurra@hotmail.com",Password ="password"},
                    new UserModel{Id = 8, UserName = "Druffen", Email ="Druffen@hotmail.com",Password ="password"},
                    new UserModel{Id = 9, UserName = "HerrLind", Email ="Kevin@gmail.com",Password ="password"},
                    new UserModel{Id = 10,UserName = "Micke", Email ="Stockis92@gmail.com",Password ="password"},
                };
            }
        }

        public async Task<IEnumerable<UserModel>> GetAllEmployees()
        {
            return await Task.Run(() => Users);
        }

        public async Task<List<RealEstateModel>> GetAllCountries()
        {
            return await Task.Run(() => RealEstates);
        }

        public async Task<UserModel> GetEmployeeDetails(int inputId)
        {
            return await Task.Run(() => { return Users.FirstOrDefault(user => user.Id == inputId); });
        }

        public Task<UserModel> AddEmployee(UserModel newUser)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(UserModel updateUser)
        {
            throw new NotImplementedException();
        }
    }
}
