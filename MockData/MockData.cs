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
                Email = "test@test.com",
                Name = "Andy",
                CreatedOn = DateTime.Now,
            },
            new User
            {
                UserID = 1,
                Email = "email@email.com",
                Name = "John",
                CreatedOn = DateTime.Now
            }
        };
    }
}