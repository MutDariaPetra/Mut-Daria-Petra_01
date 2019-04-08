using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Mut_Daria
{
    public partial class Nivel2 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Nivel2()
        {
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
