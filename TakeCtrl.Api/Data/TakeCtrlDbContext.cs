using Microsoft.EntityFrameworkCore;
using System.CodeDom;
using TakeCtrl.Api.Entities;

namespace TakeCtrl.Api.Data
{
    public class TakeCtrlDbContext:DbContext 
    {
        public TakeCtrlDbContext(DbContextOptions<TakeCtrlDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add Servers
            modelBuilder.Entity<Server>().HasData(new Server
            {
                UUID = "878859d6-f616-11ed-b67e-0242ac120002",
                Name = "VPS-1",
                CPUAmount = 6,
                DiskSize = 136464745,
                MemorySize = 3456789,
                Status = "running",
                IPAddress = "56.84.125.212"
            });

            modelBuilder.Entity<Server>().HasData(new Server
            {
                UUID = "081b833e-f617-11ed-b67e-0242ac120002",
                Name = "VPS-2",
                CPUAmount = 6,
                DiskSize = 136464745,
                MemorySize = 3456789,
                Status = "running",
                IPAddress = "56.84.125.213"
            });

            modelBuilder.Entity<Server>().HasData(new Server
            {
                UUID = "111d37ca-f617-11ed-b67e-0242ac120002",
                Name = "VPS-3",
                CPUAmount = 6,
                DiskSize = 136464745,
                MemorySize = 3456789,
                Status = "running",
                IPAddress = "56.84.125.214"
            });

            modelBuilder.Entity<Server>().HasData(new Server
            {
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Name = "VPS-4",
                CPUAmount = 6,
                DiskSize = 136464745,
                MemorySize = 3456789,
                Status = "running",
                IPAddress = "56.84.125.215"
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "user",
                userName = "user",
                Password = "welkom",
                IsAdmin = true
            });
        }

        public DbSet<Server> Servers { get; set; }
        public DbSet<Usage> Usages { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
