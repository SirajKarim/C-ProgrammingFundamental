﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    class Program
    {
       public static object BinarySearchRecursive(int [] inputArray, int key, int min, int max)
{
      if (min > max)
      {
          return "Nil";
      }
      else
      {
          int mid = (min+max)/2;
          if (key == inputArray [mid])
          {
             return ++mid;
           }
           else if (key < inputArray [mid])
           {
               return BinarySearchRecursive(inputArray, key, min, mid - 1);
           }
           else
           {
              return BinarySearchRecursive(inputArray, key, mid + 1, max);
           }
      }
 }
        }
    }

