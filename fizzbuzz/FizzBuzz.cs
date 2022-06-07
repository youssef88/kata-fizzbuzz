﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public static string Convert(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }

    }
}
