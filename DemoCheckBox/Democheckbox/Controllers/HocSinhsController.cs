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
    public class HocSinhsController : ControllerBase
    {
        // GET: api/HocSinhs
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HocSinhs.Select(x => new HocSinhDTO
                {
                    Id = x.Id,
                    TenHocSinh = x.TenHocSinh,
                    NgaySinh = x.NgaySinh,
                    GioiTinh = x.GioiTinh,
                    IdLop = x.IdLop
                }).ToListAsync());
            }
        }

        // GET: api/HocSinhs/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HocSinhs.Where(x => x.Id == id).Select(x => new HocSinhDTO
                {
                    Id = x.Id,
                    TenHocSinh = x.TenHocSinh,
                    NgaySinh = x.NgaySinh,
                    GioiTinh = x.GioiTinh,
                    IdLop = x.IdLop
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/HocSinhs
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] HocSinhDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.HocSinhs.Add(new HocSinh
                {
                    Id = model.Id,
                    TenHocSinh = model.TenHocSinh,
                    NgaySinh = model.NgaySinh,
                    GioiTinh = model.GioiTinh,
                    IdLop = model.IdLop
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/HocSinhs/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] HocSinhDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HocSinhs.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenHocSinh = model.TenHocSinh;
                user.NgaySinh = model.NgaySinh;
                user.GioiTinh = model.GioiTinh;
                user.IdLop = model.IdLop;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/HocSinhs/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HocSinhs.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
