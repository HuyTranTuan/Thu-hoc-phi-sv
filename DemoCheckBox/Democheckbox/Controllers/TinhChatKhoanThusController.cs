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
    public class TinhChatKhoanThusController : ControllerBase
    {
        // GET: api/TinhChatKhoanThus
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.TinhChatKhoanThus.Select(x => new TinhChatKhoanThuDTO
                {
                    Id = x.Id,
                    TenTinhChatKhoanThu = x.TenTinhChatKhoanThu
                }).ToListAsync());
            }
        }

        // GET: api/TinhChatKhoanThus/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.TinhChatKhoanThus.Where(x => x.Id == id).Select(x => new TinhChatKhoanThuDTO
                {
                    Id = x.Id,
                    TenTinhChatKhoanThu = x.TenTinhChatKhoanThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/TinhChatKhoanThus
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] TinhChatKhoanThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.TinhChatKhoanThus.Add(new TinhChatKhoanThu
                {
                    Id = model.Id,
                    TenTinhChatKhoanThu = model.TenTinhChatKhoanThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/TinhChatKhoanThus/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TinhChatKhoanThuDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.TinhChatKhoanThus.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenTinhChatKhoanThu = model.TenTinhChatKhoanThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/TinhChatKhoanThus/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.TinhChatKhoanThus.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
