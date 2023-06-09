using Microsoft.EntityFrameworkCore;
using TakeCtrl.Api.Data;
using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;
using TakeCtrl.Api.Repositories.Contracts;

namespace TakeCtrl.Api.Repositories
{
    public class ServerRepository : IServerRepository
    {
        private readonly TakeCtrlDbContext takeCtrlDbContext;
        public ServerRepository(TakeCtrlDbContext takeCtrlDbContext)
        {
            this.takeCtrlDbContext = takeCtrlDbContext;
        }

        public TakeCtrlDbContext TakeCtrlDbContext { get; }

        public async Task<IEnumerable<Server>> GetServers()
        {
            var servers = await this.takeCtrlDbContext.Servers.ToListAsync();

            return servers;
        }

        public async Task<Server> ChangeStatus(string UUID, string status)
        {
            var result = await this.takeCtrlDbContext.Servers.SingleOrDefaultAsync(s => s.UUID == UUID);
            if (result != null)
            {
                result.Status = status;
                this.takeCtrlDbContext.SaveChanges();
                return result;
            }

            return default(Server);
        }

        public async Task<IEnumerable<Firewall>> GetFirewalls(string uuid)
        {
            var result = await this.takeCtrlDbContext.Firewalls.Where(s => s.UUID == uuid).ToListAsync();

            if (result != null)
            {
                return result;
            }

            return Enumerable.Empty<Firewall>();
        }

        public UsageDto GetAverageUsage(string uuid)
        {
            /*            var avgCpu = (from usage in takeCtrlDbContext.Usages
                                      where usage.UUID == uuid
                                      select (g => new UsageDto
                                      {
                                          CpuAvg = g.Select(a => a.CpuAvg).Average(),
                                          DiskAvg = g.Select(d => d.DiskAvg).Average(),
                                          NetworkAvg = g.Select(n => n.NetworkAvg).Average(),
                                      });*/
            /*            var avg = db.Courses
                                    .Where(c => c.StudentId == Id && c.Score != null)
                                    .Average(c => c.Score);*/
            
            var cpuAvg = this.takeCtrlDbContext.Usages
                .Where(c => c.UUID == uuid)
                .Average(c => c.Percent);
            var diskReadAvg = this.takeCtrlDbContext.Usages
                .Where(c => c.UUID == uuid)
                .Average(c => c.IopsRead);
            var diskWriteAvg = this.takeCtrlDbContext.Usages
                .Where(c => c.UUID == uuid)
                .Average(c => c.IopsWrite);
            var networkInAvg = this.takeCtrlDbContext.Usages
                .Where(c => c.UUID == uuid)
                .Average(c => c.MbitIn);
            var networkOutAvg = this.takeCtrlDbContext.Usages
                .Where(c => c.UUID == uuid)
                .Average(c => c.MbitOut);
            //cpuAvg = 5.0;
            //cpuAvg = cpuAvg ?? -1.0;

            return new UsageDto
            {
                CpuAvg = (int)(cpuAvg ?? -1.0),
                DiskReadAvg = (int)(diskReadAvg ?? -1.0),
                DiskWriteAvg = (int)(diskWriteAvg ?? -1.0),
                NetworkInAvg = (int)(networkInAvg ?? -1.0),
                NetworkOutAvg = (int)(networkOutAvg ?? -1.0)
            };

        }
    }
}
