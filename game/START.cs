using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GAME game = new GAME();
            game.ShowDialog();           
            this.Show();
            this.Controls.Remove(game);
            game.Dispose();
        }

        private void START_Load(object sender, EventArgs e)
        {

        }

        private void bntRule_Click(object sender, EventArgs e)
        {
            this.Hide();
            RULE fRule = new RULE();
            fRule.ShowDialog();
            this.Show();
            this.Controls.Remove(fRule);
            fRule.Dispose();
        }
    }
}
