using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string URL = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(URL);

                // File.WriteAllText("currency.json", json);

                var result = JsonConvert.DeserializeObject<List<Currency>>(json);
                Print(result);

                var testJson = JsonConvert.SerializeObject(result, Formatting.Indented);
                File.WriteAllText("currencyTest.json", testJson);
            }

        }

        private static void Print(List<Currency> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public class Currency
        {
            public string ccy { get; set; }
            public string base_ccy { get; set; }
            public string buy { get; set; }
            public string sale { get; set; }

            public override string ToString()
            {
                return $"{ccy}  --- > {base_ccy}\n{buy}----{sale}";
            }
        }
    }
}
