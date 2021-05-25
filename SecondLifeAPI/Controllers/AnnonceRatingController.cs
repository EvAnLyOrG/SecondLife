using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SecondLife.Model.Entities;
using System.Collections.Generic;
using SecondLife.Services.Interfaces;

namespace SecondLifeAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AnnonceRatingController : ControllerBase
    {
        private IService<AnnonceRating> _service;

        public AnnonceRatingController(IService<AnnonceRating> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<AnnonceRating>> List()
        {
            var res = _service.List();
            if (res.Count == 0)
            {
                return NoContent();
            }

            return res;
        }

        [HttpPatch("{id}")]
        public ActionResult<AnnonceRating> Patch(int id, [FromBody] JsonPatchDocument<Annonce> document)
        {
            var updateRating = _service.Get(id);
            if (updateRating == null) return NoContent();
            return Ok(updateRating);
        }

        [HttpGet("{id}")]
        public ActionResult<AnnonceRating> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public ActionResult<AnnonceRating> Post(AnnonceRating annonceRating)
        {
            var res = _service.Add(annonceRating);
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
