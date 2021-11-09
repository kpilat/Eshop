﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Pilat.Eshop.Web.Models.Entity
{
    [Table(nameof(CarouselItem))]
    public class CarouselItem
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageSource { get; set; }

        [StringLength(50)]
        public string ImageAlt { get; set; }
    }
}