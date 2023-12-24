using API.IRepositories;
using API.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVien _NhanVienServices;

        public NhanVienController(INhanVien nhanVienServices)
        {
            _NhanVienServices = nhanVienServices;
        }
        [HttpPost]
        public async Task<IActionResult> Create(NhanVien nhanVien)
        {
            var rs = await _NhanVienServices.CreateNhanVien(nhanVien);
            if (rs)         
            return Ok();
            return BadRequest();
            
        }
        [HttpGet]
        public async Task<IActionResult> Get( )
        {
            var rs = await _NhanVienServices.GetNhanViens();
            if(rs == null)
                return NoContent();
            return Ok(rs);
        }
    }
}
