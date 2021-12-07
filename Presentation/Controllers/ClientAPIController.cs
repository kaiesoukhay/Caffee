using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace Presentation.Controllers
{
    [Route("api/Client")]
    [ApiController]
    public class ClientAPIController : ControllerBase
    {
        private readonly IClientService _repo;
        public ClientAPIController(IClientService repo)
        {
            _repo = repo;

        }
        [HttpPost]
        public ActionResult<Clients> CreateClient(Clients client)
        {
            var PesisteClient = _repo.AddClient(client);
            return Ok(PesisteClient);
        }
    }
}
