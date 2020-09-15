using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LighthouseAPI
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        // TEST MODELS ONLY. will remove later.
        private static List<UserModel> users = new List<UserModel>
        {
            new UserModel
            {
                UserID = 0,
                Username = "Test123",
                CreatedOn = DateTime.Now,
                Notes = new List<NoteModel>
                {
                    new NoteModel { Title = "Test!!!" }
                }
            },
            new UserModel
            {
                UserID = 1,
                Username = "boobs",
                CreatedOn = DateTime.Now,
                Notes = new List<NoteModel>
                {
                    new NoteModel { Title = "dfsfsfsfdsfsdas!!" },
                    new NoteModel { Title = "22222222222222" }
                }
            }
        };

        [HttpGet("get/GetAll")]
        public IActionResult Get()
        {
            return Ok(users);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(users.FirstOrDefault(user => user.UserID == id));
        }

        [HttpPost("new")]
        public IActionResult AddUser(UserModel model)
        {
            users.Add(model);
            return Ok(users);
        }
    }
}