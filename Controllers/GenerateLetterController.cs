using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCS_Royal_Assignment_Web.Business_Layer;

namespace TCS_Royal_Assignment_Web.Controllers
{
    public class GenerateLetterController : Controller
    {
        // GET: GenerateLetter
        /// <summary>
        /// Controller to generate the letter
        /// </summary>
        /// 

        //Action method to generate the letter and display the count
        public ActionResult GenerateRenewalLetter()
        {
           
            LetterGenerator letter = new LetterGenerator();
            int filecount = letter.GenerateRenewalFiles();
            if (filecount > 0)
            {
                ViewBag.message = "No of Letter generated : " + filecount;
            }
            else if (filecount == 0)
            {
                ViewBag.message = "No new Letter generated."; 
            }
            else
            {
                ViewBag.message = "Letter generation failed. Kindly check the logs";
            }
         
            return View();
        }

        //Default action which is used for displaying the button
        //we can add other functionality on view like delete the letters or get the generated letters
        public ActionResult Index()
        {
            return View();
        }
    }
}