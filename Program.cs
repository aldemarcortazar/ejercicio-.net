using System;

namespace ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var program = new Program();
            program.PedirNombre();
        }

        private bool PedirNombre()
        {
            string nombre()
            {
                Console.WriteLine("bienvenido a tu banco amigo a continuacion debes escribir tu nombre para validar que eres mienbro del banco");
                string nombre = Console.ReadLine();
                return nombre;
            }
            string opcion = null;
            do
            {
                var name = nombre();
                var usuario = new Usuario(name);
                bool veriNombre = usuario.getusuarios();
                if (veriNombre != true)
                {
                    Console.WriteLine("Error tu nombreno se encuentra registrado en nuestra base de datos, " +
                        "quieres volver a intentar: ");
                    Console.WriteLine("escribe 1 para volver y 2 para salir: ");
                    opcion = Console.ReadLine();
                }
                else
                {
                    this.opciones(name);
                }
                //return usuario;
            } while (opcion == "1");
            return true;
        }
        private void opciones( string usuario)
        {
            Console.WriteLine("que opcion deseas realizar 1 para consignar , 2 para retirar y 3 para salir");
            var op = Int16.Parse( Console.ReadLine());
            var banco = new Banco();
            var cantidad = 0;
            switch (op)
            {
                case 1:
                    Console.WriteLine("cuanta cantidad deseas consignar");
                    cantidad = Int32.Parse(Console.ReadLine());
                    banco.deposito(usuario, cantidad);
                    break;
                case 2:
                    Console.WriteLine("cuanto dinero deseas Retirar");
                    cantidad = Int32.Parse(Console.ReadLine());
                    banco.retiro(usuario, cantidad);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}
