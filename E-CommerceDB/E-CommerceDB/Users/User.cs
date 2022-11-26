﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class User:IdentityUser
    {
        
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime modified_at { get; set; }
        public String Role { get; set; }
        public String ProfilieImage { get; set; } = "https://www.w3schools.com/w3images/avatar3.png";
        public bool IsDeleted { get; set; } = false;

        //public virtual ICollection<UserAddress> user_address { get; set; }

        // public virtual ICollection<UserPayment> user_payment { get; set; }

        //public virtual ICollection<Order_Details> order_Details { get; set; }

        // public virtual ShoppingSession ShoppingSession { get; set; }

        //public virtual ICollection<UserAddress> UserAddress { get; set; }

        //public virtual ICollection<UserPayment> UserPayment { get; set; }

        //public virtual Order_Details Order_Details { get; set; }

        ///////////////////////////////////////////////

        //public virtual ICollection<Complaints> ComplaintsSeller { get; set; }

        //public virtual ICollection<Complaints> ComplaintsBuyer { get; set; }

    }
}