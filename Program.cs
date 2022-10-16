using McMaster.Extensions.CommandLineUtils;
using System.ComponentModel.DataAnnotations;
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

        private async Task<int> OnExecuteAsync()
        {
            Helper.Welcome();
            _ = TurengApi.GetHtmlFromTureng(Words);
            return 1;
        }

        public static Task<int> Main(string[] args) => CommandLineApplication.ExecuteAsync<Program>(args);


    }
}
