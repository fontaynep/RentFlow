﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentFlow.Models;
namespace RentFlow.Data
    {

    public class AppDbContext : DbContext
        {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            {
            }

        public DbSet<Property> Properties { get; set; } = default!;
        }
    }