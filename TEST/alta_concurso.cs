using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class alta_concurso : Form
    {
        public alta_concurso()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Concurso c1 = new Concurso(1,"Prueba","random","de",1500,"Ssdqw");
            c1.agregar_bd();
        }
    }
}
