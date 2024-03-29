﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    internal class AKPParser : AbstractSiteParser
    {
        private string div_class = "catalog_item";

        public AKPParser(Site s, string url, double? dc = null) : base(s, url, dc) { }

        public override async Task<ResponceModel[]?> ParseAsync(string request)
        {
            var node = string.Format("//div[contains(@class, '{0}')]", div_class);

            string nameNode = ".//*[@class='item-title']/a/span",
                    balanceNode = ".//*[contains(@class, 'item-stock')]/span[contains(@class, 'value')]",
                    articleNode = ".//*[@class='article_block']/div",
                    costNode = ".//span[@class='price_value']";

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
                    Article = div.SelectSingleNode(articleNode).InnerText.Split()[1],
                    Cost = div.SelectSingleNode(costNode).InnerText.Replace("&nbsp;", ""),
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
                MessageBox.Show(message, "Akp Error");
                return null;
            }
        }
    }
}
