using language_cli.Apis;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace language_cli
{
    [Command(Name = "lang", Description = "Translates word between turkish and english. ")]
    [HelpOption("--h")]
    public class Program
    {
        [Argument(0, Description = "Word that you want to translate")] 
        [Required]
        public string[] Words { get; }

        [Option("-d|--d", CommandOptionType.NoValue)]
        public bool Dictionary { get; }

        public HttpClient httpClient = new HttpClient();

        private async Task<int> OnExecuteAsync()
        {
            Helper.Welcome();
            _ = TurengApi.GetHtmlFromTureng(Words);
            if (Dictionary)
            {
                 await DictionaryApi.GetWordInfoAsync(httpClient, Words);
            }
            return 1;
        }

        public static Task<int> Main(string[] args) => CommandLineApplication.ExecuteAsync<Program>(args);


    }
}
