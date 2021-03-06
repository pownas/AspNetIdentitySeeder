﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetIdentitySeeder.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetIdentitySeeder.Data
{
    public class AppNameContext : IdentityDbContext<ApplicationUser>
    {
        public AppNameContext(DbContextOptions<AppNameContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Role>().HasData(new List<Role>
        //    {
        //        new Role {
        //            Id = 1,
        //            Name = "Admin",
        //            NormalizedName = "ADMIN"
        //        },
        //        new Role {
        //            Id = 2,
        //            Name = "Staff",
        //            NormalizedName = "STAFF"
        //        },
        //    });
        //}
    }
}