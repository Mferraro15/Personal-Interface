using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Interface
{
    public class App : IEquatable<App>
    {
        public int ID { get; set; }
        public string AppName { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string LogoFileName { get; set; } = string.Empty;
        public string LogoPath { get; set; } = string.Empty;
        public string CommandLine { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public override string ToString()
        {
            return "ID: " + ID + "||Name: " + AppName + "||Version: " + Version;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            App objAsPart = obj as App;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public bool Equals(App other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }
}