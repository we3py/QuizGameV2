namespace QuizGame.Data.Import
{
    public class LoadQuestion
    {
        private readonly RepositoryHandler _dataManage;

        public LoadQuestion()
        {
            _dataManage = new RepositoryHandler();
        }

        public void Load(List<Question> questions)
        {
            foreach (Question question in questions)
            {
                _dataManage.AddQuestion(question);
            }
        }


    }
}
