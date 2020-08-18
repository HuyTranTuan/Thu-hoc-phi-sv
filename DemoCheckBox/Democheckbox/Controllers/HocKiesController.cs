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
    public class HocKiesController : ControllerBase
    {
        // GET: api/HocKies
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HocKies.Select(x => new HocKyDTO
                {
                    Id = x.Id,
                    TenHocKy = x.TenHocKy
                }).ToListAsync());
            }
        }

        // GET: api/HocKies/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HocKies.Where(x => x.Id == id).Select(x => new HocKyDTO
                {
                    Id = x.Id,
                    TenHocKy = x.TenHocKy
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/HocKies
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] HocKyDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.HocKies.Add(new HocKy
                {
                    Id = model.Id,
                    TenHocKy = model.TenHocKy
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/HocKies/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] HocKyDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HocKies.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenHocKy = model.TenHocKy;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/HocKies/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HocKies.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
