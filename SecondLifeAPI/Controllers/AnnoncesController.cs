using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondLife.Services.Interfaces;

namespace SecondLifeAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AnnoncesController : ControllerBase
    {
        private IService<Annonce> _service;

        public AnnoncesController(IService<Annonce> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Annonce>> List()
        {
            var res = _service.List();
            if (res.Count == 0)
            {
                return NoContent();
            }

            return res;
        }

        [HttpPatch("{id}")]
        public ActionResult<Annonce> Patch(int id, [FromBody]JsonPatchDocument<Annonce> document)
        {
            var updateAnnonce = _service.Get(id);
            if (updateAnnonce == null) return NoContent();
            return Ok(updateAnnonce);
        }

        [HttpGet("{id}")]
        public ActionResult<Annonce> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public ActionResult<Annonce> Post(Annonce annonce)
        {
            var res = _service.Add(annonce);
            if (res == null)
            {
                return BadRequest("invalid data");
            }
            return res;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var res = _service.Get(id);
            if (res != null)
            {
                _service.Remove(res);
                return Ok();
            }

            return BadRequest();
        }
    }
}
