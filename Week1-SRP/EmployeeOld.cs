public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public void Save()
    {
        // Code to save employee to a database
    }

    public void GenerateReport()
    {
        // Code to generate a report for the employee
    }
}
