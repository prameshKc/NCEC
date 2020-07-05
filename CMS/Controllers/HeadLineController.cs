using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL;
using Dapper;
using BLL.Abstract;
using DomainModel;
using System.Text.Json;

namespace CMS.Controllers
{
    public class HeadLineController : Controller
    {
        private readonly IHeadline _repo;
        public HeadLineController(IHeadline _repo)
        {
            this._repo= _repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetHeadLines(string title)
        {
            dynamic list = 0;
            try{
                title = string.IsNullOrEmpty(title) ? "" : title;
                DynamicParameters para = new DynamicParameters();
                para.Add("@HeadLine", title);
                list = _repo.GetListAsync("sp_HeadLines_GetbyHeadLine", CommandType.StoredProcedure, para);
                list = JsonSerializer.Serialize(list);
            }
            catch(Exception ex){
                list = ex.Message;
            }
            return Json(list);
        } 
    }
}