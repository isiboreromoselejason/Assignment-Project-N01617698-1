using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ássingment_2.Controllers
{
    public class ReversedDirectionsController : ApiController
    {
        [HttpGet]
        [Route("api/J3/ReverseDirections/{direction}/{place}")]
        public string ReverseDirections(string direction, string place)
        {
            // Ensure valid direction and place
            if (direction != "R" && direction != "L")
            {
                return "Invalid direction. Please use 'R' for right or 'L' for left.";
            }

            string reversedDirection;
            if (direction == "R")
            {
                reversedDirection = "Right";
            }
            else
            {
                reversedDirection = "Left";
            }
            return $"Turn {reversedDirection} into your {place}.";
        }
    }
}
