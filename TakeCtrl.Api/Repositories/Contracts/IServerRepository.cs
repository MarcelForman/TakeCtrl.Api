using TakeCtrl.Api.Entities;

namespace TakeCtrl.Api.Repositories.Contracts
{
    public interface IServerRepository
    {
        Task<IEnumerable<Server>> GetServers();
    }
}
