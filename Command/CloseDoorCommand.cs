namespace Command
{
    //Concrete command class
    public class CloseDoorCommand : IHomeManagementCommand
    {
        
        private readonly Door _door;

        public CloseDoorCommand(Door door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.CloseDoor();
        }
    }
}