using System;
using System.Collections.Generic;

namespace LighthouseAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Note> Notes { get; set; }
    }
}