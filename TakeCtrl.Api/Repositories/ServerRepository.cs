using Microsoft.EntityFrameworkCore;
using TakeCtrl.Api.Data;
using TakeCtrl.Api.Entities;
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
    }
}
