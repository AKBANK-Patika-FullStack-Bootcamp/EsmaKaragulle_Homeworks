
using Airliness.Dal.Abstract;
using Airliness.Models;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities;
using Core.Utilities.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaneOperationsController : ControllerBase
    {
        IPlaneDal _planeDal;
        Result _result=new Result();

        public PlaneOperationsController(IPlaneDal planeDal)
        {
            _planeDal = planeDal;
          

        }

        [Authorize] // yetkisi varsa gorebilir.
        [HttpGet]
        //Plane turunden ucak listesi getirme
        
        public List<Plane> GetPlanes()
        {
            var result = _planeDal.GetAll();
            return result;
            
        }
        //Id'ye gore tek bır ucak nesnesi getirme
        [HttpGet("{id}")]
        public Plane GetPlane(int id)
        {
           
    
            var result = _planeDal.Get(p=> p.Id == id);
            return result;
        }
        //Plane turunden ucak ekleme
        [HttpPost]
        public Result Post(Plane plane)
        {
          
            var planeChechk = _planeDal.Get(p => p.Id == plane.Id);
            if (planeChechk ==null)
            {
                _planeDal.Add(plane);
                _result.Success = true;
                _result.Message = "Yeni uçak  eklendi";
            }
            else
            {
                _result.Success = false;
                _result.Message = "Eklenmeye çalışan uçak zaten var";
            }
            return _result;
        }
        //Id'ye gore ucak bilgileri guncelleme
        [HttpPut("{planeId}")]
        public Result Update(Plane plane)
        {

            var planeChechk = _planeDal.Get(p => p.Id == plane.Id);
            if (planeChechk != null)
            {
                _planeDal.Update(plane);
                _result.Success = true;
                _result.Message = "Uçak bilgileri güncellendi";
            }
            else
            {
                _result.Success = false;
                _result.Message = "Girilen bilgilere ait uçak bulunamadı";
            }
            return _result;
        }

        //Id'ye gore ucak silme
        [HttpDelete("{Id}")]
        public Result Delete(Plane plane)
        {
            var planeChechk = _planeDal.Get(p => p.Id == plane.Id);
            if (planeChechk != null)
            {
                _planeDal.Delete(plane);
                _result.Success = true;
                _result.Message = "Uçak silindi.";
                //logger.createLog(Id.ToString() + "Id'li" + _result.Message);
            }
            else
            {
                _result.Success = false;
                _result.Message = "Uçak zaten silinmiş";
            }
            return _result;
        }
    
    }
}
