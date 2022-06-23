using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using Moq;

namespace QuizGame.Test
{
    [TestFixture]
    public class RepositoryHandlerTests
    {
        [Test]
        public void CreateRepository_savesABlogViaContext()
        {
            // Arrange
            var mockSet = new Mock<DbSet<Question>>();
            var mockContext = new Mock<QuizGameContext>();

            mockContext.Setup(s => s.Set<Question>()).Returns(mockSet.Object);
            var questionRepository = new RepositoryHandler(mockContext.Object);

            // Act
            questionRepository.AddQuestion(new Question()
            {
                Query = "Question1",
                AnswerA = "A1",
                AnswerB = "A2",
                AnswerC = "A3",
                AnswerD = "A4",
                CorrectAnswer = "A"
            });

            Question question = questionRepository.GetExistingQuestions()[0];
            Assert.That(question, Is.Not.Null);
        }
    }
}
