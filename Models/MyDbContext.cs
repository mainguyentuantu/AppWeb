﻿using Microsoft.EntityFrameworkCore;

namespace AppWeb.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Orders> Orders { get; set; }   


    }
}
