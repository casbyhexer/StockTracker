﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ST10069127
 Luwano Casby Mhango
 GROUP 1
 PROG 3B
 ICE 1
 */
namespace _3xPlus1.Classes
{
    public class T3XPlus
    {
        // This list stores the sequence of numbers generated by the 3x+1 algorithm
        public readonly List<long> DataList = new List<long>();

        // Public property to access the DataList
        public List<long> DataListPublic => DataList;

        // This is a method to calculate the 3x+1 sequence
        public void calc(int xValue)
        {
            try
            {
                // Check if the input value is less than or equal to 0
                if (xValue <= 0)
                {
                    throw new ArgumentException("xValue must be a positive integer greater than 0.");
                }

                // Clear the DataList before starting the calculation
                this.DataList.Clear();

                // Loop to generate the 3x+1 sequence
                do
                {
                    // If xValue is even, divide it by 2
                    if (xValue % 2 == 0)
                    {
                        xValue /= 2;
                    }
                    // If xValue is odd, multiply by 3 and add 1
                    else
                    {
                        xValue = 3 * xValue + 1;
                    }

                    // Add the current xValue to the DataList
                    DataList.Add(xValue);

                } while (xValue != 1); // Continue until xValue becomes 1
            }
            catch (ArgumentException ex)
            {
                // Handle specific input error
                Console.WriteLine($"Input Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
        // Method to calculate stock projection based on two input values
        public void CalculateStockProjection(int xValue1, int xValue2)
        {
            // Clear the existing data list
            DataList.Clear();
            //remove, for demo 
            xValue1 = 200;
            xValue2 = 30;

            DataList.Add((long)xValue1);
            DataList.Add((long)xValue2);

            Random random = new Random();

            // This is a placeholder and should be replaced with actual stock projection logic
            for (int i = 0; i < 10; i++)
            {
                // Generate a random number between -1 and 1
                int ranNum = random.Next(-1, 2);

                // Calculate the projected value with random variation
                long projectedValue = xValue1 + (xValue2 * i) + ranNum;

                // Add the projected value to the DataList
                DataList.Add(projectedValue);
            }
        }
    }
}
//__---____---____---____---____---____---____---__.ooo END OF FILE ooo.__---____---____---____---____---____---____---__\\