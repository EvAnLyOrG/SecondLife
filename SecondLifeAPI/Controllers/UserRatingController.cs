using SecondLife.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecondLife.Services.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
namespace SecondLifeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRatingController : ControllerBase
    {
        private IService<UserRating> _service;

        public UserRatingController(IService<UserRating> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<UserRating>> List()
        {
            var res = _service.List();
            if (res.Count == 0)
            {
                return NoContent();
            }

            return res;
        }

        [HttpPatch("{id}")]
        public ActionResult<UserRating> Patch(int id, [FromBody] JsonPatchDocument<User> document)
        {
            var updateUser = _service.Get(id);
            if (updateUser == null) return NoContent();
            return Ok(updateUser);
        }

        [HttpGet("{id}")]
        public ActionResult<UserRating> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public ActionResult<UserRating> Add(UserRating userRating)
        {
            var res = _service.Add(userRating);
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
