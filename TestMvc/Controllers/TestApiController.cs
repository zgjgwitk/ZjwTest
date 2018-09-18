using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestMvc.Controllers
{
    public class TestApiController : ApiController
    {
        public string Get()
        {
            var latest = new DateTime(1900, 1, 1);
            DateTime.TryParse("2018-09-18 06:00:00", out latest);
            var checkIn = new DateTime(1900, 1, 1);
            DateTime.TryParse("2018-09-17", out checkIn);
            var latestTime = latest - checkIn;
            var show = (latestTime.Days * 24 + latestTime.Hours) * 100 + latestTime.Minutes;

            return show.ToString();
        }
    }
}
