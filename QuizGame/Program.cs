namespace QuizGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var repositoryHandler = new RepositoryHandler();
            var quizManager = new QuizManager(repositoryHandler, 10);
            Application.Run(new MainProgram(repositoryHandler, quizManager));
        }
    }
}