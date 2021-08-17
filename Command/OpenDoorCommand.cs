namespace Command
{
    //Concrete command

    public class OpenDoorCommand : IHomeManagementCommand
    {
        private readonly Door _door;

        public OpenDoorCommand(Door door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.OpenDoor();
        }
    }
}