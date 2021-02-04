using System;

namespace EmpWageComputationProgramRefactored
{
    class EmpWageBuilder
    {
        //Constant
        public const int IS_PRESENT = 1;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 0;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_NUM_OF_HOURS = 100;

        //Class Variable
        public static int totalEmpWage = 0;
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;
        public static int empHrs;
        public static int empWage;

        /// <summary>
        /// 
        /// </summary>
        // Class Method
        public static void CheckingWage()
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
           

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder.CheckingWage();
        }
    }
}
