using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;

namespace TakeCtrl.Api.Repositories.Contracts
{
    public interface IServerRepository
    {
        Task<IEnumerable<Server>> GetServers();
        Task<Server> ChangeStatus(string UUID, string status);
        Task<IEnumerable<Firewall>> GetFirewalls(string uuid);
        UsageDto GetAverageUsage(UsageReq usageReq);
    }
}
