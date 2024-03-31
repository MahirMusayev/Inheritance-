namespace Inheritance_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device(20, 25, 10);
            device.OpenDevice();
            device.OpenDevice();
            device.CloseDevice();
            device.CloseDevice();

            Console.WriteLine("  ");

            Mobile mobile = new Mobile(20, 25, 10,2);
            mobile.AddNumber(1, "333545");
            mobile.GetNumbers();
            mobile.RemoveNumber(1);
            mobile.GetNumbers();

            Console.WriteLine("  ");
        }
    }
}
