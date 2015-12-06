using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index2()
        {
            return View();
        }


        public JsonResult Update()
        {
            var oFile = Request.Files["txt_file"];

            var oStream = oFile.InputStream;
            //得到了文件的流对象，我们不管是用NPOI、GDI还是直接保存文件都不是问题了吧。。。。

            //后台TODO
            

            


            return Json(new { }, JsonRequestBehavior.AllowGet); 
        }
    }
}