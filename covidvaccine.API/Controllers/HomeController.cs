using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpPost]
        public void CreateHome(Home home)
        {
            _homeService.CreateHome(home);
        }
        [HttpDelete]
        [Route("{id}")]
        public void DeleteHome(int id)
        {
            _homeService.DeleteHome(id);
        }
        [HttpGet]
        public List<Home> GetAllHome()
        {
            return _homeService.GetAllHome();
        }
        [HttpPut]
        public void UpdateHome(Home home)
        {
            _homeService.UpdateHome(home);
        }
        [HttpPost]
        [Route("UploadImage/logo")]
        public Home UploadLogo()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Home home = new Home();
            home.Imagelogo = fileName;
            return home;
        }
        [HttpPost]
        [Route("UploadImage/imageTitle1")]
        public Home UploadImageTitle1()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Home home = new Home();
            home.Imagetitle1 = fileName;
            return home;
        }

        [HttpPost]
        [Route("UploadImage/newsImage1")]
        public Home UploadNewsImage1()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Home home = new Home();
            home.Newsimage1 = fileName;
            return home;
        }

        [HttpPost]
        [Route("UploadImage/newsImage2")]
        public Home UploadNewsImage2()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Home home = new Home();
            home.Newsimage2 = fileName;
            return home;
        }

        [HttpPost]
        [Route("UploadImage/newsImage3")]
        public Home UploadNewsImage3()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Home home = new Home();
            home.Newsimage3 = fileName;
            return home;
        }
    }
}
