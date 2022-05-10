

/*
Person Employee = new();


Console.WriteLine("Input name:");
Employee.Name = Console.ReadLine();

Console.WriteLine("Input Pay:");
Employee.Pay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Employee.Name + " " + Employee.Pay);
*/


class Person
{
    public string Name = "";
    public int Pay;

}

class Staff
{
    Person[] Employees = {};
    public void AddStaff(string Name, int Pay)
    {
        Person Employee = new();
        Employee.Name=Name;
        Employee.Pay=Pay;
        Employees.Append(Employee);
    }
    public void ListStaff()
    {
        for(int i=0;i<Employees.Count() ; i++)
        {
            Person Employee = Employees[i];
            Console.WriteLine(Employee.Name + " " + Employee.Pay);
        }
    }
}