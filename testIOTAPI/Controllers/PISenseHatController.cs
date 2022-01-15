using Iot.Device.SenseHat;
using Microsoft.AspNetCore.Mvc;
using testIOTAPI.Models;

namespace testIOTAPI.Controllers



{
    [ApiController]
    [Route("[controller]")]
    public class PISenseHatController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Weather> GetWeather()
        {
            var sh = new SenseHat();
            Weather weather = new Weather();
            using (sh)
            {
                weather.Temperature1 = sh.Temperature.DegreesCelsius;
                weather.Temperature2 = sh.Temperature2.DegreesCelsius;
                weather.Humidity = sh.Humidity.Percent;
                weather.Pressure = sh.Pressure.Pascals;
            }
            return Ok(weather);
        }

    }
}