using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Caneta",
                3,
                true,
                27.4
            };
            Console.WriteLine(arrayList);
            arrayList.Add(3.14);
            foreach (object item in arrayList)
            {
                Console.WriteLine($"{item}  {item.GetType()}");
            }
        }
    }
}
