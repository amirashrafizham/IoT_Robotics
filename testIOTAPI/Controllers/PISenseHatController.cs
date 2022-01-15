using Iot.Device.Common;
using Iot.Device.SenseHat;
using Microsoft.AspNetCore.Mvc;
using testIOTAPI.Models;

namespace testIOTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PISenseHatController : ControllerBase
    {
        [HttpGet("getweather")]
        public ActionResult<Weather> GetWeather()
        {
            var sh = new SenseHat();
            Weather weather = new Weather();
            using (sh)
            {
                try
                {
                    weather.Temperature1 = Math.Round(sh.Temperature.DegreesCelsius, 2);
                    weather.Temperature2 = Math.Round(sh.Temperature2.DegreesCelsius, 2);
                    weather.Humidity = Math.Round(sh.Humidity.Percent, 2);
                    weather.Pressure = Math.Round(sh.Pressure.Bars, 2);
                    return Ok(weather);
                }
                catch (System.Exception)
                {

                    return NotFound("try again");
                }
            }
        }

        [HttpGet("getacceleration")]
        public ActionResult<Acceleration> GetAcceleration()
        {
            var sh = new SenseHat();
            Acceleration acceleration = new Acceleration();
            using (sh)
            {
                try
                {
                    acceleration.X = sh.Acceleration.X;
                    acceleration.Y = sh.Acceleration.Y;
                    acceleration.Z = sh.Acceleration.Z;

                    return Ok(acceleration);
                }
                catch (System.Exception)
                {

                    return NotFound("try again");
                }
            }
        }

        [HttpGet("getangularrate")]
        public ActionResult<AngularRate> GetAngularRate()
        {
            var sh = new SenseHat();
            AngularRate angularRate = new AngularRate();
            using (sh)
            {
                try
                {
                    angularRate.X = sh.AngularRate.X;
                    angularRate.Y = sh.AngularRate.Y;
                    angularRate.Z = sh.AngularRate.Z;

                    return Ok(angularRate);
                }
                catch (System.Exception)
                {

                    return NotFound("try again");
                }
            }
        }

        [HttpGet("getmagneticinduction")]
        public ActionResult<MagneticInduction> GetMagneticInduction()
        {
            var sh = new SenseHat();
            MagneticInduction magneticInduction = new MagneticInduction();
            using (sh)
            {
                try
                {
                    magneticInduction.X = sh.AngularRate.X;
                    magneticInduction.Y = sh.AngularRate.Y;
                    magneticInduction.Z = sh.AngularRate.Z;

                    return Ok(magneticInduction);
                }
                catch (System.Exception)
                {

                    return NotFound("try again");
                }
            }
        }





    }
}