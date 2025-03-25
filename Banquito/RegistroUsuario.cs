using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquito
{
    class Usuario
    {
        public string usuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        
        public Usuario(string Usuario, string contrasena, string correo, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            usuario = Usuario;
            Contrasena = contrasena;
            Correo = correo;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
    }
    class RegistroUsuarios
    {
        List<Usuario> ListaUsuarios = new List<Usuario>();
        public bool RegistrarUsuario(string usuario, string contrasena,string repetirContrasena, string correo, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            
            ListaUsuarios.Add(new Usuario(usuario, contrasena, correo, nombre, apellidoPaterno, apellidoMaterno));
            return true;
        }

    }
}
