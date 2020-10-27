using System;

namespace LighthouseAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}