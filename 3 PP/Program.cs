using System;

class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Калькулятор возраста");

        // Запрашиваем дату рождения пользователя
        Console.Write("Введите дату рождения (в формате ГГГГ-ММ-ДД): ");
        string input = Console.ReadLine();

        DateTime birthDate;
        if (DateTime.TryParse(input, out birthDate))
        {
            // Вычисляем возраст
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;

            // Корректируем разницу в месяцах и днях, если это необходимо
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(birthDate.Year, birthDate.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }

            // Выводим результат
            Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев, {days} дней.");
        }
        else
        {
            Console.WriteLine("Неверный формат даты.");
        }
    }
}