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
    public class LoaiHinhThucThusController : ControllerBase
    {
        // GET: api/LoaiHinhThucThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiHinhThucThus.Select(x => new LoaiHinhThucThuDTO
                {
                    Id = x.Id,
                    TenLoaiHinhThucThu = x.TenLoaiHinhThucThu
                }).ToListAsync());
            }
        }

        // GET: api/LoaiHinhThucThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiHinhThucThus.Where(x => x.Id == id).Select(x => new LoaiHinhThucThuDTO
                {
                    Id = x.Id,
                    TenLoaiHinhThucThu = x.TenLoaiHinhThucThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/LoaiHinhThucThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] LoaiHinhThucThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.LoaiHinhThucThus.Add(new LoaiHinhThucThu
                {
                    Id = model.Id,
                    TenLoaiHinhThucThu = model.TenLoaiHinhThucThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/LoaiHinhThucThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LoaiHinhThucThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiHinhThucThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenLoaiHinhThucThu = model.TenLoaiHinhThucThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KeHoachThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiHinhThucThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
