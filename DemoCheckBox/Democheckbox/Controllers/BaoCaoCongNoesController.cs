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
    public class BaoCaoCongNoesController : ControllerBase
    {
        // GET: api/BaoCaoCongNoes
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.BaoCaoCongNos.Select(x => new BaoCaoCongNoDTO
                {
                    Id = x.Id,
                    CongNoHocPhi = x.CongNoHocPhi,
                    CongNoDichVu = x.CongNoDichVu,
                    TongCongNo = x.TongCongNo,
                    IdHocSinh = x.IdHocSinh
                }).ToListAsync());
            }
        }

        // GET: api/BaoCaoCongNoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.BaoCaoCongNos.Where(x => x.Id == id).Select(x => new BaoCaoCongNoDTO
                {
                    Id = x.Id,
                    CongNoHocPhi = x.CongNoHocPhi,
                    CongNoDichVu = x.CongNoDichVu,
                    TongCongNo = x.TongCongNo,
                    IdHocSinh = x.IdHocSinh
                }).FirstOrDefaultAsync());
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] BaoCaoCongNoDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.BaoCaoCongNos.Add(new BaoCaoCongNo
                {
                    Id = model.Id,
                    CongNoHocPhi = model.CongNoHocPhi,
                    CongNoDichVu = model.CongNoDichVu,
                    TongCongNo = model.TongCongNo,
                    IdHocSinh = model.IdHocSinh
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BaoCaoCongNoDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.BaoCaoCongNos.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.CongNoHocPhi = model.CongNoHocPhi;
                user.CongNoDichVu = model.CongNoDichVu;
                user.TongCongNo = model.TongCongNo;
                user.IdHocSinh = model.IdHocSinh;
                return Ok(await context.SaveChangesAsync());
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.BaoCaoCongNos.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
