using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Ássingment_2.Controllers
{
        /// <summary>
        /// Calculates and returns the total calorie count based on the selected items from different menu categories.
        /// </summary>
        /// <param name="burger">Index representing the chosen burger option.</param>
        /// <param name="drink">Index representing the chosen drink option.</param>
        /// <param name="side">Index representing the chosen side option.</param>
        /// <param name="dessert">Index representing the chosen dessert option.</param>
        /// <returns>
        /// Returns an integer representing the total calorie count of the selected menu items.
        /// </returns>
    
    public class CalCountController : ApiController {
        public int[] BurgerCalories = { 461, 431, 420, 0 };
        public int[] DrinkCalories = { 130, 160, 118, 0 };
        public int[] SideCalories = { 100, 57, 70, 0 };
        public int[] DessertCalories = { 167, 266, 75, 0 };

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int GetMenu(int burger, int drink, int side, int dessert)
        {

            int totalCalories = BurgerCalories[burger - 1] + DrinkCalories[drink - 1] + SideCalories[side - 1] + DessertCalories[dessert - 1];

            return totalCalories;
        }
    }

}
