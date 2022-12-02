using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    public class GenericController<T> : ControllerBase

    {

        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }



        // GET: api/values
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody][FromQuery] T value)
        {
            _genericService.Create(value);
        }

        [HttpPut]
        public void put([FromBody][FromQuery] T value)
        {
            _genericService.Update(value);
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _genericService.Delete(id);
        }


        [HttpGet]
        [Route("search/{name}")]
        public List<T> Search(String name)
        {
            return _genericService.Search(name);
        }


   


    }
}
