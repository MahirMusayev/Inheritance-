using Inheritance_task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Device classı var
//Width, Height, Weight field-ları olur.
//OpenDevice və CloseDevice voidləri var.
//Əgər DeviceOpen ilk dəfə və ya DeviceClose methodundan sonra işlənirsə ekrana “Device opening…” yazısını versin. 
//Əgər bir neçə dəfə ardıcıl olaraq çağırılıbsa “Device already opened” yazılsın. Qanuna uyğunluq DeviceClose voidi üçün də keçərlidir.
namespace Inheritance_task
{
    internal class Device
    {
        public double Width;
        public double Height;
        public double Weight;
        public Device(double width, double height, double weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }
        private bool Open = false;
        public void OpenDevice()
        {
            if (!Open)
            {
                Console.WriteLine("Device opening…");
                Open = true;
            }
            else
            {
                Console.WriteLine("Device already opened");
            }
        }
        public void CloseDevice()
        {
            if (Open)
            {
                Console.WriteLine("Device closing...");
                Open = false;
            }
            else
            {
                Console.WriteLine("Device is not opened yet");
            }
        }
    }
}