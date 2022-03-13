﻿using GeekShopping.ProductAPI.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")]
    public class Product: BaseEntity
    {
        [Column("Name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        
        [Column("Price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("Description")]
        [Required]
        [StringLength(350)]
        public string Description { get; set; }

        [Column("Category_Name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("ImageUrl")]
        [StringLength(300)]
        public string ImageUrl { get; set; }




    }
}
