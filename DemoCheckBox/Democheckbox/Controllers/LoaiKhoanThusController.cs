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
    public class LoaiKhoanThusController : ControllerBase
    {
        // GET: api/LoaiKhoanThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiKhoanThus.Select(x => new LoaiKhoanThuDTO
                {
                    Id = x.Id,
                    TenLoaiKhoanThu = x.TenLoaiKhoanThu,
                    IdTinhChatKhoanThu = x.IdTinhChatKhoanThu,
                    SuDung = x.SuDung,
                    ThuTu = x.ThuTu
                }).ToListAsync());
            }
        }

        // GET: api/LoaiKhoanThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiKhoanThus.Where(x => x.Id == id).Select(x => new LoaiKhoanThuDTO
                {
                    Id = x.Id,
                    TenLoaiKhoanThu = x.TenLoaiKhoanThu,
                    IdTinhChatKhoanThu = x.IdTinhChatKhoanThu,
                    SuDung = x.SuDung,
                    ThuTu = x.ThuTu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/LoaiKhoanThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] LoaiKhoanThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.LoaiKhoanThus.Add(new LoaiKhoanThu
                {
                    Id = model.Id,
                    TenLoaiKhoanThu = model.TenLoaiKhoanThu,
                    IdTinhChatKhoanThu = model.IdTinhChatKhoanThu,
                    SuDung = model.SuDung,
                    ThuTu = model.ThuTu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/LoaiKhoanThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LoaiKhoanThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiKhoanThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenLoaiKhoanThu = model.TenLoaiKhoanThu;
                user.IdTinhChatKhoanThu = model.IdTinhChatKhoanThu;
                user.SuDung = model.SuDung;
                user.ThuTu = model.ThuTu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/LoaiKhoanThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiKhoanThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
