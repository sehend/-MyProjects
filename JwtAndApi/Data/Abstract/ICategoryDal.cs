﻿using Core.Model;
using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
    }
}
