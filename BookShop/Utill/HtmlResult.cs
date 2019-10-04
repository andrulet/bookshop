using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Utill
{
    public class HtmlResult : ActionResult
    {
        private string htmlresult;
        public HtmlResult(string html)
        {
            htmlresult = html;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html><head>";
            fullHtmlCode += "<title>Главная страница</title>";
            fullHtmlCode += "<meta charset=\"utf-8\" />";
            fullHtmlCode += "</head> <body>";
            fullHtmlCode += htmlresult;
            fullHtmlCode += "</body></html>";
            context.HttpContext.Response.Write(fullHtmlCode);
        }
    }
}