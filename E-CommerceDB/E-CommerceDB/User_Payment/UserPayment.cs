﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class UserPayment
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public string paymenr_type { get; set; }
        public string provider { get; set; }
        public int account_no { get; set; }
        public DateTime expire_date { get; set; }
        public User user { get; set; }


    }
}
