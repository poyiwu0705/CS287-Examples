using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code.org;

namespace Example02
{
    public partial class MainWingow : Form
    {
        public Person elsa;

        public MainWingow()

        {
            InitializeComponent();
            this.elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 100.0,
                    Y = 0.0
                },
                Theta = 0.0
            };
            int x = (int)elsa.Pos.X;
            int y = (int)elsa.Pos.Y;
            ElsaPictureBox.Location = new Point(x, y);
        }
    }
}