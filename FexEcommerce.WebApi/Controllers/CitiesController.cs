﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FexEcommerce.Data;
using FexEcommerce.Models;
using FexEcommerce.Data.Interfaces;
using FexEcommerce.Dtos;
using AutoMapper;

namespace FexEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {     
        private ICityReposirories _citiesReposiTories;
        private IMapper _mapper;

        public CitiesController(ICityReposirories cityReposirories, IMapper mapper)
        {
            _citiesReposiTories = cityReposirories;
            _mapper = mapper;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetCities()
        {
            try
            {
                var cities = await _citiesReposiTories.getCitiesAsync();
                return _mapper.Map<List<CityDto>>(cities);

            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

    //    // GET: api/Cities/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<City>> GetCity(int id)
    //    {
    //        var city = await _context.Cities.FindAsync(id);

    //        if (city == null)
    //        {
    //            return NotFound();
    //        }

    //        return city;
    //    }

    //    // PUT: api/Cities/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutCity(int id, City city)
    //    {
    //        if (id != city.ID)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(city).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!CityExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/Cities
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    //    [HttpPost]
    //    public async Task<ActionResult<City>> PostCity(City city)
    //    {
    //        _context.Cities.Add(city);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetCity", new { id = city.ID }, city);
    //    }

    //    // DELETE: api/Cities/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<City>> DeleteCity(int id)
    //    {
    //        var city = await _context.Cities.FindAsync(id);
    //        if (city == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Cities.Remove(city);
    //        await _context.SaveChangesAsync();

    //        return city;
    //    }

    //    private bool CityExists(int id)
    //    {
    //        return _context.Cities.Any(e => e.ID == id);
    //    }
    }
}
