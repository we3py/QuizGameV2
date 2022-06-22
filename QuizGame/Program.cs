using QuizGame.Data;
using QuizGame.Logic;

namespace QuizGame
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var repositoryHandler = new RepositoryHandler();
            var quizManager = new QuizManager(repositoryHandler, 10);
            Application.Run(new MainProgram(repositoryHandler, quizManager));
        }
    }
}