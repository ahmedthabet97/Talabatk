﻿using E_Commerce_Back_End.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection;

namespace E_Commerce_Back_End.Services
{
    public class UserAddressServices : Iaddress
    {
        private readonly LibraryContext db;
        public UserAddressServices(LibraryContext _db)
        {
            db = _db;

        }
        public void AddAddress(UserAddressCreateModel address)
        {
            UserAddress userAddress = new UserAddress()
            {
                address_line1 = address.Address_line1,
                address_line2 = address.Address_line2,
                country = address.Country,
                city = address.City,
                postal_code = address.Postal_Code,
                telephone = address.Telephone,
                mobile = address.Mobile,
                IsDeleted = false,
                user_id= "2eaf560a-d376-4456-b127-22403304bb01"
            };
            db.UserAddress.Add(userAddress);
            db.SaveChanges();
        }

    }
}
