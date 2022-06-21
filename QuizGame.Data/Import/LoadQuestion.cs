namespace QuizGame.Data.Import
{
    public class LoadQuestion
    {
        private readonly DataManage _dataManage;

        public LoadQuestion()
        {
            _dataManage = new DataManage();
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
