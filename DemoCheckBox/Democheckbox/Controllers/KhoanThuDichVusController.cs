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
    public class KhoanThuDichVusController : ControllerBase
    {
        // GET: api/KhoanThuDichVus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuDichVus.Select(x => new KhoanThuDichVuDTO
                {
                    Id = x.Id,
                    TenKhoanThuDichVu = x.TenKhoanThuDichVu,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    DonGiaTra = x.DonGiaTra,
                    GhiChu = x.GhiChu,
                    SuDung = x.SuDung,
                    TinhTheoNgay = x.TinhTheoNgay,
                    TraLaiKhiVang = x.TraLaiKhiVang,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu
                }).ToListAsync());
            }
        }

        // GET: api/KhoanThuDichVus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KhoanThuDichVus.Where(x => x.Id == id).Select(x => new KhoanThuDichVuDTO
                {
                    Id = x.Id,
                    TenKhoanThuDichVu = x.TenKhoanThuDichVu,
                    DonGia = x.DonGia,
                    ThuTu = x.ThuTu,
                    DonGiaTra = x.DonGiaTra,
                    GhiChu = x.GhiChu,
                    SuDung = x.SuDung,
                    TinhTheoNgay = x.TinhTheoNgay,
                    TraLaiKhiVang = x.TraLaiKhiVang,
                    IdLoaiKhoanThu = x.IdLoaiKhoanThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanThuDichVus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KhoanThuDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KhoanThuDichVus.Add(new KhoanThuDichVu
                {
                    Id = model.Id,
                    TenKhoanThuDichVu = model.TenKhoanThuDichVu,
                    DonGia = model.DonGia,
                    ThuTu = model.ThuTu,
                    DonGiaTra = model.DonGiaTra,
                    GhiChu = model.GhiChu,
                    SuDung = model.SuDung,
                    TinhTheoNgay = model.TinhTheoNgay,
                    TraLaiKhiVang = model.TraLaiKhiVang,
                    IdLoaiKhoanThu = model.IdLoaiKhoanThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanThuDichVus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KhoanThuDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuDichVus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenKhoanThuDichVu = model.TenKhoanThuDichVu;
                user.DonGia = model.DonGia;
                user.ThuTu = model.ThuTu;
                user.DonGiaTra = model.DonGiaTra;
                user.GhiChu = model.GhiChu;
                user.SuDung = model.SuDung;
                user.TinhTheoNgay = model.TinhTheoNgay;
                user.TraLaiKhiVang = model.TraLaiKhiVang;
                user.IdLoaiKhoanThu = model.IdLoaiKhoanThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/KhoanThuDichVus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KhoanThuDichVus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
