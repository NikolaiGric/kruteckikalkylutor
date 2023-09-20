while (true)
{
    Int32 выбор = 0;
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("Операция 1: Сложение");
    Console.WriteLine("Операция 2: Вычитание");
    Console.WriteLine("Операция 3: Деление");
    Console.WriteLine("Операция 4: Умножение");
    Console.WriteLine("Операция 5: Возведение в степень");
    Console.WriteLine("Операция 6: Извлечение корня");
    Console.WriteLine("Операция 7: Нахождение одного процента от числа");
    Console.WriteLine("Операция 8: Нахождение факториала ");
    Console.WriteLine("Операция 9: Выход из программы");
    try
    {

         выбор = Convert.ToInt32(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine("Ошиба неверный выбор, выберите операцию из предложенных.");
    }
    switch (выбор)
{
        case 1:
            Console.WriteLine("Вы выбрали операцию сложения");
            Console.WriteLine("Ведите 2 числа");
            double число_1 = Convert.ToDouble(Console.ReadLine());
            double число_2 = Convert.ToDouble(Console.ReadLine());
            double число_помощь_1 = число_1 + число_2;
            Console.WriteLine("Ответ:" + число_помощь_1);
            break;
        case 2:
            Console.WriteLine("Вы выбрали операцию вычитания");
            Console.WriteLine("Ведите 2 числа");
            double число_3 = Convert.ToDouble(Console.ReadLine());
            double число_4 = Convert.ToDouble(Console.ReadLine());
            double число_помощь_2 = число_3 - число_4;
            Console.WriteLine("Ответ:" + число_помощь_2);
            break;
        case 3:
            Console.WriteLine("Вы выбрали операцию деления");
            Console.WriteLine("Ведите 2 числа");
            double число_5 = Convert.ToDouble(Console.ReadLine());
            double число_6 = Convert.ToDouble(Console.ReadLine());
               while (число_6 == 0)
                {
                Console.WriteLine("Вы ввели 0 вторым числом, на ноль делить нельзя! Введите другое число.");
                число_6 = Convert.ToDouble(Console.ReadLine());
                }
            double число_помощь_3 = число_5 / число_6;
            Console.WriteLine("Ответ:" + число_помощь_3);
            break;
        case 4:
            Console.WriteLine("Вы выбрали операцию умножение");
            Console.WriteLine("Ведите 2 числа");
            double число_7 = Convert.ToDouble(Console.ReadLine());
            double число_8 = Convert.ToDouble(Console.ReadLine());
            double число_помощь_4 = число_7 * число_8;
            Console.WriteLine("Ответ:" + число_помощь_4);
            break;
        case 5:
            Console.WriteLine("Вы выбрали операцию возведение в степень");
            Console.WriteLine("Ведите 2 числа");
            double число_9 = Convert.ToDouble(Console.ReadLine());
            double число_10 = Convert.ToDouble(Console.ReadLine());
            double число_помощь_5 = Math.Pow(число_9, число_10);
            Console.WriteLine("Ответ:" + число_помощь_5);
            break;
        case 6:
            Console.WriteLine("Вы выбрали операцию извлечение квадратного корня");
            Console.WriteLine("Ведите 1 число");
            double число_11 = Convert.ToDouble(Console.ReadLine());
            double число_помощь_6 = Math.Sqrt(число_11);
            Console.WriteLine("Ответ:" + число_помощь_6);
            break;
        case 7:
            Console.WriteLine("Вы выбрали операцию нахождение процента от числа");
            Console.WriteLine("Ведите 1 число");
            double число_12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("Ответ:" + число_12 / 100 * 1);
            break;
        case 8:
            Console.WriteLine("Вы выбрали операцию нахождение факториала");
            Console.WriteLine("Ведите 1 число");
            int число_13 = Convert.ToInt32(Console.ReadLine());
            int число_помощь_7 = 1;
            for (int i = 2; i <= число_13; i++)
            {

                число_помощь_7 *= i;

            }
            Console.WriteLine(число_помощь_7);

            break;
        case 9:
            return;
            break; 

    }
}
