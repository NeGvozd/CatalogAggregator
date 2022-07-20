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

        public override async Task<ResponceModel[]?> ParseAsync(string request)
        {
            var node = string.Format("//div[@class='{0}']", div_class);

            string oldPriceNode = "span/span[@class='old_price']",
                    newPriceNode = "span/span[@class='new_price']",
                    priceNode = "span/span[contains(@class, 'price__value')]",
                    articleNode = "span[@class='goods__articul ellipsis']",
                    searchLegendNode = "//div[@class='text search-legend']"; // amout of the founded results

            var html = await GetHtmlAsync(string.Format(request_url, request));
            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);

            try
            {
                var searchLegend = doc.DocumentNode.SelectSingleNode(searchLegendNode).InnerText;
                if (searchLegend.Contains(" 0 позиций."))
                    throw new ArgumentNullException();
                
                var nodes = doc.DocumentNode.SelectNodes(node)
                .Select(div => new ResponceModel(request)
                {
                    //Cost = string.Format(
                    //    "{0}-{1}",
                    //    div.SelectSingleNode(newPriceNode).InnerText,
                    //    div.SelectSingleNode(oldPriceNode).InnerText
                    //),
                    Cost = div.SelectSingleNode(priceNode).InnerText,
                    Name = div.SelectSingleNode("a").InnerText,
                    Article = div.SelectSingleNode(articleNode) != null ?
                        div.SelectSingleNode(articleNode).InnerText
                        .Split()[1] : null,
                }).ToArray();

                return nodes;
            }
            catch(ArgumentNullException ex)
            {
                return null;
            }           
        }
    }
}
