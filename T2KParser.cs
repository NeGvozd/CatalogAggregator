using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class T2KParser : AbstractSiteParser
    {
        private string _table_class = "table-cart";

        public T2KParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override ResponceModels[] Parse(string request)
        {
            var suitable = ParseTableToList(GetHtml(string.Format(request_url, request)), _table_class);
            var responces = suitable.Select(s => new T2KResponce(request)
            {
                Article = s[0],
                Name = s[1],
                Cost = s[6].Split('&', 2)[0],
                Balance = s[7],
            }).ToArray();

            return responces;
        }
    }
}
