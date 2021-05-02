using CourseCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourseCatalog.Controllers
{
    public class BrandsController : ApiController
    {

        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId="B001",Name="Haro"},

            new Brand(){BrandId="B002",Name="Electra"},

            new Brand(){BrandId="B003",Name="Heller"},

            new Brand(){BrandId="B004",Name="Trek"},
        };
        [HttpGet]
        public IEnumerable<Brand> DisplayBrand()
        {
            return brands;

        }
        [HttpPost]
        public HttpResponseMessage AddBrand([FromUri] Brand brand)
        {
            var addBrand = brands.Where(p => p.BrandId == brand.BrandId).FirstOrDefault();
            brands.Add(brand);
            return Request.CreateResponse(HttpStatusCode.Created, addBrand);
        }

    }
}
