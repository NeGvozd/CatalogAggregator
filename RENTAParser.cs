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
            var responces = new RENTAResponce[suitable.Count];

            for (int i=0; i < suitable.Count; i++)
            {
                if (suitable[i][5].Contains("заказ")) continue;
                responces[i] = new RENTAResponce(request)
                {
                    Article = suitable[i][1].Split(' ', 2)[0],
                    Name = suitable[i][2],
                    Cost = suitable[i][4].Replace("&nbsp;", "").Split('₽')[0],
                    Manufacturer = suitable[i][0],
                    Balance = suitable[i][5].Replace("&nbsp;", " "),
                };
            }

            return responces;
        }
    }
}
