﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhysicianAvailabilityStatus
    {
        public Guid AvailabilityId { get; set; }

        public Guid? DoctorId { get; set; }

        public bool? Sunday { get; set; }

        public bool? Monday { get; set; }

        public bool? Tuesday { get; set; }

        public bool? Wednesday { get; set; }

        public bool? Thursday { get; set; }

        public bool? Friday { get; set; }

        public bool? Saturday { get; set; }
    }
}
