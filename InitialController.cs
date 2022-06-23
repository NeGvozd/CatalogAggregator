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

        public InitialController()
        {
            snt = new SNTParser();
            t2k = new T2KParser();
        }

        public void Start(List<Site> search_sites, List<string> searching_requests)
        {
            //var res = snt.Parse(searching_requests[0]);
            var res = t2k.Parse(searching_requests[0]);
        }
    }
}
