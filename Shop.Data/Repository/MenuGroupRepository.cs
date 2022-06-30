﻿using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class MenuGroupRepository: RepositoryBase<MenuGroup>
    {
        public MenuGroupRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
