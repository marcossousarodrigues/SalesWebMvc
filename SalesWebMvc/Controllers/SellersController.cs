﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerServices _sellerServices;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerServices sellerServices, DepartmentService departmentService)
        {
            _sellerServices = sellerServices;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();
            return View(list);

        }

        public IActionResult Create() { 
            
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller) {

            //if (!ModelState.IsValid)
            //{
            //    var departments = _departmentService.FindAll();
            //    var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
            //    //return View(viewModel);
            //}

            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));


        }
        public IActionResult Delete(int? id) {
            if (id == null) { 
                return RedirectToAction(nameof(Error), new {message = "Id not provided"});
            
            }

            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });

            }

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id) {

            try
            {
                _sellerServices.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
           
        }


        public IActionResult Details(int? id) {

            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });

            }

            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);

        }


        public IActionResult Edit(int? id)    
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _sellerServices.FindById(id.Value);

            if (obj == null) {
                
                return RedirectToAction(nameof(Error), new { message = "Id not found" });

            }

            List<Department> departments = _departmentService.FindAll();

            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };


            return View(viewModel); 
        
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            //if (!ModelState.IsValid)
            //{
            //    var departments = _departmentService.FindAll();
            //    var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
            //    return View(viewModel);
            //}

            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try 
            {
                _sellerServices.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch(ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }

        }

        public IActionResult Error(string message) 
        {
                var viewModel = new ErrorViewModel 
                {
                    
                    Message = message, 
                    
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
                };

                return View(viewModel);
        }
    }
}
