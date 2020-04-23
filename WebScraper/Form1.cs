using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraper
{
    public partial class FrmMain : Form
    {
        public IWebDriver driver;

        public List<CompanyStock> Companies;

        private String url;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            url = "https://www.marketwatch.com/tools/screener";
            Companies = new List<CompanyStock>();
        }

        public void OpenBrowser()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            driver = new ChromeDriver(driverService);
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch
            {
                throw;
            }
        }

        private void GetData()
        {
            IList<IWebElement> serchElements = driver.FindElements(By.TagName("tbody"));
            foreach (IWebElement e in serchElements)
            {
                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                var text = e.GetAttribute("innerHTML");

                htmlDoc.LoadHtml(text);
                var inputs = htmlDoc.DocumentNode.Descendants("tr").ToList();
                foreach (var items in inputs)
                {
                    HtmlAgilityPack.HtmlDocument htmlDoc1 = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc1.LoadHtml(items.InnerHtml);
                    var tds = htmlDoc1.DocumentNode.Descendants("td").ToList();
                    if (tds.Count != 0)
                    {
                        CompanyStock someStock;
                        Companies.Add(someStock = new CompanyStock(tds[0].InnerText, tds[1].InnerText, tds[2].InnerText,
                            tds[3].InnerText, tds[4].InnerText, tds[5].InnerText, tds[6].InnerText));
                    }
                }
            }

            foreach (CompanyStock cs in Companies)
            {
                lbxSymbols.Items.Add(cs.Symbol);
            }
        }

        private void btnOpenBrow_Click(object sender, EventArgs e)
        {
            OpenBrowser();
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            GetData();
            driver.Quit();
        }

        private void lbxSymbols_SelectedValueChanged(object sender, EventArgs e)
        {
            CompanyStock selectedStock;
            foreach (CompanyStock cs in Companies)
            {
                if (cs.Symbol == lbxSymbols.SelectedItem.ToString())
                {
                    selectedStock = cs;
                    lblSym.Text = selectedStock.Symbol;
                    lblCompany.Text = selectedStock.Company;
                    lblLast.Text = selectedStock.Last;
                    lblChange.Text = selectedStock.Change;
                    lblPerChange.Text = selectedStock.PercentChange;
                    lblVolume.Text = selectedStock.Volume;
                    lblTraded.Text = selectedStock.Traded;
                }
            }
        }
    }
}
