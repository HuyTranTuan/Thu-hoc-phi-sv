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
    public class ThuHocPhisController : ControllerBase
    {
        // GET: api/ThuHocPhis
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.ThuHocPhis.Select(x => new ThuHocPhiDTO
                {
                    Id = x.Id,
                    IdKhoanThuCoDinh = x.IdKhoanThuCoDinh,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu,
                    IdKhoanThuBanHang = x.IdKhoanThuBanHang,
                    IdHocKy = x.IdHocKy,
                    IdKhoanChiMienGiam = x.IdKhoanChiMienGiam,
                    SoLuong1 = x.SoLuong1,
                    SoLuong2 = x.SoLuong2,
                    SoLuong3 = x.SoLuong3,
                    NgayThu = x.NgayThu,
                    IdNguoiThu = x.IdNguoiThu,
                    IdHocSinh = x.IdHocSinh,
                    IdHinhThucThu = x.IdHinhThucThu
                }).ToListAsync());
            }
        }

        // GET: api/ThuHocPhis/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                return Ok(await context.ThuHocPhis.Where(x => x.Id == id).Select(x => new ThuHocPhiDTO
                {
                    Id = x.Id,
                    IdKhoanThuCoDinh = x.IdKhoanThuCoDinh,
                    IdKhoanThuDichVu = x.IdKhoanThuDichVu,
                    IdKhoanThuBanHang = x.IdKhoanThuBanHang,
                    IdHocKy = x.IdHocKy,
                    IdKhoanChiMienGiam = x.IdKhoanChiMienGiam,
                    SoLuong1 = x.SoLuong1,
                    SoLuong2 = x.SoLuong2,
                    SoLuong3 = x.SoLuong3,
                    NgayThu = x.NgayThu,
                    IdNguoiThu = x.IdNguoiThu,
                    IdHocSinh = x.IdHocSinh,
                    IdHinhThucThu = x.IdHinhThucThu
                }).FirstOrDefaultAsync());
            }
        }

        // POST: api/ThuHocPhis
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] ThuHocPhiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                context.ThuHocPhis.Add(new ThuHocPhi
                {
                    Id = model.Id,
                    IdKhoanThuCoDinh = model.IdKhoanThuCoDinh,
                    IdKhoanThuDichVu = model.IdKhoanThuDichVu,
                    IdKhoanThuBanHang = model.IdKhoanThuBanHang,
                    IdHocKy = model.IdHocKy,
                    IdKhoanChiMienGiam = model.IdKhoanChiMienGiam,
                    SoLuong1 = model.SoLuong1,
                    SoLuong2 = model.SoLuong2,
                    SoLuong3 = model.SoLuong3,
                    NgayThu = model.NgayThu,
                    IdNguoiThu = model.IdNguoiThu,
                    IdHocSinh = model.IdHocSinh,
                    IdHinhThucThu = model.IdHinhThucThu
                });
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserProfiles] ON");
                return Ok(await context.SaveChangesAsync());
            }
        }

        // PUT: api/ThuHocPhis/2
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ThuHocPhiDTO model)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.ThuHocPhis.FirstOrDefaultAsync(x => x.Id.Equals(id));

                if (user == null) return NotFound();
                user.Id = model.Id;
                user.IdKhoanThuCoDinh = model.IdKhoanThuCoDinh;
                user.IdKhoanThuDichVu = model.IdKhoanThuDichVu;
                user.IdKhoanThuBanHang = model.IdKhoanThuBanHang;
                user.IdHocKy = model.IdHocKy;
                user.IdKhoanChiMienGiam = model.IdKhoanChiMienGiam;
                user.SoLuong1 = model.SoLuong1;
                user.SoLuong2 = model.SoLuong2;
                user.SoLuong3 = model.SoLuong3;
                user.NgayThu = model.NgayThu;
                user.IdNguoiThu = model.IdNguoiThu;
                user.IdHocSinh = model.IdHocSinh;
                user.IdHinhThucThu = model.IdHinhThucThu;
                return Ok(await context.SaveChangesAsync());
            }
        }

        // DELETE: api/ThuHocPhis/2
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var context = new UserProfileDbContext())
            {
                var user = await context.ThuHocPhis.FindAsync(id);

                if (user == null) return NotFound();

                context.Entry(user).State = EntityState.Deleted;

                return Ok(await context.SaveChangesAsync());
            }
        }
    }
}
