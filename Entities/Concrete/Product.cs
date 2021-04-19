﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }


    }
}
