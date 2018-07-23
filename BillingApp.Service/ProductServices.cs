using BillingApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingApp.Model;
using BillingApp.Data.UnitOfWork;
using AutoMapper;
using BillingApp.Data;

namespace BillingApp.Service
{
    public class ProductServices : IProductServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor
        /// </summary>
        public ProductServices( UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<ProductModel> GetAllProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll().ToList();
            if(products.Any())
            {
                List<ProductModel> productList = Mapper.Map<List<Product>,List<ProductModel>>(products);
                return productList;
            }
            return null;
        }
    }
}
