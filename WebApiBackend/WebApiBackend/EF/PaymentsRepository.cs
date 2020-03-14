﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBackend.Model;

namespace WebApiBackend.EF
{
    public class PaymentsRepository : EfRepository<Payment,DbContext>
    {
        public PaymentsRepository (DbContext context) : base(context)
        {

        }
        
    }
}

