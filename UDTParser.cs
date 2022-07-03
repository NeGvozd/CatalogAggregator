using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class UDTParser : AbstractSiteParser
    {
        private string _table_class = "table table-striped table-borderless";

        public UDTParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override ResponceModels[] Parse(string request)
        {
            var suitable = ParseTableToList(PostRequest(request), _table_class);
            var responces = suitable.Select(s => new UDTResponce(request)
            {
                Name = s[0],
                Article = s[1],
                DeliveryTime = s[3],
                Balance = s[4],
                Cost = s[6],
                Manufacturer = s[7],
            }).ToArray();
            
            return responces;
        }
    }
}
