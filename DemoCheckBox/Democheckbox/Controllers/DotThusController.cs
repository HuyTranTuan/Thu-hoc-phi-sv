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
    public class DotThusController : ControllerBase
    {
        // GET: api/DotThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.DotThus.Select(x => new DotThuDTO
                {
                    Id = x.Id,
                    TenDotThu = x.TenDotThu
                }).ToListAsync());
            }
        }

        // GET: api/DotThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.DotThus.Where(x => x.Id == id).Select(x => new DotThuDTO
                {
                    Id = x.Id,
                    TenDotThu = x.TenDotThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/DotThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] DotThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.DotThus.Add(new DotThu
                {
                    Id = model.Id,
                    TenDotThu = model.TenDotThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/DotThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DotThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.DotThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenDotThu = model.TenDotThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/DotThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.DotThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
