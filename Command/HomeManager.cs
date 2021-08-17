using System.Collections.Generic;
using System.Linq;

namespace Command
{
    //Invoker class
    public class HomeManager
    {
        private List<IHomeManagementCommand> _commands = new List<IHomeManagementCommand>();

        public void AddCommand(IHomeManagementCommand command) => _commands.Insert(0, command);

        public void ExecuteAllCommands()
        {
            _commands.ToList().ForEach(x => x.Execute());
        }

        public void ExecuteAllCommandReversed() => _commands.AsEnumerable()
            .Reverse()
            .ToList()
            .ForEach(x => x.Execute());
    }
}