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

namespace UI.Controllers
{
    public class AboutController : Controller
    {
         private readonly IHeadline _repo;
        public AboutController(IHeadline _repo)
        {
            this._repo = _repo;
        }
        public IActionResult Index()
        {
            
            Task<IEnumerable<DomainModel.Headline>> list = _repo.GetListAsync("sp_HeadLines_GetbyHeadLine", CommandType.StoredProcedure);
            List<DomainModel.Headline> pl = list.Result.ToList();
            return View(pl);
        }
    }
}