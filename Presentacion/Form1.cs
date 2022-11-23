using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    modeloUsuario usuario = new modeloUsuario();
                    var validLogin = usuario.loginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        string tipo = usuario.tipo_trabajador(txtuser.Text, txtpass.Text);
                        if (tipo == "admin2")
                        {
                            Form2 menuHora = new Form2();
                            menuHora.Show();
                            this.Hide();
                        }
                        
                        Form3 menuDireccion = new Form3();
                        menuDireccion.Show();
                        this.Hide();
                    }
                }
                else
                {
                    mensajeError("Por favor ingresa tu contraseña");
                }
            }
            else
            {
                mensajeError("Por favor ingresa tu usuario");
            }
            
        }
        private void mensajeError(string msg)
        {
            lblError.Text = "  " + msg;
            lblError.Visible = true;

        }
    }
}
