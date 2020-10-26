using GoldenHand.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand
{
    public class GoldenHandContext : DbContext
    {
        private static GoldenHandContext _instance = null;
        public static GoldenHandContext Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GoldenHandContext();
                }
                return _instance;
            }
        }
        public GoldenHandContext() : base(nameOrConnectionString: "Default") { }

        public DbSet<Senior> Seniors { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<FormStatus> FormStatuses{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
