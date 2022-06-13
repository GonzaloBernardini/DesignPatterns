using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeService.Instance.getCountries();
            int idBuenosAires = 1;
            SomeService.Instance.getProvince(idBuenosAires);
        }
    }
}
