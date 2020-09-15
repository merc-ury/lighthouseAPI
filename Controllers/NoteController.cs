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
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("get/GetAll")]
        public IActionResult Get()
        {
            return Ok(_noteService.GetAllUsers());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(_noteService.GetUserByID(id));
        }

        [HttpPost("new")]
        public IActionResult AddUser(UserModel user)
        {
            return Ok(_noteService.AddUser(user));
        }
    }
}