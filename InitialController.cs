using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    public enum Site
    {
        SNT=1,
        UDT,
        T2K,
        REN,
        REC,
        AKP
    }


    internal class InitialController
    {
        private SNTParser snt;
        private T2KParser t2k;
        private RENTAParser ren;

        public InitialController()
        {
            snt = new SNTParser(Site.SNT, "https://snt-k.ru/catalog/");
            t2k = new T2KParser(Site.T2K, "https://t-2k.ru/search?q={0}");
            ren = new RENTAParser(Site.REN, "https://rentakom-parts.ru/search/?q={0}");
        }

        public void Start(List<Site> search_sites, List<string> searching_requests)
        {
            //var res = snt.Parse(searching_requests[0]);
            //var res = t2k.Parse(searching_requests[0]);
            var res = ren.Parse(searching_requests[0]);
        }
    }
}
