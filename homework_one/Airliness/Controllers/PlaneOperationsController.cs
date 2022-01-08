using Airliness.Core.CrossCuttingConcerns.Logging;
using Airliness.Core.Utilities.Results;
using Airliness.Models;
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
        List<Plane> planeList = new List<Plane>();
        Result _result = new Result();
        Logger logger = new Logger();

        [HttpGet]
        //Plane turunden ucak listesi getirme
        public List<Plane> GetPlanes()
        {
            planeList = AddPlane().OrderBy(p => p.Id).ToList();
            return planeList;
            
        }
        //Id'ye gore tek bır ucak nesnesi getirme
        [HttpGet("{id}")]
        public Plane GetPlane(int id)
        {
            List<Plane> planes = new List<Plane>();
            planes = AddPlane();
            Plane plane = new Plane();
            plane = planes.FirstOrDefault(plane => plane.Id == id);
            return plane;
        }
        //Plane turunden ucak ekleme
        [HttpPost]
        public Result Post(Plane plane)
        {
            planeList = AddPlane();
            bool planeChechk = planeList.Select(p => p.Id == plane.Id).FirstOrDefault();
            if (planeChechk == false)
            {
                planeList.Add(plane);
                _result.Success = true;
                _result.Message = "Yeni uçak listeye eklendi";
            }
            else
            {
                _result.Success = false;
                _result.Message = "Eklenmeye çalışan uçak listede zaten var";
            }
            return _result;
        }
        //Id'ye gore ucak bilgileri guncelleme
        [HttpPut("{planeId}")]
        public Result Update(int planeId,Plane newValue)
        {
            planeList = AddPlane();
            Plane _oldValue = planeList.Find(p => p.Id == planeId);
            if (_oldValue != null)
            {
                planeList.Add(newValue);
                planeList.Remove(_oldValue);
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
        public Result Delete(int Id)
        {
            planeList = AddPlane();
            Plane _oldValue = planeList.Find(p => p.Id == Id);
            if (_oldValue != null)
            {
                planeList.Remove(_oldValue);
                _result.Success = true;
                _result.Message = "Uçak silindi";
                //logger.createLog(Id.ToString() + "Id'li" + _result.Message);
            }
            else
            {
                _result.Success = false;
                _result.Message = "Uçak zaten silinmiş";
            }
            return _result;
        }
        //uçak varlığı için liste oluşturuldu ve varlıklar eklendi.
        public List<Plane> AddPlane()
        {
            List<Plane> planes = new List<Plane>();
            planes.Add(new Plane { Id = 1, BrandId = 1, Model = "320", Capacity = 500, FlightDate = "2021-06-15T13:45:30"});
            planes.Add(new Plane { Id = 2, BrandId = 2, Model = "707", Capacity = 700, FlightDate = "2021-06-15T15:45:30" });
            planes.Add(new Plane { Id = 1, BrandId = 3, Model = "F-28", Capacity = 900, FlightDate = "2021-06-16T18:45:30" });
            return planes;
        }
    }
}
