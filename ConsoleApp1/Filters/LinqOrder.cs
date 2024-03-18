using ConsoleApp1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Filters
{
    public class LinqOrder
    {
        public static async void ExibirListaCriptosOrdenadas(Criptos lista)
        {
            
            var criptosOrdenadas = lista.Data.OrderBy(data => data.Name).Select(data => data.Name).Distinct().ToList();
            Console.WriteLine("Lista de criptos ordenadas");
            foreach (var cc in criptosOrdenadas)
            {
                Console.WriteLine("- " + cc);
            }

        }
    }
}
