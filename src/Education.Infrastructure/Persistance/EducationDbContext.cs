﻿using Education.Application.Abstractions;
using Education.Domain.Entities;
using Education.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Infrastructure.Persistance
{
    public class EducationDbContext : DbContext, IEducationDbContext
    {
        public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<CouponModel> Coupons { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<LessonModel> Lessons { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<QuizModel> Quizes { get; set; }
        public DbSet<StatisticModel> Statistics { get; set; }
        public DbSet<VideoModel> Videos { get; set; }
        public DbSet<CourseFeedbackModel> CourseFeedbacks { get; set; }
    }
}