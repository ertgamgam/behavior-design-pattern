using System;

namespace Command
{
    //Receiver class
    public class Door
    {
        public void OpenDoor() => Console.WriteLine("The door is opening");
        
        public void CloseDoor() => Console.WriteLine("The door is closing");
    }
}