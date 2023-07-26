using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://weather-api99.p.rapidapi.com/weather?city=District%20of%20Columbia%20"),
    Headers =
    {
        { "X-RapidAPI-Key", "1234910bc5mshb02f16ee596c21bp14aec2jsn374dc053af6e" },
        { "X-RapidAPI-Host", "weather-api99.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
