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
    public class LoaiKhoanChisController : ControllerBase
    {
        // GET: api/LoaiKhoanChis
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiKhoanChis.Select(x => new LoaiKhoanChiDTO
                {
                    Id = x.Id,
                    TenLoaiKhoanChi = x.TenLoaiKhoanChi,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung
                }).ToListAsync());
            }
        }

        // GET: api/LoaiKhoanChis/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiKhoanChis.Where(x => x.Id == id).Select(x => new LoaiKhoanChiDTO
                {
                    Id = x.Id,
                    TenLoaiKhoanChi = x.TenLoaiKhoanChi,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/LoaiKhoanChis
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] LoaiKhoanChiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.LoaiKhoanChis.Add(new LoaiKhoanChi
                {
                    Id = model.Id,
                    TenLoaiKhoanChi = model.TenLoaiKhoanChi,
                    ThuTu = model.ThuTu,
                    SuDung = model.SuDung
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/LoaiKhoanChis/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LoaiKhoanChiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiKhoanChis.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenLoaiKhoanChi = model.TenLoaiKhoanChi;
                user.ThuTu = model.ThuTu;
                user.SuDung = model.SuDung;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/LoaiKhoanChis/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiKhoanChis.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
