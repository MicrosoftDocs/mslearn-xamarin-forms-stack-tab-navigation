using System.Threading.Tasks;

namespace Astronomy
{
    public class FakeLatLongService : ILatLongService
    {
        static (double, double) RedmondCampusCoordinates = (47.641944, -122.127222);
        public async Task<(double Latitude, double Longitude)> GetLatLong()
        {
            await Task.Delay(millisecondsDelay: 250);
            return RedmondCampusCoordinates;
        }
    }
}