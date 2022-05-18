using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            return true;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commandList = new List<Command>()
            {
                new Command { Id = 0, CommType = "Config", CommString = "Location", Platform = "All" },
                new Command { Id = 1, CommType = "System", CommString = "ProductType", Platform = "All" },
                new Command { Id = 2, CommType = "Slot", CommString = "Install", Platform = "All" },
                new Command { Id = 3, CommType = "Show", CommString = "Sessions", Platform = "All" }

            };

            return commandList;
        }
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, CommType = "Config", CommString = "Location", Platform = "All" };
        }

        public void CreateCommand(Command cmd)
        {


        }

        public void UpdateCommand(Command cmd)
        {


        }
    }
}