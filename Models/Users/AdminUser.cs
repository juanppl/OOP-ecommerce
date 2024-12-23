﻿using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Interfaces;

namespace OOP_ecommerce.Models.Users
{
    public class AdminUser : User, IPermissions
    {
        public List<string> Permissions { get; set; }
        public List<int> AssignedDepartments { get; set; }
        public AdminUser(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive, List<string> permissions, List<int> assignedDepartments) :
            base(firstName, lastName, email, password, userName, bio, isActive)
        {
            Permissions = permissions;
            AssignedDepartments = assignedDepartments;
        }
        public override string ToString()
        {
            return $"Admin User: {FirstName} {LastName} with email {Email}";
        }

        public void AddPermission(string permission)
        {
            if (!Permissions.Contains(permission))
            {
                Permissions.Add(permission);
                Console.WriteLine($"Permission '{permission}' added.");
            }
            else
            {
                Console.WriteLine($"Permission '{permission}' already exists.");
            }
        }

        public void AddPermission(List<string> permissions)
        {
            foreach (var permission in permissions)
            {
                if (!Permissions.Contains(permission))
                {
                    Permissions.Add(permission);
                    Console.WriteLine($"Permission '{permission}' added.");
                }
            }
        }
    }
}
