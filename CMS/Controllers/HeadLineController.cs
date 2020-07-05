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

namespace CMS.Controllers
{
    public class HeadLineController : Controller
    {
        private readonly IHeadline _repo;
        public HeadLineController(IHeadline _repo)
        {
            this._repo = _repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetHeadLines(string title)
        {
            title = string.IsNullOrEmpty(title) ? "" : title;
            DynamicParameters para = new DynamicParameters();
            para.Add("@HeadLine", title);
            Task<IEnumerable<DomainModel.Headline>> list = _repo.GetListAsync("sp_HeadLines_GetbyHeadLine", CommandType.StoredProcedure, para);
            List<DomainModel.Headline> pl = list.Result.ToList();
            return Json(pl);
        }

        public JsonResult GetHeadlinesById(int Id)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@Id", Id);
            Task<DomainModel.Headline> list = _repo.GetFirstAsync("sp_HeadLines_GetbyId", CommandType.StoredProcedure, para);
            DomainModel.Headline pl = list.Result;
            return Json(pl);
        }

        public JsonResult HeadLine_Delete(int Id)
        {
            dynamic pl = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", Id);
                _repo.DeleteAsync("sp_HeadLines_Delete", CommandType.StoredProcedure, para);
                pl = "Deleted";
            }
            catch (Exception ex)
            {
                pl = ex.Message;
            }
            return Json(pl);
        }
        public JsonResult HeadLine_AddUpdate(DomainModel.Headline mod)
        {
            dynamic msg = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", mod.Id);
                para.Add("@HeadLine", mod.HeadLine);
                para.Add("@Description", mod.Description);
                _repo.AddAsync("sp_HeadLines_AddUpdate", CommandType.StoredProcedure, para);
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Json(msg);
        }
    }
}