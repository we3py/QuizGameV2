using Microsoft.EntityFrameworkCore;
using QuizGame.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Data
{
    public class QuizGameContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Highscore> Highscores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=QuizGame;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasKey(q => q.QuestionId);
            modelBuilder.Entity<Highscore>().HasKey(q => q.HighscoreId);
        }
    }
}
