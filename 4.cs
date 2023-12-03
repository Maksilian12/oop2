using System;

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age, DateTime registrationDate)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = registrationDate;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата реєстрації: {RegistrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Ініціалізація об'єкта класу User
        DateTime registrationDate = DateTime.Now; // Приклад використання поточної дати
        User user = new User("user123", "Іван", "Петров", 30, registrationDate);

        // Виведення інформації про користувача на екран
        user.DisplayUserInfo();

        Console.ReadKey();
    }
}
