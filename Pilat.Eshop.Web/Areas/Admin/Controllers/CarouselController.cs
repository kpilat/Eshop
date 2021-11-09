﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.Entity;
using Pilat.Eshop.Web.Models.Implementation;

namespace Pilat.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarouselController : Controller
    {
        readonly EshopDbContext eshopDbContext;
        IWebHostEnvironment env;
        public CarouselController(EshopDbContext eshopDB, IWebHostEnvironment env)
        {
            eshopDbContext = eshopDB;
            this.env = env;
        }
        public IActionResult Select()
        {
            IList<CarouselItem> carouselItems = eshopDbContext.CarouselItems.ToList();
            return View(carouselItems);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CarouselItem carouselItem)
        {
            if (carouselItem != null && carouselItem.ImageSource != null)
            {
                /*FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/CarouselItems", "image");
                carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);*/
                if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false)
                {
                    /*if(eshopDbContext.CarouselItems!=null && eshopDbContext.CarouselItems.Count > 0)
                    {
                        carouselItem.ID = eshopDbContext.CarouselItems.Last().ID + 1;
                    }*/
                    eshopDbContext.CarouselItems.Add(carouselItem);
                    await eshopDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(CarouselController.Select));
                }
            }
            /*
            else
            {
            }*/
            return View(carouselItem);
        }
        public IActionResult Edit(int ID)
        {
            CarouselItem cifromDb = eshopDbContext.CarouselItems.FirstOrDefault(ci => ci.ID == ID);
            if (cifromDb != null)
            {
                return View(cifromDb);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(CarouselItem carouselItem)
        {
            CarouselItem cifromDb = eshopDbContext.CarouselItems.FirstOrDefault(ci => ci.ID == carouselItem.ID);
            if (cifromDb != null)
            {
                /*
                if (carouselItem != null && carouselItem.Image != null)
                {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/CarouselItems", "image");
                    carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);

                    if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false)
                    {
                        cifromDb.ImageSource = carouselItem.ImageSource;
                    }
                }  */

                if (carouselItem != null && carouselItem.ImageSource != null)
                {
                    cifromDb.ImageSource = carouselItem.ImageSource;
                }

                    cifromDb.ImageAlt = carouselItem.ImageAlt;
                await eshopDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(CarouselController.Select));
            }
            else
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> Delete(int ID)
        {
            DbSet<CarouselItem> carouselItems = eshopDbContext.CarouselItems;
            CarouselItem ci = carouselItems.Where(CarouselItem => CarouselItem.ID == ID).FirstOrDefault();
            if (ci != null)
            {
                carouselItems.Remove(ci);
                await eshopDbContext.SaveChangesAsync();
            }
            //return View();
            return RedirectToAction(nameof(CarouselController.Select));
        }
    }
}
