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
        public static string AuthorizationDenied = "Authorization Denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound= "User not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Login is Successfull";
        public static string UserAlreadyExists = "User already Exist";
        public static string AccessTokenCreated = "Access token created";
    }
}
