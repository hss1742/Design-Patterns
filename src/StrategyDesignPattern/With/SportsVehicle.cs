namespace With
{
    public class SportsVehicle: Vehicle
    {
        public SportsVehicle() : base(new SportsDriveStrategy())
        {
            
        }
    }
}