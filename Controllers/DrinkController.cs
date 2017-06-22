using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Controllers
{
    [Route("api/drink")]
    public class DrinkController : Controller
    {
        // List<Drink> myDrinks = new List<Drink>();
        // void makeDrinks(){
        //     //construct the menu
        //     var Lemonade = new Drink("Lemonade", 1.96f, false, 200);
        //     var IceT = new Drink("Ice-T", 2.94f, false, 230);
        //     var AmySpecial = new Drink("AmySpecial", 10.99f, true, 600);
        //     myDrinks.Add(Lemonade);
        //     myDrinks.Add(IceT);
        //     myDrinks.Add(AmySpecial);
        // }



        [HttpGet]
        public void Get()
        {
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public void Get(int id)
        {
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
