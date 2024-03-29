﻿using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Quiz;

namespace QuizGame.Controllers
{
    public class QuizController : BaseController
    {
        private readonly IQuizService quizService;

        public QuizController(IQuizService _quizService)
        {
            quizService = _quizService;
        }

        public async Task<IActionResult> All()
        {
            var res = await quizService.AllAsync();

            if (res == null)
            {
                return BadRequest();
            }

            return View(res);
        }

        [HttpGet]
        public IActionResult Add()
            => View();

        [HttpPost]
        public async Task<IActionResult> Add(AddQuizModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await quizService.CreateQuizAsync(model);

            return RedirectToAction(nameof(All));
        }
    }
}