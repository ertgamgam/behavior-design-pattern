using System;

namespace Command
{
    //Receiver class
    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light is turning on");

        public void TurnOff() => Console.WriteLine("Light is turning off");
    }
}