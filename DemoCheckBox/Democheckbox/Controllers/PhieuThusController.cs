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
    public class PhieuThusController : ControllerBase
    {
        // GET: api/PhieuThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.PhieuThus.Select(x => new PhieuThuDTO
                {
                    Id = x.Id,
                    NgayThu = x.NgayThu,
                    TongTien = x.TongTien,
                    IdNguoiThu = x.IdNguoiThu,
                    IdChiTietPhieuThu = x.IdChiTietPhieuThu
                }).ToListAsync());
            }
        }

        // GET: api/PhieuThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.PhieuThus.Where(x => x.Id == id).Select(x => new PhieuThuDTO
                {
                    Id = x.Id,
                    NgayThu = x.NgayThu,
                    TongTien = x.TongTien,
                    IdNguoiThu = x.IdNguoiThu,
                    IdChiTietPhieuThu = x.IdChiTietPhieuThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/PhieuThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] PhieuThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.PhieuThus.Add(new PhieuThu
                {
                    Id = model.Id,
                    NgayThu = model.NgayThu,
                    TongTien = model.TongTien,
                    IdNguoiThu = model.IdNguoiThu,
                    IdChiTietPhieuThu = model.IdChiTietPhieuThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/PhieuThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PhieuThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.PhieuThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.NgayThu = model.NgayThu;
                user.TongTien = model.TongTien;
                user.IdNguoiThu = model.IdNguoiThu;
                user.IdChiTietPhieuThu = model.IdChiTietPhieuThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/PhieuThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.PhieuThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
