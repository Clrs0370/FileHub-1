using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileHub.Models;

namespace FileHub.Controllers
{
    public class FileController : Controller
    {
        //
        // GET: /File/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Music()
        {
            string path = "/HubFile/Music";
            var files = FileHelper.GetFileList(path);
            ViewBag.Files = files;
            return View();
        }

        public ActionResult Video()
        {
            string path = "/HubFile/Video";
            var files = FileHelper.GetFileList(path);
            ViewBag.Files = files;
            return View();
        }

        public ActionResult Pictrue()
        {
            string path = "/HubFile/Pictrue";
            var files = FileHelper.GetFileList(path);
            ViewBag.Files = files;
            return View();
        }

        public ActionResult VideoPlay(MyFile model)
        {
            return View(model);
        }

    }
}
