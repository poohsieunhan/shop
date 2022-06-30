﻿using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository: RepositoryBase<Footer>
    {
        public FooterRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
