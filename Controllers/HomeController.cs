using AppLeitorNfe.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppLeitorNfe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClasseUpload classeUpload)
        {
            try
            {
                if (classeUpload.Arquivo.ContentLength > 0)
                {
                    var nomeArquivo = Path.GetFileName(classeUpload.Arquivo.FileName);
                    var caminhoArquivo = Path.Combine(Server.MapPath("~/Content/ArquivoXml"), nomeArquivo);
                    classeUpload.Arquivo.SaveAs(caminhoArquivo);
                }

                ViewBag.Message = "Arquivo enviado com sucesso";

            }
            catch (Exception e)
            {
                ViewBag.Message = "Erro " + e.Message;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       

    }
}