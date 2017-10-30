using System.Management;
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace WMI
{
    class Program
    {       
        public static void Main(string[] args)
        {
            Devices devices = new PCIDevices();
            foreach (var device in devices.findDevices())
            {
                Console.WriteLine("VendorID: {0} , DeviceID {1}", device.getVendorID(), device.getDeviceID());
            }
            Console.ReadKey();
        }
    }
}