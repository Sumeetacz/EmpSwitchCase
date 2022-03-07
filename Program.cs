﻿namespace employeeWages
{
    class empWageUsingSwitch
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_per_Hour = 20;
        static void Main(string[] args)
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case Is_Part_Time:
                    empHrs = 4;
                    break;
                case Is_Full_Time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}
