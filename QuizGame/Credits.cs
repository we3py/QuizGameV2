namespace QuizGame.GUI
{
    public partial class Credits : Form
    {
        readonly SoundPlayer player;
        public Credits()
        {
            InitializeComponent();
            player = new SoundPlayer("credits_music.wav");
            player.Play();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}
