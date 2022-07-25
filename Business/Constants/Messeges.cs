using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messeges
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime= "The system is in maintenance.";
        public static string ProductListed="The Products are listed.";
        public static string ProductCountOfCategoryError = "There are already 10 products in this category.";
        public static string ProductNameAlreadyExist = "There is a product with the same name!";
        public static string CheckCategoryLimitExceded = "New product cannot be added because the category limit has been exceeded.";
    }
}
