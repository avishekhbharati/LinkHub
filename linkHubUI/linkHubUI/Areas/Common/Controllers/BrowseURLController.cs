using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace linkHubUI.Areas.Common.Controllers
{
    public class BrowseURLController : Controller
    {
        private UrlBs ObjBs = null;
        public BrowseURLController()
        {
            ObjBs = new UrlBs();
        }

        // GET: Common/BrowseURL
        public ActionResult Index(String SortOrder, String SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            var model = ObjBs.GetAll().Where(x=>x.IsApproved == "A");
            switch(SortBy)
            {
                case "Title":
                    switch(SortOrder)
                    {
                        case "Asc":
                            model = model.OrderBy(x => x.UrlTitle);
                            break;
                        case "Desc":
                            model = model.OrderByDescending(x => x.UrlTitle);
                            break;
                        default:
                            break;
                    }
                    break;

                case "Category":
                    switch (SortOrder)
                    {
                        case "Asc":
                            model = model.OrderBy(x => x.tbl_Category.CategoryName);
                            break;
                        case "Desc":
                            model = model.OrderByDescending(x => x.tbl_Category.CategoryName);
                            break;
                        default:
                            break;
                    }
                    break;

                case "URL":
                    switch (SortOrder)
                    {
                        case "Asc":
                            model = model.OrderBy(x => x.Url);
                            break;
                        case "Desc":
                            model = model.OrderByDescending(x => x.Url);
                            break;
                        default:
                            break;
                    }
                    break;

                case "Desc":
                    switch (SortOrder)
                    {
                        case "Asc":
                            model = model.OrderBy(x => x.UrlDesc);
                            break;
                        case "Desc":
                            model = model.OrderByDescending(x => x.UrlDesc);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            ViewBag.TotalPages = Convert.ToInt32(Math.Ceiling(ObjBs.GetAll().Where(x => x.IsApproved == "A").Count() / 10.0));
            int page = int.Parse(Page ?? "1");
            ViewBag.CurrentPage = page;

            model = model.Skip((page - 1)*10).Take(10);
            return View(model);
        }
    }
}