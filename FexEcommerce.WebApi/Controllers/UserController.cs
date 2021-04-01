using AutoMapper;
using FexEcommerce.Data;
using FexEcommerce.Data.Interfaces;
using FexEcommerce.Dtos;
using FexEcommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FexEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FlexEcommerceContext _context;
        private IUserRepositories _userRepositories;
        private readonly IMapper _mapper;
        
        public UserController(FlexEcommerceContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UserDto>>> Get()
        {
            try
            {
                var users = await _userRepositories.GetUsersAsync();
                return _mapper.Map<List<UserDto>>(users);
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Post(UserDto userDto)
        {
            try
            {
                var user = _mapper.Map<User>(userDto);
                var userNew = await _userRepositories.SaveUserAsync(user);
                if(userNew == null)
                {
                    return BadRequest();
                }
                var newuserDto = _mapper.Map<UserDto>(user);
                return CreatedAtAction(nameof(Post), new { newuserDto.ID }, newuserDto);
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }

    }
}
