﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primeira_Aplicacao_Vidly.Models
{
    public class MembershipType 
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }

    }
}