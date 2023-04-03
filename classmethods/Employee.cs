using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethods
{
   public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        //constructor
        public Employee(string first, string last, string em, DateTime bd) :this(first,last,em,bd, 0)  
        {
            

        }

        public Employee( string first, string last, string em, DateTime bd, double rate) 
        {
            firstName= first;
            lastName= last;
            email= em;
            birthDay= bd;
            hourlyRate= rate;
           
            
        }

        public void performWork()
        {
            //  numberOfHoursWorked++;
            performWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }
        public void performWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for  {numberOfHours} hour(s)!");
            
        }
        public double ReceiveWage(bool resetHours = true) 
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($" {firstName} {lastName} has recived a wage of {wage} for {numberOfHoursWorked } hour(s) of work.");

            if ( resetHours ) 
                numberOfHoursWorked = 0;

            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($" \nFirstName: \t{firstName} \n{lastName}: \t {lastName}\nEmail: \t\t{email} \nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}
