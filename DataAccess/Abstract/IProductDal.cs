﻿using Core.DataAccess;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
       List<ProductDetailDto> GetProductDetails();
    }
}

//code refoctoring
