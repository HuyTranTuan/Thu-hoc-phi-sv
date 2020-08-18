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
    public class NguoiThusController : ControllerBase
    {
        // GET: api/NguoiThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.NguoiThus.Select(x => new NguoiThuDTO
                {
                    Id = x.Id,
                    TenNguoiThu = x.TenNguoiThu
                }).ToListAsync());
            }
        }

        // GET: api/NguoiThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.NguoiThus.Where(x => x.Id == id).Select(x => new NguoiThuDTO
                {
                    Id = x.Id,
                    TenNguoiThu = x.TenNguoiThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/KhoanThuBanHangs
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] NguoiThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.NguoiThus.Add(new NguoiThu
                {
                    Id = model.Id,
                    TenNguoiThu = model.TenNguoiThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/KhoanThuBanHangs/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] NguoiThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.NguoiThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenNguoiThu = model.TenNguoiThu;
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
                var user = await context.NguoiThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
