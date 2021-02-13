using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Management;

namespace ConfigNetAdapter
{
    //public class Class1
    //{
    //    public static void Start()
    //    {
    //        NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();
    //        NetworkInterface wifi = null;
    //        ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
    //        ManagementObjectCollection objMOC = objMC.GetInstances();

    //        foreach (var item in ni)
    //        {
    //            if (item.OperationalStatus == OperationalStatus.Up)
    //                wifi = item;
    //        }

    //        string ipAddress = string.Empty;
    //        string[] gateways = new string[2];
    //        string subnetmask = string.Empty;
    //        string[] dnss = new string[2];
    //        foreach (ManagementObject item in objMOC)
    //        {
    //            if (!(bool)item["IPEnabled"] && !((string)item["Caption"]).Contains(wifi.Description))
    //                continue;

    //            Console.WriteLine(item["Caption"] + ", MAC: " + item["MACAddress"]);

    //            ipAddress = (item["IPAddress"] as string[])[0];
    //            gateways = ((string[])item["DefaultIPGateway"]);
    //            subnetmask = ((string[])item["IPSubnet"])[0];
    //            dnss = (string[])item["DNSServerSearchOrder"];
    //        }
    //        ConfigAdapter(ipAddress, subnetmask, gateways, dnss, wifi.Description);
    //    }

    //    public static void ConfigAdapter(string ipAddress, string subnetMask, string[] gateways, string[] dnss, string adapterName)
    //    {
    //        ManagementClass objMC = new ManagementClass(
    //            "Win32_NetworkAdapterConfiguration");
    //        ManagementObjectCollection objMOC = objMC.GetInstances();
    //        try
    //        {
    //            foreach (ManagementObject objMO in objMOC)
    //            {
    //                if (!(bool)objMO["IPEnabled"] && !((string)objMO["Caption"]).Contains(adapterName))
    //                    continue;
    //                ManagementBaseObject objSetIP = null;
    //                ManagementBaseObject objNewIP = null;
    //                ManagementBaseObject objNewGate = null;
    //                ManagementBaseObject objNewDns = null;


    //                objNewIP = objMO.GetMethodParameters("EnableStatic");
    //                objNewGate = objMO.GetMethodParameters("SetGateways");
    //                objNewDns = objMO.GetMethodParameters("SetDNSServerSearchOrder");

    //                //Set DNS addresses

    //                objNewDns["DNSServerSearchOrder"] = dnss;

    //                //Set DefaultGateway

    //                objNewGate["DefaultIPGateway"] = gateways;
    //                objNewGate["GatewayCostMetric"] = new int[] { 1 };

    //                //Set IPAddress and Subnet Mask

    //                objNewIP["IPAddress"] = new string[] { ipAddress };
    //                objNewIP["SubnetMask"] = new string[] { subnetMask };

    //                objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, null);
    //                objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, null);
    //                objSetIP = objMO.InvokeMethod("SetDNSServerSearchOrder", objNewDns, null);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new InvalidOperationException("Unable to configure adapter: " + ex.Message, ex);
    //        }
    //        finally
    //        {
    //            objMC.Dispose();
    //        }
    //    }
    //}
}
