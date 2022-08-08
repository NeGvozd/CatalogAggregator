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

        public override async Task<ResponceModel[]?> ParseAsync(string request)
        {
            var suitable = ParseTableToList(await GetHtmlAsync(string.Format(request_url, request)), _table_class);
            
            if (suitable == null) return null;
            
            var responces = suitable.Select(s => new ResponceModel(site, request)
            {
                Article = s[0].Split(' ', 2)[0],
                Name = s[0].Split(' ', 2)[1],
                Cost = s[6].Split('&', 2)[0],
                Balance = s[7],
            }).ToArray();

            return responces;
        }
    }
}
