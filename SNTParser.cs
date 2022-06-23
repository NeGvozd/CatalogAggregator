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
        public override Site site { get; } = Site.SNT;
        protected override string request_url { get; } = "https://snt-k.ru/catalog/";
        private List<List<string>> _base;
        private string _table_class = "tablepress tablepress-id-27";

        public SNTParser()
        {
            site = Site.SNT;
            _base = new List<List<string>>();
            _DownloadBase();
        }

        public override ResponceModels[] Parse(string request)
        {
            var suitable = new List<List<string>>();
            suitable = _base.FindAll(x => (x[1] == request || x[0].Contains(request)) && x[4] != "ОЖИДАЕТСЯ");

            var responces = new SNTResponce[suitable.Count];
            for (int i=0; i < suitable.Count; i++)
            {
                responces[i] = new SNTResponce(request)
                {
                    Name = suitable[i][0],
                    Article = suitable[i][1],
                    Manufacturer = suitable[i][2],
                    Balance = suitable[i][3],
                    Cost = suitable[i][4]
                };
            }

            return responces;
        }

        private void _DownloadBase()
        {
            _base = ParseTableToList(GetHtml(), _table_class);

            for (int i = 0; i < _base.Count; i++)
            {
                _base[i].RemoveAll(x => x == null || x == "");
                if (i < _base.Count && _base[i].Count == 0)
                    _base.RemoveAt(i);
            }
        }
    }
}
