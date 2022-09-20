using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget__Serializer_e_Atributos_no_C_.Models
{
  public class MeuArray<T>
  {
    private int capacidade = 10;
    private int contador = 0;
    private T[] array = new T[10];
    public void AdicionarElementoArray(T elemento)
    {
        while(contador + 1 < 11)
        {
            array[contador] = elemento;
        }
        contador ++;
    }

    public T this[int index]
    {
        get {return array[index];}
        set{array[index] = value; }
    }
  }
}