using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Data.Entities
{
    public class Highscore
    {
        public int HighscoreId { get; set; }
        public string? UserName { get; set; }
        public int Score { get; set; }
    }
}
