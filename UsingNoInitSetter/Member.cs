﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingNoInitSetter
{
    public class Member
    {
        public Member(int memberId)
        {
            Id = memberId;
        }
        public int Id { get;}
        public string? Name { get; set; }
        public string? Address { get; set; }

   
    }
}
