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
    public class VentureController : Controller
    {
        private readonly IVentures _repo;
        public VentureController(IVentures _repo)
        {
            this._repo = _repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Master()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public JsonResult GetVentureTitle(string title)
        {
            title = string.IsNullOrEmpty(title) ? "" : title;
            DynamicParameters para = new DynamicParameters();
            para.Add("@VenturesTitle", title);
            Task<IEnumerable<DomainModel.Ventures>> list = _repo.GetListAsync("sp_VenturesMaster_GetByVenturesTitle", CommandType.StoredProcedure, para);
            List<DomainModel.Ventures> pl = list.Result.ToList();
            return Json(pl);
        }

        public JsonResult VenturesTitle_AddUpdate(DomainModel.Ventures mod)
        {
            dynamic msg = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@VenturesMasterId", mod.VenturesMasterId);
                para.Add("@VenturesTitle", mod.VenturesTitle);
                _repo.AddAsync("sp_VenturesMaster_AddUpdate", CommandType.StoredProcedure, para);
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Json(msg);
        }

        public JsonResult GetVentureTitleById(int Id)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@VenturesMasterId", Id);
            Task<DomainModel.Ventures> list = _repo.GetFirstAsync("sp_VenturesMaster_GetByVenturesMasterId", CommandType.StoredProcedure, para);
            DomainModel.Ventures pl = list.Result;
            return Json(pl);
        }

        public JsonResult VentureTitle_Delete(int Id)
        {
            dynamic pl = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@VenturesMasterId", Id);
                Task<int> list = _repo.DeleteAsyncReturn("sp_VenturesMaster_Delete", CommandType.StoredProcedure, para);
                if (list.Result == 0)
                {
                    pl = "Could not Delete. Used";
                }
                else
                {
                    pl = "Deleted";
                }
            }
            catch (Exception ex)
            {
                pl = ex.Message;
            }
            return Json(pl);
        }

    }
}