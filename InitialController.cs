using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkParser2
{
    public enum Site
    {
        SNT=1,
        UDT,
        T2K,
        REN,
        REC,
        AKP
    }


    internal class InitialController
    {
        private ParseController parseController;
        private Form1 form1;

        public InitialController(Form1 form)
        {
            parseController = new();
            form1 = form;
        }

        public void Start(List<Site> search_sites, List<string> searching_requests)
        {
            BindingList<ResponceModel> totalResponce = new();
            foreach (var request in searching_requests)
            {
                var res = parseController.Parse(search_sites, request);
                res.ForEach(x => totalResponce.Add(x));
                foreach(var r in res)
                {
                    //form1.textBox1.AppendText(r.Name+"\r\n");
                    form1.textBox1.Invoke(new Action(() => form1.textBox1.AppendText(r.Name + "\r\n")));
                }
            }
            form1.dataGridView1.Invoke(new Action(() => { form1.dataGridView1.DataSource = totalResponce; }));
        }
    }
}
