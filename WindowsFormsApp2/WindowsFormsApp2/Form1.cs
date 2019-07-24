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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            agility_parse ap = new agility_parse();
            List<string> companyList = new List<string>();
            string str = "";
            str = ap.GetCompanyDetails("https://www.bithumb.com/trade/order/BTC");
            // listBox1.DataSource = str;
            str = str.Replace("\n", "/");
            var split_str = str.Split('/');
            label1.Text = split_str[2].Trim();
        }
    }
    
}
