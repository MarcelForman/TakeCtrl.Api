using TakeCtrl.Api.Entities;

namespace TakeCtrl.Api.Repositories.Contracts
{
    public interface IServerRepository
    {
        Task<IEnumerable<Server>> GetServers();
        Task<Server> ChangeStatus(string UUID, string status);
        Task<IEnumerable<Firewall>> GetFirewalls(string uuid);
    }
}
