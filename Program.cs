          // Выполнение практических задааний к семинарам

          //  Урок 1, задача 2
          //  Напишите программу, которая на вход принимает два числа, и выдаёт, какое число большее, а какое меньшее:
static double Seminar_1_Task_02(double Num1, double Num2) {
    if (Num1 > Num2) return Num1;
        else if (Num2 > Num1) return Num2;
          // Возврат нуля, если числа равны   
                 else return 0;        
 
          // Команды для выполнения задачи 2 (вынести вниз за тело функции и запустить на выполнение)
Console.WriteLine("Введите первое число:");
double N1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double N2 = Convert.ToDouble(Console.ReadLine());
double Max_of_two = Seminar_1_Task_02(N1, N2);
if (Max_of_two != 0) Console.WriteLine($"Большее число: {Seminar_1_Task_02(N1, N2)}");
    else Console.WriteLine($"Числа равны: {N1} = {N2}");

}

// Console.WriteLine("Hello, World!");
// double height = Convert.ToDouble(Console.ReadLine());