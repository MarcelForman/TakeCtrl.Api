using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

            //Add Firewall
            modelBuilder.Entity<Firewall>().HasData(new Firewall
            {
                Id = 1,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Description = "RDP",
                StartPort = 3389,
                EndPort = 3389,
                Protocol = "tcp",
                IsEnabled = true,
            });
            modelBuilder.Entity<Firewall>().HasData(new Firewall
            {
                Id = 2,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Description = "FTP",
                StartPort = 21,
                EndPort = 21,
                Protocol = "tcp",
                IsEnabled = false,
            });
            modelBuilder.Entity<Firewall>().HasData(new Firewall
            {
                Id = 3,
                UUID = "878859d6-f616-11ed-b67e-0242ac120002",
                Description = "SSL",
                StartPort = 22,
                EndPort = 22,
                Protocol = "tcp",
                IsEnabled = true,
            });

            //Add usage
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 1,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "CPU",
                Percent = 20,
                Date = Convert.ToDateTime("2023-06-01 10:10:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 2,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "CPU",
                Percent = 40,
                Date = Convert.ToDateTime("2023-06-01 10:15:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 3,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "CPU",
                Percent = 80,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 4,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitIn = 456789,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 5,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitIn = 456123,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 6,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitOut = 56894,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 7,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitOut = 56241,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 8,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsRead = 653,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 9,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsRead = 645,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 10,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsWrite = 423,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 11,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsWrite = 890,
                Date = Convert.ToDateTime("2023-06-01 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 12,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "CPU",
                Percent = 20,
                Date = Convert.ToDateTime("2023-06-04 10:15:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 13,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "CPU",
                Percent = 80,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 14,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitIn = 45789,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 15,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitIn = 45613,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 16,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitOut = 5689,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 17,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Network",
                MbitOut = 10241,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 18,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsRead = 63,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 19,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsRead = 945,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 20,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsWrite = 123,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
            modelBuilder.Entity<Usage>().HasData(new Usage
            {
                Id = 21,
                UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                Type = "Disk",
                IopsWrite = 280,
                Date = Convert.ToDateTime("2023-06-08 10:20:00"),
            });
        }

        public DbSet<Server> Servers { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Firewall> Firewalls { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
