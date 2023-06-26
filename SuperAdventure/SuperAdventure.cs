using Engine;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(100, 100, 100, 0, 1);

            lblHitPoints.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            Location location = new Location(1, "Home", "Home Base", null, null, null);
        }
    }
}
