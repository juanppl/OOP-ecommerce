﻿using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Users
{
    public class SuperAdminUser : User
    {
        public SuperAdminUser(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive) : 
            base(firstName, lastName, email, password, userName, bio, isActive)
        {
        }
    }
}
