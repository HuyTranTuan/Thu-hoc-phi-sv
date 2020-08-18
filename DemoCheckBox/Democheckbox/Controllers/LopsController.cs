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
    public class LopsController : ControllerBase
    {
        // GET: api/Lops
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.Lops.Select(x => new LopDTO
                {
                    Id = x.Id,
                    TenLop = x.TenLop,
                    IdKhoi = x.IdKhoi
                }).ToListAsync());
            }
        }

        // GET: api/Lops/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.Lops.Where(x => x.Id == id).Select(x => new LopDTO
                {
                    Id = x.Id,
                    TenLop = x.TenLop,
                    IdKhoi = x.IdKhoi
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/Lops
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] LopDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.Lops.Add(new Lop
                {
                    Id = model.Id,
                    TenLop = model.TenLop,
                    IdKhoi = model.IdKhoi
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/Lops/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LopDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.Lops.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenLop = model.TenLop;
                user.IdKhoi = model.IdKhoi;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/Lops/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.Lops.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
