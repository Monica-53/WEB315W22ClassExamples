using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassExampleRazorPages.Models;

    public class ClassExampleRazorPagesContext : DbContext
    {
        public ClassExampleRazorPagesContext (DbContextOptions<ClassExampleRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<ClassExampleRazorPages.Models.Car> Car { get; set; }
    }
