using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget__Serializer_e_Atributos_no_C_.Models
{
    public static class IntExtensions
    {
        public static bool verificaPar(this int numero)
        {
            return numero % 2 ==0;
        }
    }
}