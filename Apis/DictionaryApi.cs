using language_cli.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace language_cli.Apis
{
    public static class DictionaryApi
    {

        public static async Task GetWordInfoAsync(HttpClient client, string[] words)
        {
            string wholeWord = Helper.BuildWord(words, Consts.ApiType.DICTIONARY_API);
            string url = Helper.BuildUrl(wholeWord, Consts.ApiType.DICTIONARY_API);

            var response = client.GetStreamAsync(url);
            var dictionaryModel = await JsonSerializer.DeserializeAsync<List<DictionaryModel>>(await response);
            if (dictionaryModel is null || dictionaryModel[0] is null)
            {
                NotFindInApi();
            }
            ExtractDictionaryData(dictionaryModel[0]);

        }

        private static void ExtractDictionaryData(DictionaryModel dictionaryModel)
        {
            Meaning[] meanings = dictionaryModel.meanings;
            foreach (var meaning in meanings)
            {
                ChangeConsoleColorBeforeAndAfterMessage(meaning.partOfSpeech.ToUpper());
                WriteDefinitions(meaning);
                WriteSynonyms(meaning);
            }
        }

        private static void WriteDefinitions(Meaning meaning)
        {
            if (meaning.definitions is not null && meaning.definitions.Length > 0)
            {
                ChangeConsoleColorBeforeAndAfterMessage("Definitions;");
                foreach (var definition in meaning.definitions)
                {
                    Console.WriteLine(definition.definition);
                    if (!string.IsNullOrEmpty(definition.example))
                    {
                        Console.WriteLine("Example: " + definition.example);
                    }
                }
            }
        }

        private static void WriteSynonyms(Meaning meaning)
        {
            if (meaning.synonyms is not null && meaning.synonyms.Length > 0)
            {
                ChangeConsoleColorBeforeAndAfterMessage("Synonyms; ");
                Console.WriteLine(new StringBuilder().AppendJoin(", ", meaning.synonyms).ToString());
            }
        }

        private static void ChangeConsoleColorBeforeAndAfterMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void NotFindInApi()
        {
            Console.WriteLine("I couldnt find the word in the API");
            Environment.Exit(0);
        }
    }
}
