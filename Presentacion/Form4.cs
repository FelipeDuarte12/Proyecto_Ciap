using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensajeError("El solicitante ha sido agregado con exito");
        }
        private void mensajeError(string msg)
        {
            label1.Text = "  " + msg;
            label1.Visible = true;

        }
    }
}
