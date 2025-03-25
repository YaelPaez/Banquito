using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquito
{
    public partial class Registro : Form
    {
        private RegistroUsuarios registroUsuario;

        public Registro()
        {
            InitializeComponent();
            registroUsuario = new RegistroUsuarios();

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string repetirContrasena = txtRepetirContrasena.Text;
            string correo = txtCorreo.Text;
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;

            registroUsuario.RegistrarUsuario(usuario, contrasena, repetirContrasena, correo, nombre, apellidoPaterno, apellidoMaterno);
        }
    }
}
