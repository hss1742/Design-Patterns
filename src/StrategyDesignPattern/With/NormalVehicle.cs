namespace With
{
    public class NormalVehicle: Vehicle
    {
        public NormalVehicle() : base(new NormalDriveStrategy())
        {
            
        }
    }
}