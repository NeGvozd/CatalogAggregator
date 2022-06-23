using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class T2KParser : AbstractSiteParser
    {
        public override Site site { get; } = Site.T2K;
        protected override string request_url { get; } = "https://t-2k.ru/search?q={0}";
        private string _table_class = "table-cart";

        public override ResponceModels[] Parse(string request)
        {
            var suitable = ParseTableToList(GetHtml(string.Format(request_url, request)), _table_class);
            var responces = new T2KResponce[suitable.Count];
            
            for (int i = 0; i < suitable.Count; i++)
            {
                var title = suitable[i][0].Split(' ', 2);
                responces[i] = new T2KResponce(request)
                {
                    Article = title[0],
                    Name = title[1],
                    Cost = suitable[i][6].Split('&', 2)[0],
                    Balance = suitable[i][7],
                };
            }

            return responces;
        }
    }
}
