﻿using MVPPractice.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPractice.Models
{

    public interface IProductRepository 
    {
        Product GetProduct();

    }


}
