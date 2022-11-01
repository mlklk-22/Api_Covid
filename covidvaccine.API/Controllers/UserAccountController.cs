﻿using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountService _userAccountService;
        public UserAccountController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }
        [HttpPost]
        public void CreateUser(Useraccount useraccount)
        {
            _userAccountService.CreateUser(useraccount);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteUser(int id)
        {
            _userAccountService.DeleteUser(id);
        }
        [HttpGet]
        [Route("firstvaccine")]
        public List<Useraccount> firstvaccine()
        {
            return _userAccountService.firstvaccine();
        }
        [HttpGet]
        public List<Useraccount> GetAllUsers()
        {
            return _userAccountService.GetAllUsers();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Useraccount GetUserById(int id)
        {
            return _userAccountService.GetUserById(id);
        }
        [HttpGet]
        [Route("NotTokeVaccine")]
        public List<Useraccount> NotTokeVaccine()
        {
            return _userAccountService.NotTokeVaccine();
        }
        [HttpGet]
        [Route("Secondvaccine")]
        public List<Useraccount> Secondvaccine()
        {
            return _userAccountService.Secondvaccine();
        }
        [HttpPut]
        public void UpdateUser(Useraccount useraccount)
        {
            _userAccountService.UpdateUser(useraccount);
        }


        [HttpGet]
        [Route("uploadImage")]

        public Useraccount UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Useraccount item = new Useraccount();
            item.Image= fileName;
            return item;
        }
    }
}