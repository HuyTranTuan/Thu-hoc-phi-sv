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
    public class BaoCaoDangKyDichVusController : ControllerBase
    {
        // GET: api/BaoCaoDangKyDichVus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.BaoCaoDangKyDichVus.Select(x => new BaoCaoDangKyDichVuDTO
                {
                    Id = x.Id,
                    DonGia = x.DonGia,
                    SoLuong = x.SoLuong,
                    ThanhTien = x.ThanhTien,
                    IdHocSinh = x.IdHocSinh,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu
                }).ToListAsync());
            }
        }

        // GET: api/BaoCaoDangKyDichVus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.BaoCaoDangKyDichVus.Where(x => x.Id == id).Select(x => new BaoCaoDangKyDichVuDTO
                {
                    Id = x.Id,
                    DonGia = x.DonGia,
                    SoLuong = x.SoLuong,
                    ThanhTien = x.ThanhTien,
                    IdHocSinh = x.IdHocSinh,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/BaoCaoDangKyDichVus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] BaoCaoDangKyDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.BaoCaoDangKyDichVus.Add(new BaoCaoDangKyDichVu
                {
                    Id = model.Id,
                    DonGia = model.DonGia,
                    SoLuong = model.SoLuong,
                    ThanhTien = model.ThanhTien,
                    IdHocSinh = model.IdHocSinh,
                    IdKhoanThuDichVu = model.IdKhoanThuDichVu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/BaoCaoDangKyDichVus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BaoCaoDangKyDichVuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.BaoCaoDangKyDichVus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.DonGia = model.DonGia;
                user.SoLuong = model.SoLuong;
                user.ThanhTien = model.ThanhTien;
                user.IdHocSinh = model.IdHocSinh;
                user.IdKhoanThuDichVu = model.IdKhoanThuDichVu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/BaoCaoDangKyDichVus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.BaoCaoDangKyDichVus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
