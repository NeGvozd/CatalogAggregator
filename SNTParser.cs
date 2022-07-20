using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WorkParser2
{
    internal class SNTParser : AbstractSiteParser
    {
        private List<List<string>> _base;
        private string _table_class = "tablepress tablepress-id-27";

        public SNTParser(Site s, string url, double? dc = null) : base(s, url, dc)
        {
            _base = new List<List<string>>();
            _DownloadBase();
        }

        public override async Task<ResponceModel[]?> ParseAsync(string request)
        {
            var suitable = new List<List<string>>();
            suitable = _base.FindAll(x => (x[1] == request || x[0].Contains(request)) && x[4] != "ОЖИДАЕТСЯ");

            var responces = suitable.Select(s => new ResponceModel(request)
            {
                Name = s[0],
                Article = s[1],
                Manufacturer = s[2],
                Balance = s[3],
                Cost = s[4],
            }).ToArray();

            return responces;
        }

        private async void _DownloadBase()
        {
            _base = ParseTableToList(await GetHtmlAsync(), _table_class);
            
            for (int i = 0; i < _base.Count; i++)
            {
                _base[i].RemoveAll(x => x == null || x == "");
                if (i < _base.Count && _base[i].Count == 0)
                    _base.RemoveAt(i);
            }
        }
    }
}
