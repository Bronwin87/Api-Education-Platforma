﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Domain.Entities.Auth
{
    public class UserModel : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public int Exp { get; set; } = 0;
        public int Rank { get; set; } = 0;
        public string Name { get; set; }
        public int LearningTime { get; set; } = 0;
        public int CompletedCourses { get; set; } = 0;
        public string PhotoPath { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public DateTimeOffset JoinedData { get; set; } = DateTimeOffset.Now;
        public bool IsActive { get; set; } = false;

    }
}