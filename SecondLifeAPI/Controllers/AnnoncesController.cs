
using Microsoft.AspNetCore.Mvc;
using SecondLife.Model.Entities;
using SecondLife.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondLifeAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AnnoncesController : ControllerBase
    {
        private IAnnonceService _service;

        public AnnoncesController(IAnnonceService service)
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
                return BadRequest("invalid title");
            }
            return res;
        }
    }
}
