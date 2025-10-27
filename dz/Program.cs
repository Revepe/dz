using System;  // Подключаем пространство имен System для работы с базовыми функциями

class Program
{
    static void Main()
    {
        // Устанавливаем кодировку вывода для поддержки русского языка
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double num1, num2;  // Для работы с дробными числами
        int choice;         // Для выбора операции из меню
        double result;      // Для хранения результата вычислений

        // Выводим заголовок программы
        Console.WriteLine("=== Калькулятор ===");
        Console.WriteLine("============================");

        // БЛОК ВВОДА ПЕРВОГО ЧИСЛА
        Console.Write("Введите первое число: ");
        // Цикл продолжается до тех пор, пока пользователь не введет корректное число
        // double.TryParse() пытается преобразовать строку в число, возвращает true если успешно
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Ошибка! Введите корректное число: ");
        }

        // БЛОК ВВОДА ВТОРОГО ЧИСЛА
        Console.Write("Введите второе число: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Ошибка! Введите корректное число: ");
        }

        // МЕНЮ ВЫБОРА ОПЕРАЦИЙ
        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("1. Сложение (+)");
        Console.WriteLine("2. Вычитание (-)");
        Console.WriteLine("3. Умножение (*)");
        Console.WriteLine("4. Деление (/)");
        Console.WriteLine("5. Остаток от деления (%)");
        Console.WriteLine("6. Инкремент первого числа (++)");
        Console.WriteLine("7. Декремент первого числа (--)");
        Console.WriteLine("8. Инкремент второго числа (++)");
        Console.WriteLine("9. Декремент второго числа (--)");
        Console.WriteLine("0. Выход");

        // БЛОК ВЫБОРА ОПЕРАЦИИ
        Console.Write("\nВаш выбор: ");
        // Проверяем что введено число от 0 до 9
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 9)
        {
            Console.Write("Ошибка! Введите число от 0 до 9: ");
        }

        Console.WriteLine();  // Пустая строка для красоты

        // ОСНОВНОЙ БЛОК ВЫЧИСЛЕНИЙ - оператор switch
        switch (choice)
        {
            case 1: // Сложение
                result = num1 + num2;
                // F2 - формат вывода с 2 знаками после запятой
                Console.WriteLine($"Результат: {num1} + {num2} = {result:F2}");
                break;

            case 2: // Вычитание
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result:F2}");
                break;

            case 3: // Умножение
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result:F2}");
                break;

            case 4: // Деление
                // Проверка деления на ноль
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                break;

            case 5: // Остаток от деления
                // Проверяем деление на ноль
                if (num2 != 0)
                {
                    result = num1 % num2;  // Оператор % возвращает остаток от деления
                    Console.WriteLine($"Результат: {num1} % {num2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                break;

            case 6: // Инкремент первого числа
                result = num1 + 1;
                Console.WriteLine($"Результат: {num1}++ = {result:F2}");
                break;

            case 7: // Декремент первого числа
                result = num1 - 1;
                Console.WriteLine($"Результат: {num1}-- = {result:F2}");
                break;

            case 8: // Инкремент второго числа
                result = num2 + 1;
                Console.WriteLine($"Результат: {num2}++ = {result:F2}");
                break;

            case 9: // Декремент второго числа
                result = num2 - 1;
                Console.WriteLine($"Результат: {num2}-- = {result:F2}");
                break;

            default:
                Console.WriteLine("Ошибка: Неверный выбор операции!");
                break;
        }
    }
}