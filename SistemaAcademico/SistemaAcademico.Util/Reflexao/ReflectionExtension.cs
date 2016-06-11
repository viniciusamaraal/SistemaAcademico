using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Util.Reflexao
{
    public static class ReflectionExtension
    {
        /// <summary>
        /// Busca o valor de uma propriedade do tipo informado via reflexão, default caso não encontrado.
        /// </summary>
        /// <typeparam name="T">Tipo procurado.</typeparam>
        /// <param name="obj">Objeto onde será procupada a propriedade.</param>
        public static T BuscarPropriedade<T>(this object obj)
        {
            foreach (var propriedade in obj.GetType().GetProperties())
            {
                if (propriedade.PropertyType.IsSubclassOf(typeof(T)))
                    return (T)propriedade.GetValue(obj);
            }

            return default(T);
        }
    }
}
