using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCommunication
{

    public class MyEventArgs : EventArgs
    {
        public String data { get; set; }
    }
    class DownloadAverage
    {

        public delegate void AverageDwnlEventhandler(object source, MyEventArgs args);
        public event AverageDwnlEventhandler AverageDownloaded;

        public async Task<string> doIT()
        {


            WebClient client = new WebClient();
            MemoryStream ms = new MemoryStream(client.DownloadData("https://degalu-kainos.lt/lietuvoje"));




            HtmlDocument doc23 = new HtmlDocument();
            doc23.Load(ms); //, Encoding.UTF8

            String tekstas = "";

           // HtmlNode lol = doc23.DocumentNode.SelectSingleNode("table[@class='fuelprices']//tr");
           // if (lol != null) tekstas = lol.InnerText;

            var tds = doc23.DocumentNode.Descendants("td");
            foreach (HtmlNode a in tds)
            {
                tekstas += a.InnerText + '\n';
            }
            OnAverageDownloaded(tekstas);
            return tekstas;

        }

        protected virtual void OnAverageDownloaded(String tekstas)
        {

            if (AverageDownloaded != null)
                AverageDownloaded(this, new MyEventArgs { data = tekstas });
        }
    }
}
