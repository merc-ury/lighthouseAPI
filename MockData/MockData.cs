using System;
using System.Collections.Generic;
using LighthouseAPI.Models;

namespace LighthouseAPI
{
    public static class MockData
    {
        public static List<User> users = new List<User>
        {
            new User
            {
                UserID = 0,
                Username = "Test123",
                CreatedOn = DateTime.Now,
                Notes = new List<Note>
                {
                    new Note { Title = "Test!!!" }
                }
            },
            new User
            {
                UserID = 1,
                Username = "boobs",
                CreatedOn = DateTime.Now,
                Notes = new List<Note>
                {
                    new Note { Title = "dfsfsfsfdsfsdas!!" },
                    new Note { Title = "22222222222222" }
                }
            }
        };
    }
}