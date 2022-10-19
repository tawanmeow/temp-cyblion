using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEALMobile.Views
{
    public interface IBaseUrl { string Get(); }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        
        public DashboardPage()
        {
            InitializeComponent();
            WebView browser = new WebView();
            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
                                <head>
                                <link rel=""stylesheet"" href=""default.css"">
                                </head>
                                <body>
                                <!--<p><a href=""https://freeboard.io/board/6333e3e4b35a78a174000006"">Pub freeboard</a></p>-->

                                <p><a href=""index.html"">Pub freeboard</a></p>
                                </body>
                                </html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            string url = DependencyService.Get<IBaseUrl>().Get();
            string TempUrl = Path.Combine(url, "index.html");
            htmlSource.BaseUrl = TempUrl;
            browser.Source = htmlSource;
            browser.HeightRequest = 300;
            browser.EvaluateJavaScriptAsync("document.body.innerHTML");
            Content = browser;*/

            var urlSource = new UrlWebViewSource();

            string baseUrl = DependencyService.Get<IBaseUrl>().Get();
            string filePathUrl = Path.Combine(baseUrl, "index.html");
            urlSource.Url = filePathUrl;
            browser.Source = urlSource;
            Content = browser;


            /*htmlSource.Url = TempUrl;
            browser.Source = htmlSource;*/
        }

        

            





        

    }
}
