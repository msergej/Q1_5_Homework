          // Выполнение практических задааний к семинарам

          // Практическое задание к семинарам, урок 3 (22.09.22)
Seminar_3_Task_DS01();
// Seminar_3_Task_D04();
// Seminar_3_Task_D03();
// Seminar_3_Task_D02();
// Seminar_3_Task_D01();
// Seminar_3_Task_23();
// Seminar_3_Task_21();
// Seminar_3_Task_19();  


static void Seminar_3_Task_DS01() {
          // Задача DS01: На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
          // Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
    int Ax, Ay, Bx, By, Cx, Cy, i;
          // Определение уникальных (без учета направления) маршрутов
    string[] Routes ={"0-A-B-C-0", "0-A-C-B-0", "0-B-A-C-0"};
    int[] RouteNumbers ={0,1,2};
    double ShortestRoute, NextRoute;
    Random RundNum = new Random();

          // Выбор номера четверти и координатов точек 
    int Q = RundNum.Next(1, 5);
    if (Q == 1) {
        Ax = RundNum.Next(1, 11);
        Ay = RundNum.Next(1, 11);
        Bx = RundNum.Next(1, 11);
        By = RundNum.Next(1, 11);
        Cx = RundNum.Next(1, 11);
        Cy = RundNum.Next(1, 11);
    }
      else if (Q == 2) {
               Ax = RundNum.Next(-10, 0);
               Ay = RundNum.Next(1, 11);
               Bx = RundNum.Next(-10, 0);
               By = RundNum.Next(1, 11);
               Cx = RundNum.Next(-10, 0);
               Cy = RundNum.Next(1, 11);
           }
             else if (Q == 3) {
                      Ax = RundNum.Next(-10, 0);
                      Ay = RundNum.Next(-10, 0);
                      Bx = RundNum.Next(-10, 0);
                      By = RundNum.Next(-10, 0);
                      Cx = RundNum.Next(-10, 0);
                      Cy = RundNum.Next(-10, 0);
                  }
                    else { Ax = RundNum.Next(1, 11);
                           Ay = RundNum.Next(-10, 0);
                           Bx = RundNum.Next(1, 11);
                           By = RundNum.Next(-10, 0);
                           Cx = RundNum.Next(1, 11);
                           Cy = RundNum.Next(-10, 0);
                    }
          // Принимаем минимальным первый маршрут: 0-A-B-C-0
    i = 0;
    ShortestRoute = Math.Sqrt(Math.Pow(Ax,2) + Math.Pow(Ay,2)) + Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2)) +
                    Math.Sqrt(Math.Pow((Cx-Bx),2) + Math.Pow((Cy-By),2)) + Math.Sqrt(Math.Pow(Cx,2) + Math.Pow(Cy,2));
          // Проверяем второй маршрут: 0-A-C-B-0, и заменяем кратчайший, а также его номер
    NextRoute = Math.Sqrt(Math.Pow(Ax,2) + Math.Pow(Ay,2)) + Math.Sqrt(Math.Pow((Cx-Ax),2) + Math.Pow((Cy-Ay),2)) +
                Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2)) + Math.Sqrt(Math.Pow(Bx,2) + Math.Pow(By,2));
    if (NextRoute < ShortestRoute) {
        ShortestRoute = NextRoute; 
        i = 1;
    }
          // Проверяем третий маршрут: 0-B-A-C-0, и заменяем кратчайший, а также его номер
    NextRoute = Math.Sqrt(Math.Pow(Bx,2) + Math.Pow(By,2)) + Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2)) +
                Math.Sqrt(Math.Pow((Cx-Ax),2) + Math.Pow((Cy-Ay),2)) + Math.Sqrt(Math.Pow(Cx,2) + Math.Pow(Cy,2));
    if (NextRoute < ShortestRoute) {
        ShortestRoute = NextRoute; 
        i = 2;
    }
    Console.WriteLine($"Выбрана четветь: {Q}.");
    Console.WriteLine($"Отмечены точки: A({Ax}, {Ay}), B({Bx}, {By}), C({Cx}, {Cy}).");
    Console.WriteLine($"Кратчайший маршрут: {Routes[i]} ({ShortestRoute}).");
    Console.WriteLine("- - - - - - - Задача DS01 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_D04() {
          // Дополнительная задача 04: Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    int[] mas = new int[10];
    Random RundNum = new Random();
    
    for (int i=0; i<10; i++) mas[i] = RundNum.Next(1, 11);
    Console.WriteLine($"Заполненный массив: {mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}, {mas[4]}, {mas[5]}, {mas[6]}, {mas[7]}, {mas[8]}, {mas[9]}.");
    Console.WriteLine("- - - - - - - Задача D04 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_D03() {
          // Дополнительная задача 03: Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    Console.WriteLine("Введите трехзначное число:");
    int Num = Convert.ToInt16(Console.ReadLine());
    int AbsNum = Math.Abs(Num);
    if ((AbsNum >= 100) && (AbsNum < 1000)) 
        if ((((AbsNum % 10) == 4) | ((AbsNum % 10) == 7)) | ((((AbsNum / 10) % 10) == 4) |
           (((AbsNum / 10) % 10) == 7)) | (((AbsNum / 10) == 4) | ((AbsNum / 10) == 7)))
        {
            Console.WriteLine($"Цифры 4 или 7 встречаются в числе {Num}.");
        } 
          else Console.WriteLine($"В числе {Num} цифры 4 и 7 не встречаются.");
      else Console.WriteLine("Введенное число не трехзначное!");
    Console.WriteLine("- - - - - - - Задача D03 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_D02() {
          // Дополнительная задача 02: Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    Console.WriteLine("Введите трехзначное число:");
    int Num = Convert.ToInt16(Console.ReadLine());
    if ((Math.Abs(Num) >= 100) && (Math.Abs(Num) < 1000)) {
          // Если сумма цифр числа кратна трем, то и число кратно трем; также верно обратное утверждение.
        if ((Num % 3) == 0) Console.WriteLine($"Сумма цифр числа {Num} кратна трем.");
            else Console.WriteLine($"Сумма цифр числа {Num} не кратна трем.");
    }   else Console.WriteLine("Введенное число не трехзначное!");
    Console.WriteLine("- - - - - - - Задача D02 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_D01() {
          // Дополнительная задача 01: Рассчитать значение Y при заданном X по формуле
          // при x>0: sin^2(x), иначе(1- 2*sin(x^2)).
    Random RundNum = new Random();
    double X = Convert.ToDouble(RundNum.Next(-100000, 100000)) / 10000;
    if (X > 0) Console.WriteLine($"При X = {X} Y = sin^2(x) = {Math.Pow(Math.Sin(X),2)}.");
        else Console.WriteLine($"При X = {X} Y = (1-2*sin(x^2)) = {1-2*Math.Sin(Math.Pow(X,2))}.");
    Console.WriteLine("- - - - - - - Задача D01 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_23() {
          // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Random RundNum = new Random();
    int Num = RundNum.Next(1, 100);
    string ResultStr = "";
    int i = 0;
          // Вывод кубов чисел по 10 в строке
    Console.WriteLine($"Кубы чисел от 0 до {Num}:");
          // Обработка полных десятков в цикле WHILE
    while (i < Num / 10) {
        ResultStr = "";
        for (int j=0; j<10; j++) {
            ResultStr = ResultStr.Insert(ResultStr.Length, Convert.ToString(Math.Pow((i*10+j),3)));
            ResultStr = ResultStr.PadRight(8*(j+1));       // дополняем строу пробелами справа до следующего числа
        }
        Console.WriteLine(ResultStr);
        i = i + 1;
    }     // Дообработка неполного десятка в цикле FOR (используется I от цикла WHILE) и вывод после цикла
    ResultStr = "";
    for (int j=0; j<=Num%10; j++) {
        ResultStr = ResultStr.Insert(ResultStr.Length, Convert.ToString(Math.Pow((i*10+j),3)));
        ResultStr = ResultStr.PadRight(8*(j+1));       // дополняем строу пробелами справа до следующего числа
    }
    Console.WriteLine(ResultStr);
    Console.WriteLine("- - - - - - - Задача 23 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_21() {
          // Задача 21: Напишите программу, которая принимает на вход координаты двух точек
          // и находит расстояние между ними в 3D пространстве.
    Random RundNum = new Random();
    int Ax = RundNum.Next(-100, 101);
    int Ay = RundNum.Next(-100, 101);
    int Az = RundNum.Next(-100, 101);
    int Bx = RundNum.Next(-100, 101);
    int By = RundNum.Next(-100, 101);
    int Bz = RundNum.Next(-100, 101);

    Console.WriteLine($"Точки: A({Ax}, {Ay}, {Az}), B({Bx}, {By}, {Bz})");
    Console.WriteLine($"Расстояние между точками А и В: {Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2))}");
    Console.WriteLine("- - - - - - - Задача 21 успешно выполнена! - - - - - - -\n");
}
static void Seminar_3_Task_19() {
          // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
          // является ли оно палиндромом (например, 12321).
    Console.WriteLine("Введите пятизначное число:");
    int Num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if ((Num <= 99999) & (Num >= 10000))
        if (((Num / 10000) == (Num % 10)) & (((Num % 10000) / 1000) == (Num % 100 / 10))) Console.WriteLine($"Число {Num} является палиндромом.");
            else Console.WriteLine($"Число {Num} не является палиндромом.");
        else Console.WriteLine($"Введено не пятизначное число!");
    Console.WriteLine("- - - - - - - Задача 19 успешно выполнена! - - - - - - -\n");
}

          // Практическое задание к семинарам, урок 2 (19.09.22)
// Seminar_2_Task_15();
// Seminar_2_Task_13();
// Seminar_2_Task_11();

static void Seminar_2_Task_15() {
          // Задача 15:  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
          //  является ли этот день выходным.
    Console.WriteLine("Введите номер дня недели от 1 до 7:");
    int Num = Convert.ToInt16(Console.ReadLine());
    if (Num >= 6) Console.WriteLine($"{Num}-й день недели - это выходной!");
        else Console.WriteLine($"{Num}-й день недели - это рабочий день.");
    Console.WriteLine("- - - - - - - Задача 15 успешно выполнена! - - - - - - -\n");
}
static void Seminar_2_Task_13() {
          // Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа
          // или сообщает, что третьей цифры нет.
    Console.WriteLine("Введите целое число:");
    int Num = Convert.ToInt32(Console.ReadLine());
          // Третья слева цифра возможна только в числах больше ста 
    if (Num >= 100) {
          // Уменьшение числа делением на 10, пока оно не станет не более чем трехзначным        
        while (Num >= 1000) {Num = Num / 10;}        
        Console.WriteLine($"Третья цифра слева: {(Num % 10)}");
    } else Console.WriteLine("Введенное число не содержит третьей цифры слева!");
    Console.WriteLine("- - - - - - - Задача 13 успешно выполнена! - - - - - - -\n");
}
static void Seminar_2_Task_11() {
          // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Введите трехзначное число:");
    int Num= Convert.ToInt16(Console.ReadLine());
    if ((Num >= 100) && (Num < 1000)) {
        int tens_and_ones = (Num % 100);
          // выделение разрядов десятков (если INT, то "/" - это челочисленное деление)
        if (tens_and_ones > 9) Console.WriteLine($"Вторая цифра: {(tens_and_ones / 10)}");
            else Console.WriteLine($"Вторая цифра: 0");
    } else Console.WriteLine("Введенное число не трехзначное!");
    Console.WriteLine("- - - - - - - Задача 11 успешно выполнена! - - - - - - -\n");
}

/*
          //  Урок 1, задача 8
          //  Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N:
static string Seminar_1_Task_08(int Num) {
          // Проверка четности числа и уменьшение на 1 при необходимости
    string ResultStr = "";
    if ((Num % 2) != 0) Num--;
    while (Num >= 2) {
        if (ResultStr.Length > 0) ResultStr = ResultStr.Insert(0, ", ");
        ResultStr = ResultStr.Insert(0, Convert.ToString(Num));
        Num = Num - 2;
    }
    return ResultStr;
}   
          // Команды для выполнения задачи 8 (запустить на выполнение ниже тела функции)
Console.WriteLine("Введите натуральное число:");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Между 1 и {N} расположены (включительно) сющие четные числа:");
Console.WriteLine(Seminar_1_Task_08(N));
*/
/*
          //  Урок 1, задача 6
          //  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным:
static void Seminar_1_Task_06(int Num) {
    if ((Num % 2) == 0) Console.WriteLine($"Число {Num} четное.");
       else Console.WriteLine($"Число {Num} нечетное.");
}  
          // Команды для выполнения задачи 6 (вынести вниз за тело функции и запустить на выполнение)
Console.WriteLine("Введите число:");
int N = Convert.ToInt16(Console.ReadLine());
Seminar_1_Task_06(N);
          // Команды для выполнения задачи 6        
*/
/*
          //  Урок 1, задача 4
          //  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел:
static double Seminar_1_Task_04(double Num1, double Num2, double Num3) {
          // Первоначальная установка максимального значения в Num1
    double MaxNum = Num1;
    if (Num2 > MaxNum) MaxNum = Num2;
    if (Num3 > MaxNum) MaxNum = Num3;
    return MaxNum;        
}
          // Команды для выполнения задачи 4 (вынести вниз за тело функции и запустить на выполнение)
Console.WriteLine("Введите первое число:");
double N1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double N2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число:");
double N3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Максимальное число: {Seminar_1_Task_04(N1, N2, N3)}");
          // Команды для выполнения задачи 4        
*/
/*
          //  Урок 1, задача 2
          //  Напишите программу, которая на вход принимает два числа, и выдаёт, какое число большее, а какое меньшее:
static double Seminar_1_Task_02(double Num1, double Num2) {
    if (Num1 >= Num2) return Num1;
       else return Num2;
}
          // Команды для выполнения задачи 2 (вынести вниз за тело функции и запустить на выполнение)
Console.WriteLine("Введите первое число:");
double N1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double N2 = Convert.ToDouble(Console.ReadLine());
if (N1 == N2) Console.WriteLine($"Числа равны: {N1} = {N2}");
   else if (Seminar_1_Task_02(N1, N2) == N1) Console.WriteLine($"Большее число: {N1}, меньшее число: {N2}");
           else Console.WriteLine($"Большее число: {N2}, меньшее число: {N1}");
          // Команды для выполнения задачи 2
*/