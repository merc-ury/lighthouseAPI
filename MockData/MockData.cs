using System;
using System.Collections.Generic;

namespace LighthouseAPI
{
    public static class MockData
    {
        public static List<UserModel> users = new List<UserModel>
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
    }
}