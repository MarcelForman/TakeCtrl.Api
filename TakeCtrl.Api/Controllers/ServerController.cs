using Microsoft.AspNetCore.Mvc;
using TakeCtrl.Api.Models.Dtos;
using TakeCtrl.Api.Repositories.Contracts;
using TakeCtrl.Api.Extensions;
using System.Data;

namespace TakeCtrl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : Controller
    {
        private readonly IServerRepository _serverRepository;
        public ServerController(IServerRepository _serverRepository)
        {
              this._serverRepository = _serverRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServerDto>>> GetServers()
        {
            try
            {
                var servers = await this._serverRepository.GetServers();
                
                if (servers == null)
                {
                    return NotFound();
                }
                else
                {
                    var serverDtos = servers.ConvertToDto();
                    return Ok(serverDtos);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPost("changestatus")]
        public async Task<ActionResult> ChangeStatus(ChangeStatus changeStatus)
        {
            try
            {
                var result = await this._serverRepository.ChangeStatus(changeStatus.UUID, changeStatus.Status);

                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok();
                }
            } catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    ex.Message);
            }
        }
    }
}
