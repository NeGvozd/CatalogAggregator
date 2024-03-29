﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class ResponceModel
    {
        [System.ComponentModel.DisplayName("Позиция")]
        public string? Request { get; set; }
        
        [System.ComponentModel.DisplayName("Сайт")]
        public Site? Site { get; set; }
        
        [System.ComponentModel.DisplayName("Наименование")]
        public string? Name { get; set; }

        [System.ComponentModel.DisplayName("Артикул")]
        public string? Article { get; set; }
        
        [System.ComponentModel.DisplayName("Цена")]
        public string? Cost { get; set; }

        [System.ComponentModel.DisplayName("Производитель")]
        public string? Manufacturer { get; set; }

        [System.ComponentModel.DisplayName("Наличие")]
        public string? Balance { get; set; }

        [System.ComponentModel.DisplayName("Доставка")]
        public string? DeliveryTime { get; set; }

        public ResponceModel(Site site, string request)
        {
            Site = site;
            Request = request;
            Name = null;
            Article = null;
            Cost = null;
            Manufacturer = null;
            Balance = null;
            DeliveryTime = null;
        }
    }

    internal class HeaderResponce : ResponceModel
    {
        public HeaderResponce(Site site, string request) : base(site, request)
        {
            Site = null;
            Name = null;
            Request = null;
        }
    }

    //internal class SNTResponce : ResponceModels
    //{
    //    public string? Manufacturer { get; set; }
    //    public string? Balance { get; set; }

    //    public SNTResponce(string request) : base(request)
    //    {
    //        Manufacturer = null;
    //        Balance = null;
    //    }
    //}

    //internal class T2KResponce : ResponceModels
    //{
    //    public string? Balance { get; set; }

    //    public T2KResponce(string request) : base(request)
    //    {
    //        Balance = null;
    //    }
    //}

    //internal class RENTAResponce : ResponceModels
    //{
    //    public string? Manufacturer { get; set; }
    //    public string? Balance { get; set; }

    //    public RENTAResponce(string request) : base(request)
    //    {
    //        Manufacturer = null;
    //        Balance = null;
    //    }
    //}

    //internal class UDTResponce : ResponceModels
    //{
    //    public string? Manufacturer { get; set; }
    //    public string? Balance { get; set; }
    //    public string? DeliveryTime { get; set; }

    //    public UDTResponce(string request) : base(request)
    //    {
    //        Manufacturer = null;
    //        Balance = null;
    //        DeliveryTime = null;
    //    }
    //}

    //internal class RECAResponce : ResponceModels
    //{
    //    public RECAResponce(string request) : base(request) { }
    //}

    //internal class AKPResponce : ResponceModels
    //{
    //    public string? Balance { get; set; }

    //    public AKPResponce(string request) : base(request)
    //    {
    //        Balance = null;
    //    }
    //}
}
