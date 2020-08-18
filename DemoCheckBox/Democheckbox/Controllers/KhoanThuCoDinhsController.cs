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
    public class KhoanThuCoDinhsController : ControllerBase
    {
        // GET: api/KhoanThuCoDinhs
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuCoDinhs.Select(x => new KhoanThuCoDinhDTO
                {
                    Id = x.Id,
                    TenKhoanThuCoDinh = x.TenKhoanThuCoDinh,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    GhiChu = x.GhiChu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu
                }).ToListAsync());
            }
        }

        // GET: api/KhoanThuCoDinhs/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuCoDinhs.Where(x => x.Id == id).Select(x => new KhoanThuCoDinhDTO
                {
                    Id = x.Id,
                    TenKhoanThuCoDinh = x.TenKhoanThuCoDinh,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    GhiChu = x.GhiChu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanThuCoDinhs
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoanThuCoDinhDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KhoanThuCoDinhs.Add(new KhoanThuCoDinh
                {
                    Id = model.Id,
                    TenKhoanThuCoDinh = model.TenKhoanThuCoDinh,
                    DonGia = model.DonGia,
                    ThuTu = model.ThuTu,
                    GhiChu = model.GhiChu,
                    SuDung = model.SuDung,
                    IdLoaiKhoanThu = model.IdLoaiKhoanThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanThuCoDinhs/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoanThuCoDinhDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuCoDinhs.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenKhoanThuCoDinh = model.TenKhoanThuCoDinh;
                user.DonGia = model.DonGia;
                user.ThuTu = model.ThuTu;
                user.GhiChu = model.GhiChu;
                user.SuDung = model.SuDung;
                user.IdLoaiKhoanThu = model.IdLoaiKhoanThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KhoanThuCoDinhs/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuCoDinhs.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
