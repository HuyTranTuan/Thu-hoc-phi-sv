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
    public class LoaiSanPhamsController : ControllerBase
    {
        // GET: api/LoaiSanPhams
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiSanPhams.Select(x => new LoaiSanPhamDTO
                {
                    Id = x.Id,
                    TenLoaiSanPham = x.TenLoaiSanPham
                }).ToListAsync());
            }
        }

        // GET: api/LoaiSanPhams/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.LoaiSanPhams.Where(x => x.Id == id).Select(x => new LoaiSanPhamDTO
                {
                    Id = x.Id,
                    TenLoaiSanPham = x.TenLoaiSanPham
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/LoaiSanPhams
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] LoaiSanPhamDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.LoaiSanPhams.Add(new LoaiSanPham
                {
                    Id = model.Id,
                    TenLoaiSanPham = model.TenLoaiSanPham
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/LoaiSanPhams/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LoaiSanPhamDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiSanPhams.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.TenLoaiSanPham = model.TenLoaiSanPham;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/LoaiSanPhams/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.LoaiSanPhams.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
