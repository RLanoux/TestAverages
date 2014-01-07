using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserGradeAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            String sUserResp = String.Empty;
            Int32 iNumOfGrades = 0;
            Double dAverage = 0.0;
            Double dIndividual = 0.0;
            Double dSum = 0.0;

            //Ask the user how many grades he needs to average
            Console.Write("How many grades do you need to average? ");
            sUserResp = Console.ReadLine();
            iNumOfGrades = Convert.ToInt32(sUserResp);

            //Start the for loop and get the individual grades
            for (Int32 i = 0; i < iNumOfGrades; i++)
            {
                Console.Write("\nEnter the grade you want averaged (in .### format): ");
                sUserResp = Console.ReadLine();
                dIndividual = Convert.ToDouble(sUserResp);
                dSum += dIndividual;
                dAverage = (dSum / (Double)(iNumOfGrades));
            }
            
            //Show the user the average of the numbers
            Console.Write("\nThe average of the grades is: {0:P0}.", dAverage);
            Console.ReadLine();
        }
    }
}
