using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio
{
    class Usuario
    {
        private string cliente ;
        public double cuenta;
        public Usuario(string cliente)
        {
            this.cliente = cliente;
            this.cuenta = 0;
        }
        private List<string> usuarios()
        {
            List<String> usuarios = new List<string>();
            usuarios.Add("el papi 3325");
            usuarios.Add("juanmanuelrojas");
            usuarios.Add("andres rojas");
            //usuarios.ForEach(item => Console.WriteLine(item));
            return usuarios;
        }
        public bool getusuarios()
        {
            var nombre = this.usuarios().Exists(e => e.Equals(this.cliente));
            return nombre;
        }
    }
}
