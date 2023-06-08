using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;

namespace TakeCtrl.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ServerDto> ConvertToDto(this IEnumerable<Server> servers)
        {
            return (from server in servers
                    select new ServerDto
                    {
                        UUID = server.UUID,
                        Name = server.Name,
                        CPUAmount = server.CPUAmount,
                        DiskSize = server.DiskSize,
                        MemorySize = server.MemorySize,
                        Status = server.Status,
                        IPAddress = server.IPAddress
                    }).ToList();
        }
    }
}
