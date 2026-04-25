namespace With
{
    public class Vehicle
    {
        public DriveStrategy driveObj;

        public Vehicle(DriveStrategy obj)
        {
            driveObj = obj;
        }

        public void Drive()
        {
            driveObj.Drive();
        }
    }
}