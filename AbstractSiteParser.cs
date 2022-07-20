namespace WorkParser2
{
    internal abstract class AbstractSiteParser
    {
        public virtual Site site { get; }
        protected virtual string request_url { get; }
        protected virtual double discount { get; set; }

        protected AbstractSiteParser(Site s, string url, double? dc=null)
        {
            site = s;
            request_url = url;
            discount = dc ?? 1.0;
        }

        abstract public Task<ResponceModel[]?> ParseAsync(string request);

        protected async Task<string> GetHtmlAsync(string? url = null)
        {
            url = string.IsNullOrEmpty(url) ? request_url : url;

            using (HttpClient client = new())
            {
                var res = await client.GetStringAsync(url);
                return res;
            }
        }

        protected async Task<string> PostRequestAsync(string request)
        {
            using (HttpClient client = new())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                    { "parts", request },
                });

                var response = await client.PostAsync(request_url, content);                
                var res = await response.Content.ReadAsStringAsync();
                return res;
            }
        }

        protected List<List<string>>? ParseTableToList(string html, string table_class)
        {
            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);

            var node = string.Format("//table[@class='{0}']", table_class);

            try
            {
                var table = doc.DocumentNode.SelectSingleNode(node)
                .Descendants("tr").Skip(1)
                .Where(tr => tr.Elements("td").Count() > 1)
                .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                .ToList();

                return table;
            }
            catch (Exception)
            {
                //throw;
                return null;
            }           
        }
    }
}
