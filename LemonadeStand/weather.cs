using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {

        public Weather() { }

        public async Task GetWeatherAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-by-api-ninjas.p.rapidapi.com/v1/weather?lon=-77.037936%20%2F%20W%2077%C2%B0%202'%2016.57''&zip=20009&city=Washington%20DC&state=DC&country=United%20States"),
                Headers =
                {
                    { "X-RapidAPI-Key", "1234910bc5mshb02f16ee596c21bp14aec2jsn374dc053af6e" },
                    { "X-RapidAPI-Host", "weather-by-api-ninjas.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

        }
    }
}
