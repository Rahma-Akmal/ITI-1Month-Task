namespace ClassLibrary1
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
}
