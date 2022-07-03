using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class RECAParser : AbstractSiteParser
    {
        private string div_class = "goods__item";
        
        public RECAParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override ResponceModels[] Parse(string request)
        {
            var html = GetHtml(string.Format(request_url, request));

            var node = string.Format("//div[@class='{0}']", div_class);

            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes(node)
                .Select(div => new RECAResponce(request)
                {
                    Cost = string.Format(
                        "{0}-{1}",
                        div.SelectSingleNode("span/span[@class='new_price']").InnerText,
                        div.SelectSingleNode("span/span[@class='old_price']").InnerText
                    ),
                    Name = div.SelectSingleNode("a").InnerText,
                    Article = div.SelectSingleNode("span[@class='goods__articul ellipsis']")
                        .InnerText
                        .Split()[1],
                }).ToArray();

            return nodes;
        }
    }
}
