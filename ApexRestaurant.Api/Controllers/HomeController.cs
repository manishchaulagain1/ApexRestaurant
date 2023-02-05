using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApexRestaurant.Api.Controller
{
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index() {
            
            var base_uri = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

            var endpoints = new List<string>{"customer", "meal", "mealdish", "menu", "menuitem", "staff", "staffrole"};

            var api_is_working = @"";

            var api_text = "";
            foreach (var endpoint in endpoints)
            {
                api_text += Environment.NewLine + $"{base_uri}/api/{endpoint}";
            }

            return Ok(api_is_working + api_text);
        }
    }
}