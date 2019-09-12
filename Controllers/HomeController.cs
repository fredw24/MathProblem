using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathProblem.Models;
using Microsoft.AspNetCore.Http;

namespace MathProblem.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            TempData["score"] = score;
            TempData["wrong"] = wrong;

            
            return View();
        }

        [Route("add")]
        [HttpGet]
        public IActionResult Addition(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(10);
            int prob2Set = rand.Next(10);
            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }

        [Route("subtract")]
        [HttpGet]
        public IActionResult Subtraction(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(10);
            int prob2Set = rand.Next(10);
            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }

        [Route("Multiply")]
        [HttpGet]
        public IActionResult Multiplication(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(10);
            int prob2Set = rand.Next(10);
            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }

        [Route("Divide")]
        [HttpGet]
        public IActionResult Division(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(100);
            int prob2Set = rand.Next(1, 10);

            int remainder = prob1Set % prob2Set;

            while (remainder != 0){
            prob1Set = rand.Next(100);
            prob2Set = rand.Next(1, 10);
            remainder = prob1Set % prob2Set;
            Console.WriteLine(remainder);
            }


            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }

        [Route("Remainder")]
        [HttpGet]
        public IActionResult Remainder(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(100);
            int prob2Set = rand.Next(1, 10);

            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }

        [Route("Decimals")]
        [HttpGet]
        public IActionResult Decimal(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(100);
            int prob2Set = rand.Next(1, 100);

            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);


            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob1"] = prob1Set;
            TempData["prob2"] = prob2Set;
            
            
            return View();

        }
        

        [Route("Fraction")]
        [HttpGet]
        public IActionResult Fraction(){
            Random rand = new Random();
            int? score = HttpContext.Session.GetInt32("score");
            int? wrong = HttpContext.Session.GetInt32("wrong");
            if (score == null){
                HttpContext.Session.SetInt32("score", (int)0);
                HttpContext.Session.SetInt32("wrong", (int)0);
            }

            int prob1Set = rand.Next(10);
            int prob2Set = rand.Next(1,10);

            HttpContext.Session.SetInt32("prob1", (int)prob1Set);
            HttpContext.Session.SetInt32("prob2", (int)prob2Set);
            decimal draftProb = (decimal)prob1Set / (decimal)prob2Set;

            decimal prob = Math.Round(draftProb, 8, MidpointRounding.AwayFromZero);
            TempData["score"] = score;
            TempData["wrong"] = wrong;
            TempData["prob"] = prob;     
            return View();

        }

        [Route("Addanswers")]
        [HttpPost]
        public IActionResult AddAnswers(int answer)
        {
            int? prob1 = HttpContext.Session.GetInt32("prob1");
            int? prob2 = HttpContext.Session.GetInt32("prob2");
            
            int matchAnswer = (int) (prob1 + prob2);
            if (matchAnswer == answer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);

            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/add");

        }

        [Route("Subtractanswers")]
        [HttpPost]
        public IActionResult SubtractAnswers(int answer)
        {

            int? prob1 = HttpContext.Session.GetInt32("prob1");
            int? prob2 = HttpContext.Session.GetInt32("prob2");
            
            int matchAnswer = (int) (prob1 - prob2);
            
            if (matchAnswer == answer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);

            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/subtract");

        }

        [Route("MultiplcationAnswer")]
        [HttpPost]
        public IActionResult MultiplyAnswer(int answer)
        {

            Console.WriteLine(answer);

            int? prob1 = HttpContext.Session.GetInt32("prob1");
            int? prob2 = HttpContext.Session.GetInt32("prob2");
            
            int matchAnswer = (int) (prob1 * prob2);
            if (matchAnswer == answer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);
            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/multiply");

        }

        [Route("DivisionAnswer")]
        [HttpPost]
        public IActionResult DivideAnswer(int answer)
        {
         
            int? prob1 = HttpContext.Session.GetInt32("prob1");
            int? prob2 = HttpContext.Session.GetInt32("prob2");
            
            int matchAnswer = (int) (prob1 / prob2);
            if (matchAnswer == answer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);

            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/divide");

        }
        
        [Route("RemainderAnswer")]
        [HttpPost]
        public IActionResult RemainderAnswer(int divideAnswer, int RemainingAnswer)
        {
            Console.WriteLine(RemainingAnswer);
            Console.WriteLine(divideAnswer);
            int? prob1 = HttpContext.Session.GetInt32("prob1");
            int? prob2 = HttpContext.Session.GetInt32("prob2");
            
            decimal answerDivide = (decimal) Math.Floor((double)(prob1 / prob2));
            int answerRemain = (int) (prob1 % prob2);

            if (divideAnswer == answerDivide && answerRemain == RemainingAnswer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);
            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/Remainder");

        }

        [Route("DecimalAnswer")]
        [HttpPost]
        public IActionResult DecimalAnswers(decimal Answer)
        {
            int prob1 = (int)HttpContext.Session.GetInt32("prob1");
            int prob2 = (int)HttpContext.Session.GetInt32("prob2");

            decimal decimalAnswer =(decimal)(prob1)/ (decimal)(prob2);
            decimal realAnswer = Math.Round(decimalAnswer, 2, MidpointRounding.AwayFromZero);
            if (realAnswer == Answer)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);
            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/Decimals");

        }

        [Route("FractionAnswer")]
        [HttpPost]
        public IActionResult FractionAnswer(int numAnswer, int denaAnswer)
        {
            // give a message that 0 cannot be a deminator
            if (denaAnswer == 0){
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
                
                return Redirect("Fraction");
            }

            int prob1 = (int)HttpContext.Session.GetInt32("prob1");
            int prob2 = (int)HttpContext.Session.GetInt32("prob2");

            decimal answerDraft = (decimal)prob1 / (decimal)prob2;
            decimal answerDivide = (decimal) Math.Round(answerDraft, 8, MidpointRounding.AwayFromZero);
            
            decimal userDraft = (decimal) numAnswer/ (decimal)denaAnswer;
            decimal userAnswer = (decimal) Math.Round(userDraft, 8, MidpointRounding.AwayFromZero);
            if (userAnswer == answerDivide)
            {
                int? score = HttpContext.Session.GetInt32("score");
                score++;
                HttpContext.Session.SetInt32("score", (int)score);
            }
            else
            {
                int? wrong = HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", (int)wrong);
            }

            return Redirect("/Fraction");

        }
    }
}
