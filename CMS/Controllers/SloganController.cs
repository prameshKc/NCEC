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
    public class SloganController : Controller
    {
        private readonly ISlogan _repo;
        public SloganController(ISlogan _repo)
        {
            this._repo = _repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetSlogans(string title)
        {
            title = string.IsNullOrEmpty(title) ? "" : title;
            DynamicParameters para = new DynamicParameters();
            para.Add("@Slogans", title);
            Task<IEnumerable<DomainModel.Slogan>> list = _repo.GetListAsync("sp_Slogans_GetBySlogan", CommandType.StoredProcedure, para);
            List<DomainModel.Slogan> pl = list.Result.ToList();
            return Json(pl);
        }

        public JsonResult Slogan_AddUpdate(DomainModel.Slogan mod)
        {
            dynamic msg = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", mod.Id);
                para.Add("@Slogans", mod.Slogans);
                _repo.AddAsync("sp_Slogans_AddUpdate", CommandType.StoredProcedure, para);
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Json(msg);
        }
        
        public JsonResult GetSlogansById(int Id)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@Id", Id);
            Task<DomainModel.Slogan> list = _repo.GetFirstAsync("sp_Slogans_GetById", CommandType.StoredProcedure, para);
            DomainModel.Slogan pl = list.Result;
            return Json(pl);
        }

        public JsonResult Slogan_Delete(int Id)
        {
            dynamic pl = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", Id);
                _repo.DeleteAsync("sp_Slogans_Delete", CommandType.StoredProcedure, para);
                pl = "Deleted";
            }
            catch (Exception ex)
            {
                pl = ex.Message;
            }
            return Json(pl);
        }

    }
}