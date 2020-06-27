using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BUS;
using DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLyRapPhim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private NhanVienBUS nvBUS;
        public NhanVienController()
        {
            nvBUS = new NhanVienBUS();
        }
        
        // GET: api/<NhanVienController>
        [HttpGet]
        public IEnumerable<NhanVienDTO> Get()
        {
            IEnumerable<NhanVienDTO> list_nv = nvBUS.get_AllNhanVien();
            return list_nv;
        }

        // GET api/<NhanVienController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NhanVienController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NhanVienController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
