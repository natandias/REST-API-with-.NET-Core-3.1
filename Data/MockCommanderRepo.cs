using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command> {
         new Command { Id = 0, HowTo = "mock0", Line = "anotherMock0", Platform = "oh! one more mock0" },
         new Command { Id = 1, HowTo = "mock1", Line = "anotherMock1", Platform = "oh! one more mock1" },
         new Command { Id = 2, HowTo = "mock2", Line = "anotherMock2", Platform = "oh! one more mock2" }
       };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "mock", Line = "anotherMock", Platform = "oh! one more mock" };
    }
  }
}