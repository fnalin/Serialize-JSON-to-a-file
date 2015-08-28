using DemoJSONSerialize.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSONSerialize
{
    class Program
    {
        private const string nomeJson = "config.json";

        static void Main(string[] args)
        {

            //Infra.CriarConfig(nomeJson);
            
            var configs = Infra.ObterConfig(nomeJson);

            if (configs != null)
                Console.WriteLine("Total de parâmetros: {0}", configs.Count);

            Console.Write("Fim");
            Console.ReadKey();

        }
    }
}
