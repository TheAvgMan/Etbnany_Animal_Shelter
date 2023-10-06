﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EtbnanyWebsite.Models
{
    public class Enquiry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string message { get; set; }

        public User User { get; set; }
    }
}