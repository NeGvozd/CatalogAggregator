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
            var node = string.Format("//div[@class='{0}']", div_class);
            
            string  oldPriceNode = "span/span[@class='new_price']",
                    newPriceNode = "span/span[@class='old_price'",
                    articleNode = "span[@class='goods__articul ellipsis']";

            var html = GetHtml(string.Format(request_url, request));
            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes(node)
                .Select(div => new RECAResponce(request)
                {
                    Cost = string.Format(
                        "{0}-{1}",
                        div.SelectSingleNode(newPriceNode).InnerText,
                        div.SelectSingleNode(oldPriceNode).InnerText
                    ),
                    Name = div.SelectSingleNode("a").InnerText,
                    Article = div.SelectSingleNode(articleNode) != null ?
                        div.SelectSingleNode(articleNode).InnerText
                        .Split()[1] : null,
                }).ToArray();

            return nodes;
        }
    }
}
