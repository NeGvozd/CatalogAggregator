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
        //private SNTParser snt;
        private UDTParser udt;
        private T2KParser t2k;
        private RENTAParser ren;
        private RECAParser rec;
        private AKPParser akp;

        public InitialController()
        {
            //snt = new SNTParser(Site.SNT, "https://snt-k.ru/catalog/");
            udt = new UDTParser(Site.UDT, "https://www.udt-technika.ru/search/");
            t2k = new T2KParser(Site.T2K, "https://t-2k.ru/search?q={0}");
            ren = new RENTAParser(Site.REN, "https://rentakom-parts.ru/search/?q={0}");
            rec = new RECAParser(Site.REC, "https://recamgr.ru/products/?search={0}");
            akp = new AKPParser(Site.AKP, "https://akpart.ru/catalog/?q={0}");
        }

        public void Start(List<Site> search_sites, List<string> searching_requests)
        {
            var res = akp.Parse(searching_requests[0]);
        }
    }
}
