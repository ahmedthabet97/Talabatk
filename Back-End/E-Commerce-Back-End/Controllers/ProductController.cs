﻿using E_Commerce_Admin_Dashboard_MVC;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
        [HttpGet]
        public string Index()
        {
            return "Hello";
        }
        [HttpGet]
        [Route("~/api/GetProducts")]
        public IActionResult GetProducts()
        {
            if (productServices.GetAllProducts()!=null)
            {
                var products = productServices.GetAllProducts();
                return Ok(products);
            }
           
            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            var res = productServices.GetProductById(id);
            if (res!= null)
            {
                return Ok(res);
            }
            
            return NotFound();
        }

        [HttpGet]
        [Route("~/api/GetProductByCatAndPrice/{subCat_id}&{start}&{end}")]
        public IActionResult ShowProductByPriceRange(int subCat_id ,int start,int end)
        {
            var res = productServices.GetProductBySubCatPriceRange(subCat_id,start, end);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("~/api/ShowProductBySubCat/{id}")]
        public IActionResult ShowProductBySubCat(int id)
        {
            var res = productServices.GetProductBySubcategory(id);
            if (res != null)
            {
                return Ok(res);
            }

            return NotFound();
        }



    }
}
