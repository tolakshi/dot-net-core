using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandList = _repository.GetAppCommands();
            return Ok(commandList);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandById = _repository.GetAppCommandById(id);
            return Ok(commandById);
        }
    }
}