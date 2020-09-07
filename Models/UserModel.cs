using System;
using System.Collections.Generic;

namespace LighthouseAPI
{
    public class UserModel
    {
        public string Username { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<NoteModel> Notes { get; set; }
    }
}