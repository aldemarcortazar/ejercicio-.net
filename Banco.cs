using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio
{
    public class Banco
    {
        private double depositos;
        public Banco()
        {
            Console.WriteLine("la cantida de depoitada en el banco es: " + this.getDepositos());
        }
        public void deposito( string cliente, double cantidad)
        {
            var usuario = new Usuario(cliente);
            usuario.cuenta += cantidad;
            this.depositos += cantidad;
        }
        public void retiro( string cliente, double cantidad)
        {
            var usuario = new Usuario(cliente);
            usuario.cuenta -= cantidad;
            this.depositos -= cantidad;
        }
        private double getDepositos()
        {
            return this.depositos;
        }

    }
}
