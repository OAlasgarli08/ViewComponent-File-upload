﻿using CategoryCrudeServiceLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrudeServiceLogic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Slider> Sliders {  get; set; } 
        public DbSet<SliderInfo> SliderInfos {  get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
