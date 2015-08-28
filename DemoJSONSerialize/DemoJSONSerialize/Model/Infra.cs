using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSONSerialize.Model
{
    class Infra
    {

        public static IList<Parametro> ObterConfig(string nomeJson)
        {
            IList<Parametro> parametros = null;
            using (var file = File.OpenText(nomeJson))
            {
                var serializer = new JsonSerializer();
                var pars = (IList<Parametro>)serializer.Deserialize(file, typeof(IList<Parametro>));
                if (pars != null)
                    parametros = pars;
            }
            return parametros;
        }

        public static void CriarConfig(string nomeJson)
        {
            IList<Parametro> parametros = Obterparametros();
            SaveAsJSON(parametros, nomeJson);
        }

        private static void SaveAsJSON(IList<Parametro> parametros, string nomeJson)
        {
            string jsonRepresentation = JsonConvert.SerializeObject(parametros);
            File.WriteAllText(nomeJson, jsonRepresentation);
        }

        private static IList<Parametro> Obterparametros()
        {
            return new List<Parametro> { 
                new Parametro{ID=1,Chave="Chave 1",Valor=1,Descricao="Descricao 1"},
                new Parametro{ID=2,Chave="Chave 2",Valor="2",Descricao="Descricao 2"},
                new Parametro{ID=3,Chave="Chave 3",Valor=DateTime.Now,Descricao="Descricao 3"},
                new Parametro{ID=4,Chave="Chave 4",Valor=4,Descricao="Descricao 4"},
                new Parametro{ID=5,Chave="Chave 5",Valor=true,Descricao="Descricao 5"}
            };
        }

    }
}
