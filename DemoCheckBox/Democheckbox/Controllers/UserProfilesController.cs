using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Democheckbox;
using Democheckbox.Domain;
using Democheckbox.Dto;

namespace Democheckbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.UserProfiles.Where(x => x.Id == id).Select(x => new UserProfileDTO
                {
                    Id = x.Id,
                    Username = x.Username,
                    Email = x.Email,
                    Firstname = x.Firstname,
                    Lastname = x.Lastname,
                    Address = x.Address,
                    City = x.City,
                    Country = x.Country,
                    Salary = x.Salary,
                    AboutMe = x.AboutMe
                }).FirstOrDefaultAsync());
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.UserProfiles.Select(x => new UserProfileDTO
                {
                    Id = x.Id,
                    Username = x.Username,
                    Email = x.Email,
                    Firstname = x.Firstname,
                    Lastname = x.Lastname,
                    Address = x.Address,
                    City = x.City,
                    Country = x.Country,
                    Salary = x.Salary,
                    AboutMe = x.AboutMe
                }).ToListAsync());
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] UserProfileDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.UserProfiles.Add(new UserProfile
                {
                    Id = model.Id,
                    Username = model.Username,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Address = model.Address,
                    City = model.City,
                    Country = model.Country,
                    Salary = model.Salary,
                    AboutMe = model.AboutMe
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UserProfileDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.UserProfiles.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                    user.Id = model.Id;
                    user.Username = model.Username;
                    user.Email = model.Email;
                    user.Firstname = model.Firstname;
                    user.Lastname = model.Lastname;
                    user.Address = model.Address;
                    user.City = model.City;
                    user.Country = model.Country;
                    user.Salary = model.Salary;
                    user.AboutMe = model.AboutMe;
                return Ok(await context.SaveChangesAsync());
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.UserProfiles.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
