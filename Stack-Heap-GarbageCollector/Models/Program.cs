using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack_Heap_GarbageCollector.Models
{
  public class Program
  {
    public static void Main(String[] args)
    {
      int n = int.Parse(Console.ReadLine());

      int[] num = new int[n];

      for (int i = 0; i < num.Length; i++)
      {
        num[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine(MajorityElement(num));

    }
    public static int MajorityElement(int[] nums)
    {
      int major = nums[0];
      int count = 1;
      for (int i = 0; i < nums.Length; i++)
      {
        if (i != nums[i] )
        {
          major = nums[i];
          count = count + 0 ;
        }
        else
        {
          if (major == nums[i])
          {
            count++;
          }
          else
          {
            count--;
          }
        }
      }
      return MajorityElement();
    }
  }
}