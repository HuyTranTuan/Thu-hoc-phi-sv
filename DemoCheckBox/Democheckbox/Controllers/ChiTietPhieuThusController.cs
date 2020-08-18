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
    public class ChiTietPhieuThusController : ControllerBase
    {
        // GET: api/ChiTietPhieuThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.ChiTietPhieuThus.Select(x => new ChiTietPhieuThuDTO
                {
                    Id = x.Id,
                    TongTien = x.TongTien,
                    KhauTru = x.KhauTru,
                    DaThu = x.DaThu,
                    SoTienBangChu = x.SoTienBangChu,
                    IdHocSinh = x.IdHocSinh
                }).ToListAsync());
            }
        }

        // GET: api/ChiTietPhieuThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.ChiTietPhieuThus.Where(x => x.Id == id).Select(x => new ChiTietPhieuThuDTO
                {
                    Id = x.Id,
                    TongTien = x.TongTien,
                    KhauTru = x.KhauTru,
                    DaThu = x.DaThu,
                    SoTienBangChu = x.SoTienBangChu,
                    IdHocSinh = x.IdHocSinh
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/ChiTietPhieuThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] ChiTietPhieuThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.ChiTietPhieuThus.Add(new ChiTietPhieuThu
                {
                    Id = model.Id,
                    TongTien = model.TongTien,
                    KhauTru = model.KhauTru,
                    DaThu = model.DaThu,
                    SoTienBangChu = model.SoTienBangChu,
                    IdHocSinh = model.IdHocSinh
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/ChiTietPhieuThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ChiTietPhieuThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.ChiTietPhieuThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TongTien = model.TongTien;
                user.KhauTru = model.KhauTru;
                user.DaThu = model.DaThu;
                user.SoTienBangChu = model.SoTienBangChu;
                user.IdHocSinh = model.IdHocSinh;
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
                var user = await context.ChiTietPhieuThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
