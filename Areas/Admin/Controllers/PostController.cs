using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MvcCmsRider.Models;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace MvcCmsRider.Areas.Admin.Controllers;

    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            
        }
        
        [HttpPost]
        [Route("edit/{id}")]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
        }
    }
