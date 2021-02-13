using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace ConfigNetAdapter.BO
{
    public class Adapters : List<string>
    {
        public static Adapters GetAll()
        {
            Adapters ads = new Adapters();
            NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var item in ni)
            {
                if ((item.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    item.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) &&
                    item.OperationalStatus == OperationalStatus.Up)
                    ads.Add(item.Description);
            }

            return ads;
        }

        private Adapters() { }
    }
}
