﻿using Application.Services.Ads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AdController : ApiController
    {

        private IAdService adService;

        public AdController(IAdService adService)
        {
            this.adService = adService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {

            IEnumerable<Application.Services.Ads.AdDto> adsToReturn = this.adService.GetAllAdsAndApplyDiscount(50);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            //simulate change postal code for test. TO-DO: Create test with TDD :)
            Application.Services.Ads.AdDto adToReturn = this.adService.ChangePostalCode(id.ToString(), "08150");
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
