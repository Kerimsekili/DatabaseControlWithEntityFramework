using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
         IProductDal _productDal;

         public ProductManager(IProductDal productDal)
         {
             _productDal = productDal;
         }

         public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 19)
            //{
            //    return new ErrorDataResult<List<Product>>(Messeges.MaintenanceTime);
            //}
            //Business Codes
            //is he access?
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messeges.ProductListed);
            
        }

         public IDataResult<List<Product>> GetAllByCategoryId(int id)
         {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
         }

         public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
         {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
         }

         public IDataResult<List<ProductDetailDto>> GetProductDetails()
         {
             return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
         }

         public IDataResult<Product> GetById(int productId)
         {
             return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
         }


        [ValidationAspect(typeof(ProductValidator))]
         public IResult Add(Product product)
         {
             _productDal.Add(product);
             return new SuccessResult(Messeges.ProductAdded);
         }
    }
}
