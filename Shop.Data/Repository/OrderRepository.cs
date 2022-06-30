﻿using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrderRepository: RepositoryBase<Order>
    {
        public OrderRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}