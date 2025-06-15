using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class RENTAParser : AbstractSiteParser
    {
        public RENTAParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override async Task<ResponceModel[]?> ParseAsync(string request)
        {
            var node = "//*[@itemtype='http://schema.org/Product']";

            string nameNode = ".//*[contains(@class, 'grid-name')]/a",
                    balanceNode = ".//*[@class='grid-qty']/div/span",
                    articleNode = ".//*[contains(@class, 'grid-art')]/span",
                    manufacturerNode = ".//*[@itemprop='brand']",
                    costNode = ".//*[@class='grid-price']/span";

            var html = await GetHtmlAsync(string.Format(request_url, request));
            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);

            try
            {
                var nodes = doc.DocumentNode.SelectNodes(node)
                .Select(div => new ResponceModel(site, request)
                {
                    Name = div.SelectSingleNode(nameNode).InnerText,
                    Balance = div.SelectSingleNode(balanceNode).InnerText,
                    Article = div.SelectSingleNode(articleNode).InnerText,
                    Manufacturer = div.SelectSingleNode(manufacturerNode).InnerText,
                    Cost = div.SelectSingleNode(costNode).InnerText.Replace("&nbsp;", "").Replace("&#8381;", "₽"),
                }).ToArray();

                return nodes;
            }
            catch (ArgumentNullException ex)
            {
                return null;
            }
            catch (NullReferenceException)
            {
                string message = string.Format(
                    "Error with parse {0}. Probably, the site has changed the structure of the page.",
                    request
                );
                MessageBox.Show(message, "Modern-parts Error");
                return null;
            }
        }
    }
}
