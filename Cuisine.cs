using System;
using System.Collections.Generic;
using cuisine.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace cuisine.dal
{
    public class Cuisine: DbContext
    {
        public Cuisine() : base("Cuisine") { }
        public DbSet<Recette> Recettes { get; set; }
        public DbSet<Plat> Plats { get; set; }
        public DbSet<Ingredient> Ingrediens { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<Pathologie> Pathologies { get; set; }
        public DbSet<Video> Videos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

     
    }

}