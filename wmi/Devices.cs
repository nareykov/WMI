using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMI
{
    interface Devices
    {
        List<DeviceInfo> findDevices();
    }
}
