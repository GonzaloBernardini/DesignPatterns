using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SomeService
    {
        //Inicializacion directa
        private readonly static SomeService _instance = new SomeService();


        //Ctor privado singleton
        private SomeService()
        {

        }

        //propiedad q me devuelve la instancia
        //Con esta prop puedo acceder a mis metodos de clase
        public static  SomeService Instance
        {
            get
            {
                return _instance;
            }
        }

        //Ahora cada vez que se inicie la app se ejecuta una sola vez new some service
        //y quedara creada hasta que siga viva el resto de la app.

        public void getCountries()
        {
            Console.WriteLine("Lista de paises");
        }

        public void getProvince(int idCountry)
        {
            Console.WriteLine("Busqueda de una provincia por id");
        }

    }
}
