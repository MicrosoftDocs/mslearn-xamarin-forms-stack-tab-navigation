using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Astronomy
{
    public class SunriseService
    {
        const string SunriseSunsetServiceUrl = "https://api.sunrise-sunset.org";

        public async Task<(DateTime Sunrise, DateTime Sunset)> GetSunriseSunsetTimes(double latitude, double longitude)
        {
            var query = $"{SunriseSunsetServiceUrl}/json?lat={latitude}&lng={longitude}&date=today";

            var json = await new HttpClient().GetStringAsync(query);

            var data = JsonConvert.DeserializeObject<SunriseSunsetData>(json);

            return (data.Results.Sunrise, data.Results.Sunset);
        }

        class SunriseSunsetData
        {
            #pragma warning disable 0649
            // Field is only set via JSON deserialization, so disable warning that the field is never set.
            public SunriseSunsetResults Results;
            #pragma warning restore 0649
        }

        class SunriseSunsetResults
        {
            #pragma warning disable 0649
            // Fields are only set via JSON deserialization, so disable warning that the fields are never set.
            public DateTime Sunrise;
            public DateTime Sunset;
            #pragma warning restore 0649
        }
    }
}