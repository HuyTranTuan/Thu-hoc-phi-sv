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
    public class DangKyDichVusController : ControllerBase
    {
        // GET: api/DangKyDichVus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.DangKyDichVus.Select(x => new DangKyDichVuDTO
                {
                    Id = x.Id,
                    DonViTinh = x.DonViTinh,
                    SoLuong = x.SoLuong,
                    GhiChu = x.GhiChu,
                    IdHocSinh = x.IdHocSinh,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu,
                    IdDotThu = x.IdDotThu
                }).ToListAsync());
            }
        }

        // GET: api/DangKyDichVus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.DangKyDichVus.Where(x => x.Id == id).Select(x => new DangKyDichVuDTO
                {
                    Id = x.Id,
                    DonViTinh = x.DonViTinh,
                    SoLuong = x.SoLuong,
                    GhiChu = x.GhiChu,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu,
                    IdHocSinh = x.IdHocSinh,
                    IdDotThu = x.IdDotThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/DangKyDichVus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] DangKyDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.DangKyDichVus.Add(new DangKyDichVu
                {
                    Id = model.Id,
                    DonViTinh = model.DonViTinh,
                    SoLuong = model.SoLuong,
                    GhiChu = model.GhiChu,
                    IdHocSinh = model.IdHocSinh,
                    IdKhoanThuDichVu = model.IdKhoanThuDichVu,
                    IdDotThu = model.IdDotThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/DangKyDichVus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DangKyDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.DangKyDichVus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.DonViTinh = model.DonViTinh;
                user.SoLuong = model.SoLuong;
                user.GhiChu = model.GhiChu;
                user.IdHocSinh = model.IdHocSinh;
                user.IdKhoanThuDichVu = model.IdKhoanThuDichVu;
                user.IdDotThu = model.IdDotThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/DangKyDichVus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.DangKyDichVus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
