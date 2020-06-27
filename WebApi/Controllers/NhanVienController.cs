using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    
    public class NhanVienController : ApiController
    {
        private NhanVienBUS nvBUS;
        public NhanVienController()
        {
            nvBUS = new NhanVienBUS();
        }
        [HttpGet]
        [Route("api/nhanvien")]
        public IEnumerable<NhanVienDTO> Get()
        {
            IEnumerable<NhanVienDTO> list_nv = nvBUS.get_AllNhanVien();
            return list_nv;
        }

        // ASP.NET Core mới có trò [HttpGet("{manv})]; 
        // ASP.NET phải sử dụng [Route], [RouteAttribute]
        [HttpGet]
        [Route("api/nhanvien/{manv}")]
        public IEnumerable<NhanVienDTO> Get(string manv)
        {
            IEnumerable<NhanVienDTO> nv = nvBUS.Get_NhanVien_byMaNV(manv);
            return nv;
        }
        [HttpPost]
        [Route("api/nhanvien")]
        public string Post([FromBody]NhanVienDTO nv)
        {
            string manv = nvBUS.ThemNhanVien(nv);
            return manv;
        }
        [HttpPut]
        [Route("api/nhanvien/{manv}")]
        // PUT: api/NhanVien/5
        public void Put(string manv, [FromBody]NhanVienDTO nv)
        {
            nvBUS.Sua_NhanVien(manv, nv);
        }
        [HttpDelete]
        [Route("api/nhanvien/{manv}")]
        // DELETE: api/NhanVien/5
        public bool Delete(string manv)
        {
            return nvBUS.Xoa_NhanVien(manv);
        }
    }
}
