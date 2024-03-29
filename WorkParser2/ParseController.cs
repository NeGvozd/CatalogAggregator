﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class ParseController
    {
        private Dictionary<Site, AbstractSiteParser> sites;

        public ParseController()
        {
            sites = new Dictionary<Site, AbstractSiteParser>
            {
                { Site.SNT, new SNTParser(Site.SNT, "https://snt-k.ru/catalog/") },
                { Site.UDT, new UDTParser(Site.UDT, "https://www.udt-technika.ru/search/") },
                { Site.T2K, new T2KParser(Site.T2K, "https://t-2k.ru/search?q={0}") },
                { Site.REN, new RENTAParser(Site.REN, "https://rentakom-parts.ru/search/?q={0}") },
                { Site.REC, new RECAParser(Site.REC, "https://recamgr.ru/products/?search={0}") },
                { Site.AKP, new AKPParser(Site.AKP, "https://akpart.ru/catalog/?q={0}") }
            };
        }

        public List<ResponceModel> Parse(List<Site> search_sites, string request)
        {
            var tasks = sites.Where(s => search_sites
            .Contains(s.Key))
                .Select(s => s.Value
                .ParseAsync(request))
            .ToArray();
            Task.WhenAll(tasks);
            //return tasks.SelectMany(x => x.Result).ToArray();
            return tasks.Where(x => x.Result != null).SelectMany(x => x.Result).ToList();
        }
    }
}
