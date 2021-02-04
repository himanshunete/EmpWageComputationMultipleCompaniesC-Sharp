using System;

namespace EmpWageComputationProgramRefactored
{
    class EmpWageBuilder
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 0;
        
        // Class Method
        public static void CalculateWage(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_NUM_OF_HOURS, int empHrsFullTime, int empHrsPartTime)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");

            //Variable
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int empHrs;
            int empWage;
            Random rand = new Random();

            //Computation
            while (totalEmpHrs <= MAX_NUM_OF_HOURS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalEmpHrs++;
                totalWorkingDays++;

                int workingTime = rand.Next(0, 2);
                switch (workingTime)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine(" Emp Daily Wage: " + empWage);
            }
            Console.WriteLine("Emp Total Wage of " + company+ " is: " + totalEmpWage + " Rs");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder.CalculateWage("Audi", 20, 25, 100, 8, 4);
            EmpWageBuilder.CalculateWage("BMW", 25, 20, 100, 9, 2);
            EmpWageBuilder.CalculateWage("Ferrari", 30, 18, 90, 7, 4);

        }
    }
}
