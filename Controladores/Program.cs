using ejercicio7Ficheros.Servicios;

namespace ejercicio7Ficheros.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
            string ruta2 = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo2.txt";
            string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo.txt";

            string[] lineas;
            string aux;


            Console.WriteLine("Para usar el primer archivo pulse 1 , para usar el segundo archivo pulse 2");
            string respuesta = Console.ReadLine();

            if (respuesta.Equals("1"))
            {
                lineas = File.ReadAllLines(ruta);
                aux = ruta;
            }
            else
            {
               lineas = File.ReadAllLines(ruta2);
                 aux = ruta2;
            }
          
           


            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenu();
                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.modificarLinea(lineas,aux);
                        break;
                    case 2:
                        op.insertarTexto(lineas, aux);
                        break;
                    case 3:
                        op.guardarFichero(lineas, aux);
                        break;
                }
            }







          



        }
    }
}