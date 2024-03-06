namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle1 = VehicleFactory.GetVehicle(4);
            vehicle1.Drive();

            IVehicle vehicle2 = VehicleFactory.GetVehicle(2);
            vehicle2.Drive();
        }
    }
}
