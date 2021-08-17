using System;

namespace Command
{
    //Concrete command

    public class TurnOnLightCommand : IHomeManagementCommand
    {
        private readonly Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}