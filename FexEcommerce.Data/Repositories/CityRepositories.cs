using FexEcommerce.Data.Interfaces;
using FexEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FexEcommerce.Data.Repositories
{
    public class CityRepositories : ICityReposirories
    {
        private FlexEcommerceContext _context;

        public CityRepositories(FlexEcommerceContext context)
        {
            _context = context;
        }

        public async Task<City> addCity(City city)
        {
            _context.Cities.Add(city);
            try
            {
                await _context.SaveChangesAsync();
            }catch(Exception ex)
            {
                ;
            }
            return city;
        }

        public async Task<bool> deleteCity(int id)
        {
            var city = await _context.Cities.SingleOrDefaultAsync(c => c.ID == id);

            return true;
        }

        public async Task<List<City>> getCitiesAsync()
        {
            return await _context.Cities.Include(c => c.Department).OrderBy(u => u.Name).ToListAsync();
        }

        public async Task<City> getCityAsync(int id)
        {
            return await _context.Cities.SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<bool> updateCity(City city)
        {
            _context.Cities.Attach(city);
            _context.Entry(city).State = EntityState.Modified;
            try
            {
                return await _context.SaveChangesAsync() > 0 ? true : false;
            }catch(Exception ex)
            {

            }
            return false;
        }
    }
}
