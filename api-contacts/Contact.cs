﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_contacts {
    public class Contact {
        public long id { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String address { get; set; }
        public String phone { get; set; }
        public Boolean favorite { get; set; }
    }
} 
