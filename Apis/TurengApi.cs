using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace language_cli.Apis
{
    public static class TurengApi
    {
        public static async Task GetHtmlFromTureng(string[] words)
        {
            try
            {
                string wholeWord = Helper.BuildWord(words);
                string url = Helper.BuildUrl(wholeWord);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.CookieContainer = new CookieContainer();
                request.Headers.Add("User-Agent:null");

                using (HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(
                        webResponse.GetResponseStream(),
                        encoding: Encoding.UTF8))
                    {
                        Helper.ParseWordListHtml(streamReader.ReadToEnd());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not connect Tureng.com. Sorry dude :(");
            }
            
        }

    }
}
