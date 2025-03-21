﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{

    //Abstract class yapmamızın sebebi başka bir yerden newleme yapılmaması için. 
    // Abstract classlarımız projlerimizde kullanma sebebimiz ortak olan propertylerimiz ve metotlarımızı kullandığımız yerlerdir.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
