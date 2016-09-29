using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rito_Take_2.Services;
using Rito_Take_2.ViewModels.Champs;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Rito_Take_2.API
{
    [Route("api/[controller]")]
    public class ChampsController : Controller
    {
        private ChampService _champService;

        public ChampsController(ChampService champsSevice)
        {
            _champService = champsSevice;
        }
        // GET: api/values
        [HttpGet]
        public async Task<string> Get()
        {

            var content =  await this._champService.GetChampsBasic();
            return content;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var content = await this._champService.GetChampDetailed(id);
            return content;
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
