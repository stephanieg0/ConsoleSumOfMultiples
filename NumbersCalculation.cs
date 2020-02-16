using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleSumOfMultiples
{
    public class NumbersCalculation
    {
        public NumbersCalculation()
        {
            listOfMultiples = new List<int>();
            sumOfMultiples = 0;
        }

        public void getListOfMultiples(int a, int b)
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % a == 0 || i % b == 0){
                    listOfMultiples.Add(i);
                }
            }
        }

        public void sumNumbers(List<int> numbersList)
        {
            if (numbersList.Count > 0)
            {
                for(int i = 0; i < numbersList.Count; i++)
                { 
                    sumOfMultiples += numbersList[i];
                }
            }
        }

        public List<int> listOfMultiples;
        public int sumOfMultiples;
    }
}
