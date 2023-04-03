using classmethods;

Console.WriteLine("Creating an employee");
Console.WriteLine("----------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1997, 06, 23), 25 ); 

bethany.DisplayEmployeeDetails();

bethany.performWork();
bethany.performWork();
bethany.performWork(5);
bethany.performWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageBethany}");

Console.WriteLine("Creating an employee");
Console.WriteLine("----------\n");

Employee george = new Employee("george", "Smith", "george@snowball.be", new DateTime(1997, 06, 23), 25);

george.DisplayEmployeeDetails();

george.performWork();
george.performWork();
george.performWork(5);
george.performWork();
george.performWork(8);
double receivedWagegeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWagegeorge}");


