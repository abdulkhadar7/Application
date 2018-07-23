using BillingApp.Service;
using BillingApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BillingApp.Web.Controllers
{
    [Authorize]
    [RoutePrefix("api/Product")]
    public class ProductController : BaseApiController
    {
        private readonly IProductServices _productService;
        public ProductController(IProductServices productServices)
        {
            _productService = productServices;
        }
        [HttpGet]
        [Route("GetProducts")]
        public HttpResponseMessage GetProducts(HttpRequestMessage request)
        {
            var products = _productService.GetAllProducts();
            if(products!=null)
            {
                return request.CreateResponse(HttpStatusCode.OK, products.ToList());
            }
            else
            {
                return request.CreateErrorResponse(HttpStatusCode.NotFound, "No products Found");
            }
        }
    }
}
