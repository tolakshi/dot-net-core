using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetAppCommandById(int id);
    }
}