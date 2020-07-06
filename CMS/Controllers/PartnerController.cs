using System.Net.Http.Headers;
using System.Net.Http;
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
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace CMS.Controllers
{
    public class PartnerController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly IPartner _repo;
        public PartnerController(IPartner _repo, IWebHostEnvironment env)
        {
            this.env = env;
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

        public JsonResult GetPartnerTitle(string title)
        {
            title = string.IsNullOrEmpty(title) ? "" : title;
            DynamicParameters para = new DynamicParameters();
            para.Add("@PartnerTitle", title);
            Task<IEnumerable<DomainModel.Partners>> list = _repo.GetListAsync("sp_PartnerMaster_GetbyPartnerTitle", CommandType.StoredProcedure, para);
            List<DomainModel.Partners> pl = list.Result.ToList();
            return Json(pl);
        }

        public JsonResult PartnerTitle_AddUpdate(DomainModel.Partners mod)
        {
            dynamic msg = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@PartnerMasterId", mod.PartnerMasterId);
                para.Add("@PartnerTitle", mod.PartnerTitle);
                _repo.AddAsync("sp_PartnerMaster_AddUpdate", CommandType.StoredProcedure, para);
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Json(msg);
        }

        public JsonResult GetPartnerTitleById(int Id)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@PartnerMasterId", Id);
            Task<DomainModel.Partners> list = _repo.GetFirstAsync("sp_PartnerMaster_GetbyPartnerMasterId", CommandType.StoredProcedure, para);
            DomainModel.Partners pl = list.Result;
            return Json(pl);
        }

        public JsonResult PartnerTitle_Delete(int Id)
        {
            dynamic pl = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@PartnerMasterId", Id);
                Task<int> list = _repo.DeleteAsyncReturn("sp_PartnerMaster_Delete", CommandType.StoredProcedure, para);
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

        [HttpPost]
        public JsonResult PartnerDetails_AddUpdate(DomainModel.Partners mod, IFormFile file)
        {
            dynamic msg = string.Empty;
            try
            {
                var filePath = string.Empty;
                if (file != null)
                {
                    var root = Path.Combine(env.WebRootPath, "Images", "Partners");
                    if (!Directory.Exists(root))
                    {
                        Directory.CreateDirectory(root);
                    }

                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileNameWithoutExtension(file.FileName) + "" + Path.GetExtension(file.FileName);

                    filePath = Path.Combine(root, fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }
                    filePath = "https://" + HttpContext.Request.Host.Value + "/Images/Partners/" + fileName;
                }
                else
                {
                    filePath = "";
                }
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", mod.Id);
                para.Add("@PartnerMasterId", mod.PartnerMasterId);
                para.Add("@Name", mod.Name);
                para.Add("@ImagePath", filePath);
                para.Add("@Description", mod.Description);
                _repo.AddAsync("sp_Partners_AddUpdate", CommandType.StoredProcedure, para);
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Json(msg);
        }
        public JsonResult GetPartnerName(string title)
        {
            title = string.IsNullOrEmpty(title) ? "" : title;
            DynamicParameters para = new DynamicParameters();
            para.Add("@Name", title);
            Task<IEnumerable<DomainModel.Partners>> list = _repo.GetListAsync("sp_Partners_GetByPartnerName", CommandType.StoredProcedure, para);
            List<DomainModel.Partners> pl = list.Result.ToList();
            return Json(pl);
        }

        public JsonResult GetPartnerDetailsById(int Id, int pmid)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@Id", Id);
            para.Add("@PartnerMasterId", pmid);
            Task<DomainModel.Partners> list = _repo.GetFirstAsync("sp_Partners_GetByIdPartnerMasterId", CommandType.StoredProcedure, para);
            DomainModel.Partners pl = list.Result;
            return Json(pl);
        }

        public JsonResult PartnerDetails_Delete(int Id)
        {
            dynamic pl = string.Empty;
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@Id", Id);
                _repo.DeleteAsync("sp_Partners_Delete", CommandType.StoredProcedure, para);
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