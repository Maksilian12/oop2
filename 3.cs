using System;

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0;
        double tax = 0;

        // Логіка розрахунку окладу в залежності від посади та стажу
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 30000 + (experience * 1000);
                break;
            case "developer":
                baseSalary = 40000 + (experience * 1200);
                break;
            case "designer":
                baseSalary = 35000 + (experience * 1100);
                break;
            default:
                Console.WriteLine("Посада не розпізнана");
                return;
        }

        // Розрахунок податкового збору (припустимо 15%)
        tax = 0.15 * baseSalary;

        // Виведення інформації про співробітника, оклад та податковий збір
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary} грн");
        Console.WriteLine($"Податковий збір: {tax} грн");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта Employee з прізвищем та ім'ям
        Employee employee = new Employee("Петров", "Іван");

        // Розрахунок окладу та податкового збору для співробітника
        employee.CalculateSalaryAndTax("developer", 5);

        Console.ReadKey();
    }
}
