using BL.InventarioFarmacia;
using System;
using System.Windows.Forms;

namespace InventarioFarmacia
{
    public partial class FormLogin : Form     
    {

        SeguridadBL _seguridad;


        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }
               
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
              && !string.IsNullOrEmpty(textBox2.Text))

            {
                button1.PerformClick();
            }

        }

       
        private void button1_Click(object sender, EventArgs e)
        {


            string usuario1;       //declaracion de variables usuarios
            string contrasenia1; //declaracion de variables contraseñas

            usuario1 = textBox1.Text;        //la variable usuario1 sera igual a lo que escriba en el tex
            contrasenia1 = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verficando";
            Application.DoEvents();

            //if (usuario1 == "admin" && contrasena1 == "123")

            var usuarioDB = _seguridad.Autorizar(usuario1, contrasenia1);
            //   var resultado = _seguridad.Autorizar(usuario1, contraseña1);

            if (usuarioDB != null)
            {
                Program.UsuarioLogueado = usuarioDB;

                this.Close();
            }
            else
            {
                MessageBox.Show(" Usuario o contraseña incorrecta ");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra el sistema completamente
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}