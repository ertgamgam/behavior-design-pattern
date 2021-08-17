using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeManager homeManager = new HomeManager();

            Light light = new Light();
            Door door = new Door();

            homeManager.AddCommand(new OpenDoorCommand(door));
            homeManager.AddCommand(new TurnOnLightCommand(light));
            homeManager.AddCommand(new CloseDoorCommand(door));
            homeManager.AddCommand(new TurnOffLightCommand(light));

            homeManager.ExecuteAllCommandReversed();
            Console.WriteLine("----");
            homeManager.ExecuteAllCommands();
        }
    }
}