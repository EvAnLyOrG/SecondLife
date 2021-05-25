﻿using SecondLife.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecondLife.Services.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLifeAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IService<User> _service;

        public UserController(IService<User> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<User>> List()
        {
            var res = _service.List();
            if (res.Count == 0)
            {
                return NoContent();
            }

            return res;
        }

        [HttpPatch("{id}")]
        public ActionResult<User> Patch(int id, [FromBody] JsonPatchDocument<User> document)
        {
            var updateUser = _service.Get(id);
            if (updateUser == null) return NoContent();
            return Ok(updateUser);
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public ActionResult<User> Add(User user)
        {
            var res = _service.Add(user);
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
