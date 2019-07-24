using DevExpress.Utils.Extensions;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace WindowsFormsApp2
{

    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {


        Series[] CoinsInfos = new Series[3];



        public FluentDesignForm1()
        {
            InitializeComponent();
            agility_parse ap = new agility_parse();
            List<string> companyList = new List<string>();
            companyList = ap.agility_funtion("https://www.bithumb.com/trade/order/BTC");
            AddFavorite(accordionControlElement1, companyList);

        }

        private void AddFavorite(DevExpress.XtraBars.Navigation.AccordionControlElement target, List<string> companyNames)
        {
            foreach (var companyName in companyNames)
            {
                var ace = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                ace.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                ace.Text = companyName;
                ace.Click += new EventHandler(AccordionControlElements_Click);

                target.Elements.Add(ace);
            }
        }

        private void AccordionControlElements_Click(object sender, EventArgs e)
        {

            var tile = (DevExpress.XtraBars.Navigation.AccordionControlElement)sender;
            var name = tile.Text;
            var split_str = name.Split('/');
            var companyName = split_str[0].Trim();
            string url = "https://www.bithumb.com/trade/order/" + companyName;

            agility_parse ap = new agility_parse();
            label1.Text = ap.GetCompanyDetails(url);
            while (true)
            {
                getAPIData(companyName);
                
            }
            

        }

        private static DateTime Delay(int ms)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void getAPIData(string company)
        {
            string sAPI_Key = "11864a21338bd3a1d5568caf1d8bdb00";
            string sAPI_Secret = "0826";

            string sParams = "order_currency="
                + company +
                "&payment_currency=KRW";
            string sRespBodyData = String.Empty;
            XCoinAPI hAPI_Svr;
            JObject JObj = null;


            hAPI_Svr = new XCoinAPI(sAPI_Key, sAPI_Secret);

            //
            // public api
            //
            // /public/ticker
            // /public/recent_ticker
            // /public/orderbook
            // /public/recent_transactions

            Console.WriteLine("Bithumb Public API URI('/public/ticker/') Request...");
            JObj = hAPI_Svr.xcoinApiCall("/public/ticker/" + company, sParams, ref sRespBodyData);
            if (JObj == null)
            {
                Console.WriteLine("Error occurred!");
                Console.WriteLine("HTTP Response JSON Data: {0}", sRespBodyData);
            }
            else
            {
                Console.WriteLine(JObj.ToString());

                if (String.Compare(JObj["status"].ToString(), "0000", true) == 0)
                {
                    label_opening_price.Text = JObj["data"]["opening_price"].ToString();
                    label_closing_price.Text = JObj["data"]["closing_price"].ToString();
                    label_min_price.Text = JObj["data"]["min_price"].ToString();
                    label_max_price.Text = JObj["data"]["max_price"].ToString();
                    label_average_price.Text = JObj["data"]["average_price"].ToString();
                    label_units_traded.Text = JObj["data"]["units_traded"].ToString();
                    label_volume_1day.Text = JObj["data"]["volume_1day"].ToString();
                    label_volume_7day.Text = JObj["data"]["volume_7day"].ToString();
                    label_buy_price.Text = JObj["data"]["buy_price"].ToString();
                    label_sell_price.Text = JObj["data"]["sell_price"].ToString();
                    label_24H_fluctate.Text = JObj["data"]["24H_fluctate"].ToString();
                    label_24H_fluctate_rate.Text = JObj["data"]["24H_fluctate_rate"].ToString();
                    label_timestamp.Text = JObj["data"]["date"].ToString();
                    /* Console.WriteLine("- Status Code: {0}", JObj["status"].ToString());
                     Console.WriteLine("- Opening Price: {0}", JObj["data"]["opening_price"].ToString());
                     Console.WriteLine("- Closing Price: {0}", JObj["data"]["closing_price"].ToString());
                     Console.WriteLine("- Sell Price: {0}", JObj["data"]["sell_price"].ToString());
                     Console.WriteLine("- Buy Price: {0}", JObj["data"]["buy_price"].ToString());*/
                }
            }

            Console.Write("\n\n");
        }
                  //ShowBitcoinChart(JObj["data"]["average_price"].ToString(), Double.Parse(JObj["data"]["average_price"].ToString()));
                  // CoinsInfos[0].Points.Add(new SeriesPoint(JObj["data"]["average_price"].ToString()));

        private void ShowBitcoinChart(string infoName, double infoValue)
        { 

            CoinsInfos[0] = new Series(infoName, ViewType.Line);
            chartControl1.Series.Add(CoinsInfos[0]);
            CoinsInfos[1] = new Series(infoName, ViewType.Line);
            chartControl1.Series.Add(CoinsInfos[1]);
            CoinsInfos[2] = new Series(infoName, ViewType.Line);
            chartControl1.Series.Add(CoinsInfos[2]);

            chartControl1.CrosshairEnabled = DefaultBoolean.False;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisY.WholeRange.MaxValue = infoValue + (infoValue / 2);
            diagram.AxisY.WholeRange.MinValue = infoValue - (infoValue / 2);
            diagram.AxisY.WholeRange.Auto = false;
            diagram.AxisX.WholeRange.SideMarginsValue = 0;

            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CoinsInfos[0].Points.Count >10)
            {
                CoinsInfos[0].Points.RemoveAt(0);
                CoinsInfos[1].Points.RemoveAt(0);
                CoinsInfos[2].Points.RemoveAt(0);
            }
            //todo: 값 넣기
            CoinsInfos[0].Points.Add(new SeriesPoint(double.Parse(label_buy_price.Text)));
            CoinsInfos[1].Points.Add(new SeriesPoint());
            CoinsInfos[2].Points.Add(new SeriesPoint());
        }
    }





    class agility_parse
    {
        public Encoding utf = Encoding.GetEncoding("utf-8");
        public WebClient web = new WebClient();

        List<string> companyList = new List<string>();
        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        public void getHtml(string strUri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:51.0) Gecko/20100101 Firefox/51.0";
            request.UseDefaultCredentials = true;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string html;

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                html = reader.ReadToEnd();
            }
            document.LoadHtml(html);
        }
        public List<string> agility_funtion(string strUri)
        {
            try
            {
                getHtml(strUri);

                //HtmlNode rtKeywordNodes = document.DocumentNode.SelectSingleNode("//ol[contains(@class, 'coin_list')]");
                //FirstOrDefault().Descendants("strong").Where(x => x.Attributes["class"].Value.Contains("tb_coin_name"));


                // MessageBox.Show(rtKeywordNodes.InnerText);

                var companyNodes = document.DocumentNode.SelectNodes("//ol[contains(@class, 'coin_list')]").FirstOrDefault().Descendants("a").Where(x => x.Attributes["data-sorting"] != null);
                foreach (var cmpnodes in companyNodes)
                    companyList.Add(cmpnodes.InnerText);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }

            return companyList;
        }

        public string GetCompanyDetails(string strUri)
        {
            string companyDetails = "";
            try
            {
                getHtml(strUri);
                var companyNode = document.DocumentNode.SelectSingleNode("//strong[contains(@class, 'title')]");

                companyDetails = companyNode.InnerText;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }

            return companyDetails;
        }
    }

}
