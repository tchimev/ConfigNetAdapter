using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConfigNetAdapter.BO
{
    [Serializable]
    public class Profile : INotifyPropertyChanged, IDataErrorInfo
    {
        #region Business methods

        private string _name = string.Empty;
        public string Name 
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        private string _ipaddress = string.Empty;
        public string IPAddress 
        {
            get { return _ipaddress; }
            set
            {
                if (_ipaddress != value)
                {
                    _ipaddress = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("IPAddress"));
                }
            }
        }

        private string _submask = string.Empty;
        public string Submask 
        {
            get { return _submask; }
            set
            {
                if (_submask != value)
                {
                    _submask = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("Submask"));
                }
            }
        }

        private string _gateway = string.Empty;
        public string Gateway 
        {
            get { return _gateway; }
            set
            {
                if (_gateway != value)
                {
                    _gateway = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("Gateway"));
                }
            }
        }

        private string _prefDns = string.Empty;
        public string PrefDNS 
        {
            get { return _prefDns; }
            set
            {
                if (_prefDns != value)
                {
                    _prefDns = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("PrefDNS"));
                }
            }
        }

        private string _altDns = string.Empty;
        public string AltDNS 
        {
            get { return _altDns; }
            set
            {
                if (_altDns != value)
                {
                    _altDns = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("AltDNS"));
                }
            }
        }

        private bool _aipaddress = false;
        public bool AutomaticIPAddress 
        {
            get { return _aipaddress; }
            set
            {
                if (_aipaddress != value)
                {
                    _aipaddress = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("AutomaticIPAddress"));
                }
            }
        }

        private bool _adnsaddress = false;
        public bool AutomaticDNSAddress 
        {
            get { return _adnsaddress; }
            set 
            {
                if (_adnsaddress != value)
                {
                    _adnsaddress = value;
                    this.Validate();
                    OnPropertyChanged(this, new PropertyChangedEventArgs("AutomaticDNSAddress"));
                }
            }
        }

        private bool _isValid = false;
        public bool IsValid 
        {
            get { return _isValid; }
            private set 
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    OnPropertyChanged(this, new PropertyChangedEventArgs("IsValid"));
                }
            }
        }

        public string Path { get { return System.Environment.CurrentDirectory + @"\Profiles\" + this.Name + ".xml"; } }

        private void Validate()
        {
            // ip address expresion
            string exp = @"(([0-1]?[0-9]{1,2}\.)|(2[0-4][0-9]\.)|(25[0-5]\.)){3}(([0-1]?[0-9]{1,2})|(2[0-4][0-9])|(25[0-5]))";
            bool isBG = Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName == "bul";

            if (this.AutomaticIPAddress)
            {
                this._errors["IPAddress"] = string.Empty;
                this._errors["Submask"] = string.Empty;
                this._errors["Gateway"] = string.Empty;
            }
            else 
            {
                this._errors["IPAddress"] = !Regex.IsMatch(this.IPAddress, exp) ? (isBG ? "Въведете валиден адрес" : "Enter valid ip address") : string.Empty;
                this._errors["Submask"] = !Regex.IsMatch(this.Submask, exp) ? (isBG ? "Въведете валиден адрес" : "Enter valid subnet mask") : string.Empty;
                this._errors["Gateway"] = !Regex.IsMatch(this.Gateway, exp) ? (isBG ? "Въведете валиден адрес" : "Enter valid gateway address") : string.Empty;
            }
            if (this.AutomaticDNSAddress)
            {
                this._errors["AltDNS"] = string.Empty;
                this._errors["PrefDNS"] = string.Empty;
            }
            else 
            {
                this._errors["AltDNS"] = !Regex.IsMatch(this.AltDNS, exp) ? (isBG ? "Въведете валиден адрес" : "Enter valid dns address") : string.Empty;
                this._errors["PrefDNS"] = !Regex.IsMatch(this.PrefDNS, exp) ? (isBG ? "Въведете валиден адрес" : "Enter valid dns address") : string.Empty;
            }
            this._errors["Name"] = this.Name == string.Empty ? (isBG ? "Въведете име" : "Enter name") : string.Empty;
            this.IsValid = this._errors.Values.All(s=>s == string.Empty);
        }
        #endregion

        #region Factory methods

        private Profile() { }

        public static Profile New()
        {
            Profile p = new Profile();
            p.Validate();
            return p;
        }

        public static Profile Create(string name, string ipaddress, string submask, string gateway, string dns1, string dns2)
        {
            Profile p = new Profile();
            p._name = name;
            p._ipaddress = ipaddress;
            p._submask = submask;
            p._gateway = gateway;
            p._prefDns = dns1;
            p._altDns = dns2;
            p.Validate();

            return p;
        }

        public static Profile Load(string filepath)
        {
            Profile p = new Profile();
            XDocument doc = XDocument.Load(filepath);
            p._name = doc.Element("profile").Attribute("name").Value;
            if (doc.Element("profile").Element("automatic") != null)
            {
                p._aipaddress = true;
                p._adnsaddress = true;
            }
            else
            {
                p._ipaddress = doc.Element("profile").Element("ipaddress").Value;
                p._submask = doc.Element("profile").Element("submask").Value;
                p._gateway = doc.Element("profile").Element("gateway").Value;
                p._prefDns = doc.Element("profile").Element("prefdns").Value;
                p._altDns = doc.Element("profile").Element("altdns").Value;
            }
            p.Validate();

            return p;
        }

        #endregion

        public void Save()
        {
            if (this.IsValid)
            {
                XDocument doc = null;
                if (this.AutomaticDNSAddress && this.AutomaticIPAddress)
                    doc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("profile",
                            new XAttribute("name", this.Name),
                                new XElement("automatic", true)
                                )
                         );
                else
                    doc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("profile",
                            new XAttribute("name", this.Name),
                                new XElement("ipaddress", this.IPAddress),
                                new XElement("submask", this.Submask),
                                new XElement("gateway", this.Gateway),
                                new XElement("prefdns", this.PrefDNS),
                                new XElement("altdns", this.AltDNS)
                                )
                         );
                doc.Save(this.Path);
            }
        }

        public void Delete()
        {
            if (this.IsValid)
                File.Delete(this.Path);
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(sender, e);
        }

        #endregion

        #region IDataErrorInfo Members

        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        public string Error
        {
            get { return string.Empty; }
        }

        public string this[string columnName]
        {
            get 
            {
                if (this._errors.ContainsKey(columnName))
                    return this._errors[columnName];
                return string.Empty;
            }
        }

        #endregion
    }

    [Serializable]
    public class Profiles : List<Profile>
    {
        private Profiles() { }

        public static Profiles GetAll()
        {
            Profiles ps = new Profiles();
            string[] files = Directory.GetFiles(System.Environment.CurrentDirectory + @"\Profiles\");
            foreach (var item in files)
                ps.Add(Profile.Load(item));

            return ps;
        }
    }
}
