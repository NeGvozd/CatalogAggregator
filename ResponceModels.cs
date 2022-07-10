using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class ResponceModels
    {
        public string? Request { get; set; }
        public string? Name { get; set; }
        public string? Article { get; set; }
        public string? Cost { get; set; }

        public ResponceModels(string request)
        {
            Request = request;
            Name = null;
            Article = null;
            Cost = null;
        }
    }

    internal class SNTResponce : ResponceModels
    {
        public string? Manufacturer { get; set; }
        public string? Balance { get; set; }
        
        public SNTResponce(string request) : base(request)
        {
            Manufacturer = null;
            Balance = null;
        }
    }

    internal class T2KResponce : ResponceModels
    {
        public string? Balance { get; set; }
        
        public T2KResponce(string request) : base(request)
        {
            Balance = null;
        }
    }

    internal class RENTAResponce : ResponceModels
    {
        public string? Manufacturer { get; set; }
        public string? Balance { get; set; }
        
        public RENTAResponce(string request) : base(request)
        {
            Manufacturer = null;
            Balance = null;
        }
    }

    internal class UDTResponce : ResponceModels
    {
        public string? Manufacturer { get; set; }
        public string? Balance { get; set; }
        public string? DeliveryTime { get; set; }

        public UDTResponce(string request) : base(request)
        {
            Manufacturer = null;
            Balance = null;
            DeliveryTime = null;
        }
    }

    internal class RECAResponce : ResponceModels
    {
        public RECAResponce(string request) : base(request) { }
    }

    internal class AKPResponce : ResponceModels
    {
        public string? Balance { get; set; }
        
        public AKPResponce(string request) : base(request)
        {
            Balance = null;
        }
    }
}
