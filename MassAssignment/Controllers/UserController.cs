using MassAssignment.Data;
using MassAssignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MassAssignment
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IDataContext _data;

        public UserController(IDataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<User> GetUserByID(int id)
        {
            User user = _data.GetUserById(id);
            if (user == null) return NotFound("Id not found");
            return Ok(user);
        }

        [HttpPost]
        public ActionResult PostUser(User user)
        {
            _data.AddUser(user);
            return Ok("User posted");
        }

        [HttpPut]
        public ActionResult UpdateUsername(int id, User user)
        {
            if (_data.UpdateUsername(id, user)) return Ok("User Updated");
            return BadRequest("User not found");
        }

        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {
            if (_data.DeleteUser(id)) return Ok("User deleted");
            return BadRequest("User not found");
        }



    }
}