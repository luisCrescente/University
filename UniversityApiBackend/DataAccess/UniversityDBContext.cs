﻿using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions <UniversityDBContext> options): base(options)
        {

        }
        //TODO: Add DbStets (Tables of our Date Base)
        public DbSet<User>? Users { get; set; }
        //public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set;}
    }
}
