using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class RENTAParser : AbstractSiteParser
    {
        private string _table_class = "table catalogSection_table";

        public RENTAParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override ResponceModels[] Parse(string request)
        {
            var suitable = ParseTableToList(GetHtml(string.Format(request_url, request)), _table_class);
            suitable.RemoveAll(x => x[5].Contains("заказ"));

            var responces = suitable.Select(s => new RENTAResponce(request)
            {
                Name = s[2],
                Article = s[1].Split(' ', 2)[0],
                Cost = s[4].Replace("&nbsp;", "").Split('₽')[0],
                Manufacturer = s[0],
                Balance = s[5].Replace("&nbsp;", " "),
            }).ToArray();

            return responces;
        }
    }
}
