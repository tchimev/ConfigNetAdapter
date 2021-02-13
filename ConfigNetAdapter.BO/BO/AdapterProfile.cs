using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace ConfigNetAdapter.BO
{
    [Serializable]
    public class AdapterProfile : IDisposable
    {
        enum AdapterErrors
        {
            RequiredReboot = 1,
            NotSupportedPlatform = 64,
            UnknownFailure = 65,
            InvalidSubnetMask = 66,
            InvalidIPAddress = 70,
            InvalidGateway = 71,
            InvalidDomain = 73,
            InvalidHost = 74,
            UnableToConfigureTCPIP = 80,
            UnableToConfigDHCP = 81,
            IPNotEnabled = 84,
            AccessDenied = 91,
            AlreadyExists = 93,
        }

        private ManagementObject _networkAdapter;

        public string AdapterName { get; set; }

        public Profile Profile { get; set; }

        public static AdapterProfile Create(string name, Profile profile)
        {
            if (string.IsNullOrEmpty(name) || profile == null)
                throw new NotSupportedException("AdapterProfile.Create(): Invalid parameters!");

            AdapterProfile ap = new AdapterProfile();
            ap.AdapterName = name;
            ap.Profile = profile;
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                foreach (ManagementObject item in mc.GetInstances())
                    if (((string)item["Caption"]).Contains(ap.AdapterName) && (bool)item["IPEnabled"])
                    {
                        ap._networkAdapter = item;
                        break;
                    }
            }
            if (ap._networkAdapter == null)
                throw new NotSupportedException("Critical error: network adapter " + ap.AdapterName + " not found.");

            return ap;
        }

        private AdapterProfile() { }

        void EnableDHCP()
        {
            object dhcpResult = this._networkAdapter.InvokeMethod("EnableDHCP", null);
            if (Convert.ToInt32(dhcpResult) != 0)
                throw new Exception(Enum.GetName(typeof(AdapterErrors), dhcpResult));
        }
        void EnableStaticIPAddress()
        {
            object[] ipParams = new object[] { new string[] { this.Profile.IPAddress }, new string[] { this.Profile.Submask } };
            object[] gatewayParams = new object[] { new string[] { this.Profile.Gateway }, new int[] { 1 } };

            // set ip
            object ipResult = this._networkAdapter.InvokeMethod("EnableStatic", ipParams);
            if (Convert.ToInt32(ipResult) != 0)
                throw new Exception(Enum.GetName(typeof(AdapterErrors), ipResult));
            // set gateway
            object gatewayResult = this._networkAdapter.InvokeMethod("SetGateways", gatewayParams);
            if (Convert.ToInt32(gatewayResult) != 0)
                throw new Exception(Enum.GetName(typeof(AdapterErrors), gatewayResult));
        }
        void SetDNSAddress()
        {
            object[] dnsParams = null;
            if (!(this.Profile.AutomaticDNSAddress))
                dnsParams = new object[] { new string[] { this.Profile.PrefDNS, this.Profile.AltDNS } };

            //Set DNS addresses
            object dnsResult = this._networkAdapter.InvokeMethod("SetDNSServerSearchOrder", dnsParams);
            if (Convert.ToInt32(dnsResult) != 0)
                throw new Exception(Enum.GetName(typeof(AdapterErrors), dnsResult));
        }

        public void ApplyProfile()
        {
            #region Old apply
            //ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //try
            //{
            //    ManagementObjectCollection moc = mc.GetInstances();
            //    foreach (ManagementObject mo in moc)
            //    {
            //        if (!((string)mo["Caption"]).Contains(this.AdapterName) && !(bool)mo["IPEnabled"])
            //            continue;
            //        //Set IP address
            //        if (this.Profile.AutomaticIPAddress)
            //        {
            //            object dhcpResult = mo.InvokeMethod("EnableDHCP", null);
            //            if (Convert.ToInt32(dhcpResult) != 0)
            //                throw new Exception(Enum.GetName(typeof(AdapterErrors), dhcpResult));
            //        }
            //        else
            //        {
            //            object[] ipParams = new object[] { new string[] { this.Profile.IPAddress }, new string[] { this.Profile.Submask } };
            //            object[] gatewayParams = new object[] { new string[] { this.Profile.Gateway }, new int[] { 1 } };

            //            // set ip
            //            object ipResult = mo.InvokeMethod("EnableStatic", ipParams);
            //            if (Convert.ToInt32(ipResult) != 0)
            //                throw new Exception(Enum.GetName(typeof(AdapterErrors), ipResult));
            //            // set gateway
            //            object gatewayResult = mo.InvokeMethod("SetGateways", gatewayParams);
            //            if (Convert.ToInt32(gatewayResult) != 0)
            //                throw new Exception(Enum.GetName(typeof(AdapterErrors), gatewayResult));
            //        }

            //        object[] dnsParams = null;
            //        if (!(this.Profile.AutomaticDNSAddress))
            //            dnsParams = new object[] { new string[] { this.Profile.PrefDNS, this.Profile.AltDNS } };

            //        //Set DNS addresses
            //        object dnsResult = mo.InvokeMethod("SetDNSServerSearchOrder", dnsParams);
            //        if (Convert.ToInt32(dnsResult) != 0)
            //            throw new Exception(Enum.GetName(typeof(AdapterErrors), dnsResult));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new InvalidOperationException("Unable to configure adapter: " + ex.Message, ex);
            //}
            //finally
            //{
            //    mc.Dispose();
            //}
            #endregion

            if (this.Profile.AutomaticIPAddress)
                this.EnableDHCP();
            else
                this.EnableStaticIPAddress();
            this.SetDNSAddress();
        }

        public void Dispose()
        {
            if (this._networkAdapter != null)
                this._networkAdapter.Dispose();
        }
    }
}
