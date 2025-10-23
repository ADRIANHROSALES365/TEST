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
             
            try {

                DateTime selected_date = calendar_1.SelectionRange.Start;
                Concurso c1 = new Concurso(tb_nombre.Text, tb_persona.Text, tb_dependencia.Text, int.Parse(tb_precio.Text), cb_status.Text,selected_date.ToString("dd MM yyyy"));
                c1.agregar_bd();
                MessageBox.Show("Concurso guardado correctamente");

            } catch (Exception ex) {

                MessageBox.Show("Error agregando el concurso a la base de datos"+ex.Message);

            }
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
