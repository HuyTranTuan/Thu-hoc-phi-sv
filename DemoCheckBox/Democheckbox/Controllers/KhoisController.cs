using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Democheckbox;
using Democheckbox.Model;
using Democheckbox.Dto;

namespace Democheckbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoisController : ControllerBase
    {
        // GET: api/Khois
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.Khois.Select(x => new KhoiDTO
                {
                    Id = x.Id,
                    TenKhoi = x.TenKhoi
                }).ToListAsync());
            }
        }

        // GET: api/Khois/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.Khois.Where(x => x.Id == id).Select(x => new KhoiDTO
                {
                    Id = x.Id,
                    TenKhoi = x.TenKhoi
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/Khois
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.Khois.Add(new Khoi
                {
                    Id = model.Id,
                    TenKhoi = model.TenKhoi
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/Khois/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.Khois.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenKhoi = model.TenKhoi;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/Khois/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.Khois.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
