using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace eecs481proj1
{
    public partial class Form1 : Form
    {
        Timer gameTimer = new Timer();
        Random rand = new Random();
        List<OvalShape> bombs = new List<OvalShape>();
        List<OvalShape> bombsToRemove = new List<OvalShape>();
        int bombSize = 10;
        int farthestHeight = 539;
        int points = 0;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 70;
            gameTimer.Tick += gameTimer_Tick;
        }

        public void Run()
        {
            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        private void UpdateGame()
        {
            if (bombs.Count == 0 || (bombs.Count == 1 && bombs[0].Location.X > this.Width / 2))
                bombs.Add(CreateBomb());

            if (Keyboard.IsKeyDown(System.Windows.Input.Key.Up) && blocker.Location.Y > 0)
                blocker.Location = new Point(blocker.Location.X, Math.Max(blocker.Location.Y - 15, 0));
            if (Keyboard.IsKeyDown(System.Windows.Input.Key.Down) && blocker.Location.Y + blocker.Height < farthestHeight)
                blocker.Location = new Point(blocker.Location.X, Math.Min(blocker.Location.Y + 15, farthestHeight - blocker.Height));

            foreach (OvalShape o in bombs)
            {
                o.Location = new Point(o.Location.X + 10, o.Location.Y);
                if (CheckBlockerCollision(o) || CheckLineCollision(o))
                {
                    o.Visible = false;
                    bombsToRemove.Add(o);
                }
            }
            foreach (OvalShape o in bombsToRemove)
                bombs.Remove(o);
            this.Refresh();
            this.Update();
        }

        private OvalShape CreateBomb()
        {
            OvalShape o = new OvalShape(0, rand.Next(0, farthestHeight - bombSize + 1), bombSize, bombSize);
            this.shapeContainer1.Shapes.Add(o);
            return o;
        }

        private bool CheckBlockerCollision(OvalShape c)
        {
            if (c.Location.Y + bombSize > blocker.Location.Y && c.Location.Y < blocker.Location.Y + blocker.Height &&
                ((c.Location.X >= blocker.Location.X && c.Location.X <= blocker.Location.X + blocker.Width) ||
                (c.Location.X + bombSize >= blocker.Location.X && c.Location.X + bombSize <= blocker.Location.X + blocker.Width)))
            {
                points++;
                return true;
            }
            return false;
        }

        private bool CheckLineCollision(OvalShape o)
        {
            if (firstLine.Visible && firstLine.X1 >= o.Location.X && firstLine.X1 <= o.Location.X + bombSize)
            {
                firstLine.Visible = false;
                return true;
            }
            else if (secondLine.Visible && secondLine.X1 >= o.Location.X && secondLine.X1 <= o.Location.X + bombSize)
            {
                secondLine.Visible = false;
                return true;
            }
            else if (thirdLine.Visible && thirdLine.X1 >= o.Location.X && thirdLine.X1 <= o.Location.X + bombSize)
            {
                thirdLine.Visible = false;
                return true;
            }
            return false;
        }

        private bool CheckIfOver()
        {
            if (!firstLine.Visible && !secondLine.Visible && !thirdLine.Visible)
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Protect the lines using the up and down arrow key");
            button1.Visible = false;
            Run();
        }

        void gameTimer_Tick(object sender, EventArgs e)
        {
            UpdateGame();
            if (CheckIfOver())
            {
                gameTimer.Enabled = false;
                MessageBox.Show(String.Format("Game Over.\nYou scored {0} points", points), "", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
