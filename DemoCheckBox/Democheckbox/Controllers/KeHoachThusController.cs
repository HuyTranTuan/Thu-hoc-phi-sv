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
    public class KeHoachThusController : ControllerBase
    {
        // GET: api/KeHoachThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KeHoachThus.Select(x => new KeHoachThuDTO
                {
                    Id = x.Id,
                    SoTien = x.SoTien,
                    GhiChu = x.GhiChu,
                    SoLuongHocSinh = x.SoLuongHocSinh,
                    BatBuoc = x.BatBuoc,
                    IdHocKy = x.IdHocKy,
                    IdKhoi = x.IdKhoi,
                    IdHinhThucThu = x.IdHinhThucThu,
                    IdKhoanThuCoDinh = x.IdKhoanThuCoDinh,
                }).ToListAsync());
            }
        }

        // GET: api/KeHoachThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.KeHoachThus.Where(x => x.Id == id).Select(x => new KeHoachThuDTO
                {
                    Id = x.Id,
                    SoTien = x.SoTien,
                    GhiChu = x.GhiChu,
                    SoLuongHocSinh = x.SoLuongHocSinh,
                    BatBuoc = x.BatBuoc,
                    IdHocKy = x.IdHocKy,
                    IdKhoi = x.IdKhoi,
                    IdHinhThucThu = x.IdHinhThucThu,
                    IdKhoanThuCoDinh = x.IdKhoanThuCoDinh,
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KeHoachThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] KeHoachThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.KeHoachThus.Add(new KeHoachThu
                {
                    Id = model.Id,
                    SoTien = model.SoTien,
                    GhiChu = model.GhiChu,
                    SoLuongHocSinh = model.SoLuongHocSinh,
                    BatBuoc = model.BatBuoc,
                    IdHocKy = model.IdHocKy,
                    IdKhoi = model.IdKhoi,
                    IdHinhThucThu = model.IdHinhThucThu,
                    IdKhoanThuCoDinh = model.IdKhoanThuCoDinh,
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KeHoachThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] KeHoachThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.KeHoachThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.SoTien = model.SoTien;
                user.GhiChu = model.GhiChu;
                user.SoLuongHocSinh = model.SoLuongHocSinh;
                user.BatBuoc = model.BatBuoc;
                user.IdHocKy = model.IdHocKy;
                user.IdKhoi = model.IdKhoi;
                user.IdHinhThucThu = model.IdHinhThucThu;
                user.IdKhoanThuCoDinh = model.IdKhoanThuCoDinh;
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
                var user = await context.KeHoachThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
