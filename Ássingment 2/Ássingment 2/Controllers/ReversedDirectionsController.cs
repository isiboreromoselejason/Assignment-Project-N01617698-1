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
    
        /// <summary>
        /// Retrieves a reversed navigation instruction based on the specified direction and place.
        /// </summary>
        /// <param name="direction">The original direction, either 'R' for right or 'L' for left.</param>
        /// <param name="place">The destination or location to turn into.</param>
        /// <returns>
        /// Returns a string message instructing to turn into the specified place in the reversed direction.
        /// If the provided direction is invalid, an error message is returned.
        /// </returns>

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
