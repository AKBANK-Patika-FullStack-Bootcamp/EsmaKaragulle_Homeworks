using Airliness.Dal.Abstract;
using Airliness.Models;
using Core.Utilities;
using Core.Utilities.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class BrandOperationsController : ControllerBase
    {
        IBrandDal _brandDal;
        Result _result=new Result();

        public BrandOperationsController(IBrandDal brandDal)
        {
            _brandDal = brandDal;
         

        }

        [HttpGet("BrandPaging")]
        public IActionResult GetBrandPaging([FromQuery] PagingParameters pagingParameters)
        {
            var paging = _brandDal.GetAll()

           .Skip(pagingParameters.PageNumber)
           .Take(pagingParameters.PageSize)
           .ToList();
            return Ok(paging);
        }

        [HttpGet]
        //Brand turunden brand listesi getirme
        public List<Brand> GetBrands()
        {
            var result = _brandDal.GetAll();
            return result;

        }
        //Id'ye gore tek bır brand nesnesi getirme
        [HttpGet("{id}")]
        public Brand GetBrand(int id)
        {


            var result = _brandDal.Get(p => p.Id == id);
            return result;
        }
        //Brand turunden marka ekleme
        [HttpPost]
        public Result Post(Brand brand)
        {

            var planeChechk = _brandDal.Get(p => p.Id == brand.Id);
            if (planeChechk == null)
            {
                _brandDal.Add(brand);
                _result.Success = true;
                _result.Message = "Yeni marka eklendi";
            }
            else
            {
                _result.Success = false;
                _result.Message = "Eklenmeye çalışan marka zaten var";
            }
            return _result;
        }
        //Id'ye gore marka bilgileri guncelleme
        [HttpPut("{planeId}")]
        public Result Update(Brand brand)
        {

            var planeChechk = _brandDal.Get(p => p.Id == brand.Id);
            if (planeChechk != null)
            {
                _brandDal.Update(brand);
                _result.Success = true;
                _result.Message = "Marka bilgileri güncellendi";
            }
            else
            {
                _result.Success = false;
                _result.Message = "Girilen bilgilere ait marka bulunamadı";
            }
            return _result;
        }

        //Id'ye gore ucak silme
        [HttpDelete("{Id}")]
        public Result Delete(Brand brand)
        {
            var planeChechk = _brandDal.Get(p => p.Id == brand.Id);
            if (planeChechk != null)
            {
                _brandDal.Delete(brand);
                _result.Success = true;
                _result.Message = "Marka silindi.";
                //logger.createLog(Id.ToString() + "Id'li" + _result.Message);
            }
            else
            {
                _result.Success = false;
                _result.Message = "Marka zaten silinmiş";
            }
            return _result;
        }

    }
}

