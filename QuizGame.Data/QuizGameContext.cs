namespace QuizGame.Data
{
    public class QuizGameContext : DbContext
    {
#pragma warning disable CS8618
        public DbSet<Question> Questions { get; set; }
        public DbSet<Highscore> Highscores { get; set; }
#pragma warning restore CS8618
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Server=(localdb)\mssqllocaldb;Database=QuizGame;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasKey(q => q.QuestionId);
            modelBuilder.Entity<Highscore>().HasKey(q => q.HighscoreId);
        }
    }
}
