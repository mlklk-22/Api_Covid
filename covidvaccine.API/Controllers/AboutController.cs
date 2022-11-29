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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutSerice)
        {
            _aboutService = aboutSerice;
        }
        
        [HttpPost]
        public void CreateAbout(About about)
        {
            _aboutService.CreateAbout(about);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteAbout(int id)
        {
            _aboutService.DeleteAbout(id);
        }
        [HttpGet]
        public List<About> GetAllAbout()
        {
            return _aboutService.GetAllAbout();
        }
        [HttpPut]
        public void UpdateAbout(About about)
        {
            _aboutService.UpdateAbout(about);
        }
        [HttpPost]
        [Route("UploadImage/imageTitle1")]
        public About UploadImageTitle1()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            About about = new About();
            about.Imagetitle1= fileName;
            return about;
        }

        [HttpPost]
        [Route("UploadImage/protectImage")]
        public About UploadProtectImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            About about = new About();
            about.Protectimage = fileName;
            return about;
        }

        [HttpPost]
        [Route("UploadImage/whatImage")]
        public About UploadWhatImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Covid-vaccine\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            About about = new About();
            about.Whatimage = fileName;
            return about;
        }

    }
}
