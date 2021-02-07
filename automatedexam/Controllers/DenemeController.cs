using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using automatedexam.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using automatedexam.Crawler;
using Microsoft.EntityFrameworkCore;

namespace automatedexam.Controllers
{
    public class DenemeController : Controller
    {
        private AppDbContext _appDbContext = new AppDbContext();
        const string crawlUri = @"https://www.wired.com";
        public IActionResult Index()
        {
            
            var result = WiredCrawler.crawl(crawlUri);
            //string a = result.articleLink1.GetAttributeValue("href",string.Empty);
            //ViewBag.link = a;
            //ViewBag.tester = "tester";
            //Debug.WriteLine(result.articleLink1.InnerText);
            //Debug.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            ViewBag.links = result.Item1;
            ViewBag.articles = result.Item2;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Exam model)
        {
            _appDbContext.Exams.Add(model);
            _appDbContext.SaveChanges();
            return View("Test1",model);
        }
        public IActionResult tested()
        {
            return View();
        }
        [HttpPost]
        public IActionResult tested(Example model)
        {
            
            _appDbContext.Add(model);
            _appDbContext.SaveChanges();
            var isim = _appDbContext.Examples.FirstOrDefault();
            return View("Index",isim);
        }
        [HttpGet]
        public async Task<IActionResult> ExamList()
        {
            var savedExams = await _appDbContext.Exams.ToListAsync();

            return View("ExamList",savedExams);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var examFromDb = await _appDbContext.Exams.FirstOrDefaultAsync(u => u.Id == Id);
            if(examFromDb == null)
            {
                return View("ExamList");
            }
            _appDbContext.Exams.Remove(examFromDb);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("ExamList");
        }
        public async Task<IActionResult> StartExam(int Id)
        {
            var exam = await _appDbContext.Exams.FirstOrDefaultAsync(e => e.Id == Id);
            return View(exam);
        }
        [HttpPost]
        public JsonResult GetCorrectAnswers(int ExamId)
        {
            var exam = _appDbContext.Exams.FirstOrDefault(e => e.Id == ExamId);
            string[] answerList = { exam.question1CorrectAnswer, exam.question2CorrectAnswer, exam.question3CorrectAnswer, exam.question4CorrectAnswer };
            return Json(answerList);
        }
        
    }
}
