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
    public class KhoanThuBanHangsController : ControllerBase
    {
        // GET: api/KhoanThuBanHangs
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuBanHangs.Select(x => new KhoanThuBanHangDTO
                {
                    Id = x.Id,
                    TenSanPham = x.TenSanPham,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu,
                    IdLoaiSanPham = x.IdLoaiSanPham
                }).ToListAsync());
            }
        }

        // GET: api/KhoanThuBanHangs/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuBanHangs.Where(x => x.Id == id).Select(x => new KhoanThuBanHangDTO
                {
                    Id = x.Id,
                    TenSanPham = x.TenSanPham,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    SuDung = x.SuDung,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu,
                    IdLoaiSanPham = x.IdLoaiSanPham
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanThuBanHangs
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoanThuBanHangDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KhoanThuBanHangs.Add(new KhoanThuBanHang
                {
                    Id = model.Id,
                    TenSanPham = model.TenSanPham,
                    DonGia = model.DonGia,
                    ThuTu = model.ThuTu,
                    SuDung = model.SuDung,
                    IdLoaiKhoanThu = model.IdLoaiKhoanThu,
                    IdLoaiSanPham = model.IdLoaiSanPham
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanThuBanHangs/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoanThuBanHangDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuBanHangs.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenSanPham = model.TenSanPham;
                user.DonGia = model.DonGia;
                user.ThuTu = model.ThuTu;
                user.SuDung = model.SuDung;
                user.IdLoaiKhoanThu = model.IdLoaiKhoanThu;
                user.IdLoaiSanPham = model.IdLoaiSanPham;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KhoanThuBanHangs/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuBanHangs.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
