using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TS;

    public class Demo3Context : DbContext
    {
        public Demo3Context (DbContextOptions<Demo3Context> options)
            : base(options)
        {
        }

        public DbSet<TS.Student> Student { get; set; }
    }
