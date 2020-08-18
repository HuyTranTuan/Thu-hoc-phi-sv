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
    public class KhoanChisController : ControllerBase
    {
        // GET: api/KhoanChis
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanChis.Select(x => new KhoanChiDTO
                {
                    Id = x.Id,
                    TenKhoanChi = x.TenKhoanChi,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanChi = x.IdLoaiKhoanChi
                }).ToListAsync());
            }
        }

        // GET: api/KhoanChis/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanChis.Where(x => x.Id == id).Select(x => new KhoanChiDTO
                {
                    Id = x.Id,
                    TenKhoanChi = x.TenKhoanChi,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanChi = x.IdLoaiKhoanChi
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanChis
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoanChiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KhoanChis.Add(new KhoanChi
                {
                    Id = model.Id,
                    TenKhoanChi = model.TenKhoanChi,
                    ThuTu = model.ThuTu,
                    SuDung = model.SuDung,
                    IdLoaiKhoanChi = model.IdLoaiKhoanChi
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanChis/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoanChiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanChis.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenKhoanChi = model.TenKhoanChi;
                user.ThuTu = model.ThuTu;
                user.SuDung = model.SuDung;
                user.IdLoaiKhoanChi = model.IdLoaiKhoanChi;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KhoanChis/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanChis.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
