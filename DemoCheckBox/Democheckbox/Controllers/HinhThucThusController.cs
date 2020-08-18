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
    public class HinhThucThusController : ControllerBase
    {
        // GET: api/HinhThucThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HinhThucThus.Select(x => new HinhThucThuDTO
                {
                    Id = x.Id,
                    TenHinhThucThu = x.TenHinhThucThu,
                    IdLoaiHinhThucThu = x.IdLoaiHinhThucThu
                }).ToListAsync());
            }
        }

        // GET: api/HinhThucThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.HinhThucThus.Where(x => x.Id == id).Select(x => new HinhThucThuDTO
                {
                    Id = x.Id,
                    TenHinhThucThu = x.TenHinhThucThu,
                    IdLoaiHinhThucThu = x.IdLoaiHinhThucThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/HinhThucThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] HinhThucThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.HinhThucThus.Add(new HinhThucThu
                {
                    Id = model.Id,
                    TenHinhThucThu = model.TenHinhThucThu,
                    IdLoaiHinhThucThu = model.IdLoaiHinhThucThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/HinhThucThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] HinhThucThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HinhThucThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenHinhThucThu = model.TenHinhThucThu;
                user.IdLoaiHinhThucThu = model.IdLoaiHinhThucThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/HinhThucThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.HinhThucThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
