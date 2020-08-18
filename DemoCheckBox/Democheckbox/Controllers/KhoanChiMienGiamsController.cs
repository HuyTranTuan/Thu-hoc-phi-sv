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
    public class KhoanChiMienGiamsController : ControllerBase
    {
        // GET: api/KhoanChiMienGiams
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanChiMienGiams.Select(x => new KhoanChiMienGiamDTO
                {
                    Id = x.Id,
                    TenKhoanChiMienGiam = x.TenKhoanChiMienGiam,
                    SoTienMienGiam = x.SoTienMienGiam,
                    GhiChu = x.GhiChu,
                    IdKhoanChi = x.IdKhoanChi
                }).ToListAsync());
            }
        }

        // GET: api/KhoanChiMienGiams/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanChiMienGiams.Where(x => x.Id == id).Select(x => new KhoanChiMienGiamDTO
                {
                    Id = x.Id,
                    TenKhoanChiMienGiam = x.TenKhoanChiMienGiam,
                    SoTienMienGiam = x.SoTienMienGiam,
                    GhiChu = x.GhiChu,
                    IdKhoanChi = x.IdKhoanChi
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanChiMienGiams
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoanChiMienGiamDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KhoanChiMienGiams.Add(new KhoanChiMienGiam
                {
                    Id = model.Id,
                    TenKhoanChiMienGiam = model.TenKhoanChiMienGiam,
                    SoTienMienGiam = model.SoTienMienGiam,
                    GhiChu = model.GhiChu,
                    IdKhoanChi = model.IdKhoanChi
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanChiMienGiams/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoanChiMienGiamDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanChiMienGiams.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenKhoanChiMienGiam = model.TenKhoanChiMienGiam;
                user.SoTienMienGiam = model.SoTienMienGiam;
                user.GhiChu = model.GhiChu;
                user.IdKhoanChi = model.IdKhoanChi;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KhoanChiMienGiams/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanChiMienGiams.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
