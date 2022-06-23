namespace QuizGame.Data.DAL
{
    public class Repository<T> : IDisposable, IRepository<T> where T : class
    {
        protected QuizGameContext _context = new();

        public void Add(T entity)
            => _context.Set<T>().Add(entity);

        public void Update(T entity)
            => _context.Set<T>().Update(entity);

        public void Delete(T entity)
            => _context.Set<T>().Remove(entity);

        public IEnumerable<T> GetAll()
            => _context.Set<T>().ToList();

        public T GetFirstOrDefault(Func<T, bool> condition)
#pragma warning disable CS8603
            => _context.Set<T>().FirstOrDefault(condition);
#pragma warning restore CS8603

        public void Save()
            => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
