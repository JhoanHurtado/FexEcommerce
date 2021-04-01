using FexEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FexEcommerce.Data.Interfaces
{
    public interface ICityReposirories
    {
        Task<List<City>> getCitiesAsync();
        Task<City> getCityAsync(int id);
        Task<City> addCity(City city);
        Task<bool> updateCity(City city);
        Task<bool> deleteCity(int id);
    }
}
