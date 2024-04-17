using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Services;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.UnitTests.Mocks;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class QuizServiceTests : UnitTestsBase
    {
        private IQuizService quizService;
        private IAuthorService authorService;

        [SetUp]
        public void SetUp()
        {
            quizService = new QuizService(context, new AuthorService(context));

            context = DatabaseMock.Instance;
            SeedDatabase();
        }

        [Test]
        public async Task AllQuestionTypesNamesAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.AllQuestionTypesNamesAsync();
            var data = await context.AllReadOnlyAsync<QuestionType>();

            Assert.That(result.Count(), Is.EqualTo(data.Count()));

            var typesNames = data.Select(t => t.Name);
            Assert.That(typesNames.Contains(result.FirstOrDefault()));
        }

        [Test]
        public async Task GetQuestionTypesAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.GetQuestionTypesAsync();
            var data = await context.AllReadOnlyAsync<QuestionType>();

            Assert.That(result.Count(), Is.EqualTo(data.Count()));
        }

        [Test]
        public async Task QuestionExistsAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.QuestionExistsAsync(Quiz.Question);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistsAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.ExistsAsync(Quiz.Id);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsAuthorOfQuizAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.IsAuthorOfQuizAsync(Author.UserId, Quiz.Id);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task FillModelAsync_ShouldReturnCorrectData()
        {
            var result = await quizService.FillModelAsync(Quiz.Id);

            Assert.Multiple(() =>
            {
                Assert.That(result!.Question, Is.EqualTo(Quiz.Question));
                Assert.That(result.Answer, Is.EqualTo(Quiz.Answer));
            });
        }

        [Test]
        public async Task CreateQuizAsync_ShouldReturnCorrectData()
        {
            var dbQuizzesBefore = (await context.AllReadOnlyAsync<Quiz>()).Count();

            var newQuiz = new Quiz
            {
                Question = "new question",
                Answer = "new answer"
            };

            await quizService.CreateQuizAsync(new AddQuizModel
            {
                Question = newQuiz.Question,
                Answer = newQuiz.Answer
            });

            var dbQuizzesAfter = (await context.AllReadOnlyAsync<Quiz>()).Count();
            dbQuizzesBefore++;
            Assert.That(dbQuizzesBefore, Is.EqualTo(dbQuizzesAfter));
        }

        [Test]
        public async Task EditAsync_ShouldReturnCorrectData()
        {
            await quizService.EditAsync(new AddQuizModel
            {
                AuthorId = Quiz.AuthorId,
                Question = "edited question",
                Answer = "edited answer",
                QuestionTypeId = Quiz.QuestionTypeId
            }, Quiz.Id);

            var quiz = (await context.AllReadOnlyAsync<Quiz>())
                .First();

            Assert.Multiple(() =>
            {
                Assert.That(quiz.Question, Is.EqualTo("edited question"));
                Assert.That(quiz.Answer, Is.EqualTo("edited answer"));
            });
        }

        [Test]
        public async Task DeleteQuizAsync_ShouldReturnCorrectData()
        {
            var expectedAuthorId = Quiz.AuthorId;
            var actualAuthorId = await quizService.DeleteQuizAsync(Quiz.Id);

            Assert.That(expectedAuthorId, Is.EqualTo(actualAuthorId));
        }
    }
}