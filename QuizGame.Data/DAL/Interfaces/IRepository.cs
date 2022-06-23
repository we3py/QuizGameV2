namespace QuizGame.Data.DAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetFirstOrDefault(Func<T, bool> condition);
        void Update(T entity);
        void Save();
    }
}
