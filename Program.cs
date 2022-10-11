          // Выполнение практических задааний к семинарам

          // Практическое задание к семинарам, урок 7 (06.10.22)
Seminar_7_Task_D03();
// Seminar_7_Task_D02();
// Seminar_7_Task_D01();
// Seminar_7_Task_52();
// Seminar_7_Task_50();
// Seminar_7_Task_47();

static void Seminar_7_Task_D03() {
          // Задача D03: Двумерный массив размером 5х5 заполнен случайными нулями и единицами.
          // Игрок может ходить только по полям, заполненным единицами.
          // Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).
    Random RundNum = new Random();
    int Rows = RundNum.Next(5, 6);
    int Columns = RundNum.Next(5, 6);
    int[,] Map = new int [Rows,Columns];
    int i_max = Rows-1;
    int j_max = Columns-1;
    
    Seminar_7_Task_D03_FillArray(Map);
    Map[0,0] = 1;
    Map[Rows-1, Columns-1] = 1;
    Console.WriteLine("Карта лабирита:");
    Seminar_7_Task_D03_PrintArray(Map);
    Boolean Exit = false;
    Seminar_7_Task_D03_FindPath(Map, 0, 0);
    Console.WriteLine("Карта лабирита после попытки прохода:");
    Seminar_7_Task_D03_PrintArray(Map);
    if (Exit) Console.WriteLine("Выход из лабиринта есть!");
       else Console.WriteLine("Выход из лабиринта не обнаружен...");

    Console.WriteLine("- - - - - - - Задача D03 успешно выполнена! - - - - - - -\n");

    void Seminar_7_Task_D03_FindPath(int[,] Map, int i, int j) {
          // Задача D03. Подпрограмма поиска возможных следующих шагов (используя (8 вызовов) или нет (4 вызова) ходы по диагонали)
    if(i<0 || j<0 || i>i_max || j>j_max || Map[i,j]==0 || Map[i,j]==2) return;
    Map[i,j] = 2;
    if(i==i_max && j==j_max) {
            Exit = true;
            return;
    }
    Seminar_7_Task_D03_FindPath(Map, i-1, j);
    Seminar_7_Task_D03_FindPath(Map, i+1, j);
    Seminar_7_Task_D03_FindPath(Map, i, j-1);
    Seminar_7_Task_D03_FindPath(Map, i, j+1);
    Seminar_7_Task_D03_FindPath(Map, i-1, j-1);
    Seminar_7_Task_D03_FindPath(Map, i-1, j+1);
    Seminar_7_Task_D03_FindPath(Map, i+1, j-1);
    Seminar_7_Task_D03_FindPath(Map, i+1, j+1);
    } 
}
static void Seminar_7_Task_D03_FillArray(int[,] Mas) {
          // Задача D03. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = RundNum.Next(0,2);
}
static void Seminar_7_Task_D03_PrintArray(int[,] Mas) {
          // Задача D03. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "  ");    
        Console.WriteLine(""); 
    }
}
static void Seminar_7_Task_D02() {
          // Задача D02: Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
          // Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения.
          // Выведите оба массива.
    Random RundNum = new Random();
    int Rows = RundNum.Next(3, 4);
    int Columns = RundNum.Next(4, 5);
    int[,] Mas = new int [Rows,Columns];
    int FoundNum = 0;

    Seminar_7_Task_D02_FillArray(Mas);
    Console.WriteLine("Исходный массив:");
    Seminar_7_Task_D02_PrintArray(Mas);
    for(int i=0; i<Rows; i++)
        for(int j=0; j<Columns; j++)
            if(Seminar_7_Task_D02_CheckElement(Mas[i,j])) FoundNum += 1;      
    if (FoundNum > 0) {
        int[] FoundNumMas = new int [FoundNum];
        int k = 0;
        for(int i=0; i<Rows; i++)
            for(int j=0; j<Columns; j++)
                if(Seminar_7_Task_D02_CheckElement(Mas[i,j])) {
                    FoundNumMas[k] = Mas[i,j];          
                    k++;
                }
        Console.WriteLine($"В массиве обнаружены числа ({FoundNum}), у которых сумма цифр равна их произведению:");
        for(int i=0; i<FoundNum; i++) Console.Write(FoundNumMas[i] + ", ");    
        Console.WriteLine(""); 
    } 
      else Console.WriteLine("В массиве не обнаружены числа, у которых сумма цифр равна их произведению.");

    Console.WriteLine("- - - - - - - Задача D02 успешно выполнена! - - - - - - -\n");
}
static bool Seminar_7_Task_D02_CheckElement(int N) {
          // Задача D03. Подпрограмма проверки числа на выполнениеусловия равенства суммы его цифр их произведению
        int TmpI = N;  
        int DigitSum = 0;
        int DigitProduct = 1;
        
        while(TmpI > 0) {
            DigitSum += Convert.ToInt16(TmpI % 10);
            DigitProduct *= Convert.ToInt16(TmpI % 10);
            TmpI /= 10;
        }
        if (DigitSum == DigitProduct) return true;
          else return false;
}
static void Seminar_7_Task_D02_FillArray(int[,] Mas) {
          // Задача D02. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = RundNum.Next(1123,1126);
}
static void Seminar_7_Task_D02_PrintArray(int[,] Mas) {
          // Задача D02. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}
static void Seminar_7_Task_D01() {
          // Задача D01: Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. 
          // Выполните умножение матриц.
    Random RundNum = new Random();
    int RowsA = RundNum.Next(3, 5);
    int RowsB = RundNum.Next(3, 5);
    int[,] MasA = new int [RowsA,RowsB];
    int[,] MasB = new int [RowsB,RowsA];
    int[,] MasProduct = new int [Math.Max(RowsA,RowsB),Math.Max(RowsA,RowsB)];

    Seminar_7_Task_D01_FillArray(MasA);
    Seminar_7_Task_D01_FillArray(MasB);
    Console.WriteLine("Массив А:");
    Seminar_7_Task_D01_PrintArray(MasA);
    Console.WriteLine("Массив B:");
    Seminar_7_Task_D01_PrintArray(MasB);
    if (RowsA >= RowsB) { 
        Seminar_7_Task_D01_ArrayMultiplication(MasA, MasB, MasProduct);
        Console.WriteLine("Произведение массивов А и B:");
    } else { 
          Seminar_7_Task_D01_ArrayMultiplication(MasB, MasA, MasProduct);
          Console.WriteLine("Возможно только произведение массивов B и A:");
      }
    Seminar_7_Task_D01_PrintArray(MasProduct);

    Console.WriteLine("- - - - - - - Задача D01 успешно выполнена! - - - - - - -\n");
}
static void Seminar_7_Task_D01_ArrayMultiplication(int[,] Mas1, int[,] Mas2, int[,] MasProduct) {
          // Задача D01. Подпрограмма перемножения массивов
    int MasProductCell;

    for(int i=0; i<MasProduct.GetLength(0); i++)
        for(int j=0; j<MasProduct.GetLength(1); j++) {
            MasProductCell = 0;
            for(int k=0; k<Mas1.GetLength(1); k++) MasProductCell += Mas1[i,k] * Mas2[k,j];
            MasProduct[i,j] = MasProductCell;    
        }
}
static void Seminar_7_Task_D01_FillArray(int[,] Mas) {
          // Задача D01. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = RundNum.Next(-9,10);
}
static void Seminar_7_Task_D01_PrintArray(int[,] Mas) {
          // Задача D01. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}
static void Seminar_7_Task_52() {
          // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Random RundNum = new Random();
    int M = RundNum.Next(4, 8);
    int N = RundNum.Next(4, 8);
    int[,] Mas = new int [M,N];

    Seminar_7_Task_52_FillArray(Mas);
    Seminar_7_Task_52_PrintArray(Mas);
    Console.Write($"Среднее арифметическое столбцов: ");
    for(int j=0; j<N; j++) Console.Write(Seminar_7_Task_52_ArrayColumnAvg(Mas,j) + ", ");
    Console.WriteLine();

    Console.WriteLine("- - - - - - - Задача 52 успешно выполнена! - - - - - - -\n");
}
static double Seminar_7_Task_52_ArrayColumnAvg(int[,] Mas, int j) {
          // Задача 52. Подпрограмма расчета среднего арифметического в заданном столбцее массива
    int Rows = Mas.GetLength(0);
    double ColumnSum = 0;

    for(int i=0; i<Rows; i++) 
        ColumnSum += Mas[i,j];    
    return Math.Round(Convert.ToDouble(ColumnSum)/Rows,1);
}
static void Seminar_7_Task_52_FillArray(int[,] Mas) {
          // Задача 52. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = RundNum.Next(-100,101);
}
static void Seminar_7_Task_52_PrintArray(int[,] Mas) {
          // Задача 52. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}
static void Seminar_7_Task_50() {
          // Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
          // и возвращает значение этого элемента или же указание, что такого элемента нет.
    Random RundNum = new Random();
    int M = RundNum.Next(4, 8);
    int N = RundNum.Next(4, 8);
    int[,] Mas = new int [M,N];
    int Row = RundNum.Next(1, 11);
    int Column = RundNum.Next(1, 11);

    Seminar_7_Task_50_FillArray(Mas);
    Seminar_7_Task_50_PrintArray(Mas);
    if ((Row <= M) & (Column <= N)) Console.WriteLine($"Элемент массива ({Row},{Column}): {Mas[Row-1, Column-1]}.");
      else Console.WriteLine($"Массив не включает в себя элемент ({Row},{Column}).");

    Console.WriteLine("- - - - - - - Задача 50 успешно выполнена! - - - - - - -\n");
}
static void Seminar_7_Task_50_FillArray(int[,] Mas) {
          // Задача 50. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = RundNum.Next(-100,101);
}
static void Seminar_7_Task_50_PrintArray(int[,] Mas) {
          // Задача 50. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}
static void Seminar_7_Task_47() {
          // Задача 47: Задайте двумерный массив размером M×N, заполненный случайными вещественными числами, округлёнными до одного знака.
    Random RundNum = new Random();
    int M = RundNum.Next(4, 8);
    int N = RundNum.Next(4, 8);
    double[,] Mas = new double [M,N];
    
    Seminar_7_Task_47_FillArray(Mas);
    Seminar_7_Task_47_PrintArray(Mas);

    Console.WriteLine("- - - - - - - Задача 47 успешно выполнена! - - - - - - -\n");
}
static void Seminar_7_Task_47_FillArray(double[,] Mas) {
          // Задача 47. Подпрограмма заполнения массива
    Random RundNum = new Random();
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) Mas[i,j] = Convert.ToDouble(RundNum.Next(-100,101))/10;
}
static void Seminar_7_Task_47_PrintArray(double[,] Mas) {
          // Задача 47. Подпрограмма печати массива
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}

/*          // Практическое задание к семинарам, урок 6 (03.10.22)
Seminar_6_Task_D03();
// Seminar_6_Task_D02();
// Seminar_6_Task_D01();
// Seminar_6_Task_43();
// Seminar_6_Task_41();

static void Seminar_6_Task_D03() {
          // Задача D03: Дано число N. Используя только операцию деления и рекурсию, определите, что оно является степенью числа 3.
    Random RundNum = new Random();
    int N = RundNum.Next(1, 33);
    int Basis = 3;

    if (Seminar_6_Task_D03_Division(N, Basis)) Console.WriteLine($"{N} является степенью числа {Basis}.");
      else Console.WriteLine($"{N} не является степенью числа {Basis}.");

    Console.WriteLine("- - - - - - - Задача D03 успешно выполнена! - - - - - - -\n");
}
static bool Seminar_6_Task_D03_Division(int Num, int Basis) {
          // Задача D03. Подпрограмма деления.
    if ((Num % Basis) !=0) return false;
    if (Num == Basis ) return true; 
    Num /= Basis;    
    return Seminar_6_Task_D03_Division(Num, Basis);
}
static void Seminar_6_Task_D02() {
          // Задача D02: На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
          // Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
    string Phrase = "<Без труда не выловишь и рыбку из пруда.";
    char[] Chars = {'а', 'е', 'ё', 'и','о','у','ы','э','ю','я'};

    Console.WriteLine($"В поговорке {Seminar_6_Task_D02_VowelLettres(Phrase, Chars, 0, 0)} гласных букв.");

    Console.WriteLine("- - - - - - - Задача D02 успешно выполнена! - - - - - - -\n");
}
static int Seminar_6_Task_D02_VowelLettres(string Text, char[] VowelChars, int Count, int Index) {
          // Задача D02. Подпрограмма поиска буквы из алфавита в тексте.
    if (Index == Text.Length) return Count;
    bool contain = VowelChars.Contains(Text[Index]);
    if (contain) Count++;
    Index++;
    return Seminar_6_Task_D02_VowelLettres(Text, VowelChars, Count, Index);
}
static void Seminar_6_Task_D01() {
          // Задача D01: Написать перевод десятичного числа в двоичное, используя рекурсию.
    Random RundNum = new Random();
    int Num10 = RundNum.Next(0, 10001);

    Console.Write($"{Num10} в двоичной системе счисления: ");
    Seminar_5_Task_D01_Convert_10_to_2(Num10, 0, 0);

    Console.WriteLine("- - - - - - - Задача D01 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_D01_Convert_10_to_2(int Num, double Result=0, double i =0) {
          // Задача D01. Рекурсивная подпрограмма перевода десятичного числа в двоичное.
    if(Num == 0) {
        Console.WriteLine(Result);
        return;
    }
    Result += (Num % 2)*Math.Pow(10,i);
    Num /= 2;
    i += 1;
    Seminar_5_Task_D01_Convert_10_to_2(Num, Result, i);
}
static void Seminar_6_Task_43() {
          // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
          // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
          // значения b1, k1, b2 и k2 задаются пользователем: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).
    Random RundNum = new Random();
    int k1 = RundNum.Next(-10, 11);
    int b1 = RundNum.Next(-10, 11);
    int k2 = RundNum.Next(-10, 11);
    int b2 = RundNum.Next(-10, 11);
    double CrossX;
    double CrossY;

    CrossX = Math.Round(Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2),2);
    CrossY = Math.Round(k1 * CrossX + b1,2);
    Console.WriteLine($"({CrossX}, {CrossY}) - точка пересечения прямых, выраженных уравнениями: у={k1}*x+{b1} и у={k2}*x+{b2}");

    Console.WriteLine("- - - - - - - Задача 43 успешно выполнена! - - - - - - -\n");
}
static void Seminar_6_Task_41() {
          // Задача 4: Пользователь вводит с клавиатуры M чисел.
          // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    int M = 5;
    int NegativeNums = 0;
    Console.WriteLine($"Введите {M} чисел:");
    for(int i=1; i<=M; i++) {
        Console.Write($"({i}):");
        if (Convert.ToInt16(Console.ReadLine()) < 0) NegativeNums++;
    }
    Console.WriteLine($"Вы ввели {NegativeNums} отрицательных чисел.");

    Console.WriteLine("- - - - - - - Задача D41 успешно выполнена! - - - - - - -\n");
}
*/
/*          // Практическое задание к семинарам, урок 5 (29.09.22)
// Seminar_5_Task_D03();
// Seminar_5_Task_D02();
// Seminar_5_Task_D01();
// Seminar_5_Task_38();
// Seminar_5_Task_36();
// Seminar_5_Task_34();

static void Seminar_5_Task_D03() {
          // Задача D03: Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений.
          // Подсчитайте их количество.
    int DigitSum = 0;
    int DigitProduct = 1;
    long TmpI;
    int Result = 0;

    for(int i=1; i<=1000000; i++) {
        TmpI = i;  
        while(TmpI > 0) {
            DigitSum += Convert.ToInt16(TmpI % 10);
            DigitProduct *= Convert.ToInt16(TmpI % 10);
            TmpI /= 10;
        }
        if  (DigitSum*3 == DigitProduct) {
            Result++;
            Console.WriteLine(i);
        }
        DigitSum = 0;
        DigitProduct = 1;
    }
    Console.WriteLine($"Среди натуральных до 1000000 есть {Result} чисел, у которых сумма цифр в три раза меньше их произведения.\n");

    Console.WriteLine("- - - - - - - Задача D03 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_D02() {
          // Задача D02: На вход подаются два числа случайной длины.
          // Найдите произведение каждого разряда первого числа на каждый разряд второго.
          // Ответ запишите в массив: 24, 132 -> {2, 6, 4, 4, 12, 8}.
    Random RundNum = new Random();
    int Num1 = RundNum.Next(1,100000);
    int Num2 = RundNum.Next(1,100000);
    int TmpNum1 = Num1;
    int TmpNum2 = Num2;
    int MasSize = Convert.ToString(Num1).Length * Convert.ToString(Num2).Length;
    int[] Result = new int[MasSize];
    int i = MasSize-1;

    while(TmpNum1 > 0) {
        while(TmpNum2 > 0) {
            Result[i] = (TmpNum1 % 10) * (TmpNum2 % 10);
            TmpNum2 /= 10;
            i--;
        }
        TmpNum2 = Num2;
        TmpNum1 /= 10;
    }
    Console.WriteLine($"Попарные произведения всех разрядов {Num1} и {Num2}:");
    Seminar_5_Task_D02_PrintArray(Result);

    Console.WriteLine("- - - - - - - Задача D02 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_D02_PrintArray(int[] Mas) {
          // Задача D02. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "  ");
    Console.Write("\n");
}
static void Seminar_5_Task_D01() {
          // Задача D01: Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число.
          // Напишите программу, которая определяет, есть ли в массиве последовательность из трёх элементов,
          // совпадающая с введённым числом.
    Random RundNum = new Random();
    int ThreeDigitNum = RundNum.Next(100,1000);
//    int ThreeDigitNum = 678;
    int MasSize = RundNum.Next(10,16);
    int[] Nums = new int[15];
    bool SequenceFound = false;

    Seminar_5_Task_D01_FillArray(Nums);
    Seminar_5_Task_D01_PrintArray(Nums);
    for(int i=0; i<MasSize-2; i++)
        if ((Nums[i]*100 + Nums[i+1]*10 + Nums[i+2]) == ThreeDigitNum) SequenceFound = true;
    if (SequenceFound) Console.WriteLine($"Последовательность {ThreeDigitNum} в массиве присутствует.");
        else Console.WriteLine($"Последовательности {ThreeDigitNum} в массиве нет.");

    Console.WriteLine("- - - - - - - Задача D01 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_D01_FillArray(int[] Mas) {
          // Задача D01. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(0,10);
}
static void Seminar_5_Task_D01_PrintArray(int[] Mas) {
          // Задача D01. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_38() {
          // Задача 38: Задайте массив вещественных чисел.
          // Найдите разницу между максимальным и минимальным элементов массива.
    Random RundNum = new Random();
    int MasSize = RundNum.Next(6,16);
    double[] Nums = new double[MasSize];
    double Tmp;

    Seminar_5_Task_38_FillArray(Nums);
    Seminar_5_Task_38_PrintArray(Nums);
        // Сортировка массива
    for(int i=0; i<MasSize; i++)
        for(int j=0; j < MasSize-1-i; j++)
            if (Nums[j] > Nums[j+1]) {
                Tmp = Nums[j];
                Nums[j] = Nums[j+1];
                Nums[j+1] =Tmp; 
            }
    Seminar_5_Task_38_PrintArray(Nums);
    Console.WriteLine($"Разница максимального и минимального элементов массива: {Nums[MasSize-1] - Nums[0]}.");

    Console.WriteLine("- - - - - - - Задача 38 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_38_FillArray(double[] Mas) {
          // Задача 36. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = Math.Round(Convert.ToDouble(RundNum.Next(-10000,10001))/100,2);
}
static void Seminar_5_Task_38_PrintArray(double[] Mas) {
          // Задача 36. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_36() {
          // Задача 36: Задайте одномерный массив, заполненный случайными числами.
          // Найдите сумму элементов с нечётными индексами.
    Random RundNum = new Random();
    int MasSize = RundNum.Next(6,16);
    int[] Nums = new int[MasSize];
    int NotEvenIndexSum = 0;

    Seminar_5_Task_36_FillArray(Nums);
    Seminar_5_Task_36_PrintArray(Nums);
    for(int i=1; i<MasSize; i=i+2)
        NotEvenIndexSum += Nums[i];
    Console.WriteLine($"Сумма элементов массива с нечетными индексами: {NotEvenIndexSum}.");

    Console.WriteLine("- - - - - - - Задача 36 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_36_FillArray(int[] Mas) {
          // Задача 36. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(-10000,10001);
}
static void Seminar_5_Task_36_PrintArray(int[] Mas) {
          // Задача 36. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_34() {
          // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
          // Напишите программу, которая покажет количество чётных чисел в массиве.
    Random RundNum = new Random();
    int MasSize = RundNum.Next(6,16);
    int[] Nums = new int[MasSize];
    int EvenNumsCount = 0;

    Seminar_5_Task_34_FillArray(Nums);
    Seminar_5_Task_34_PrintArray(Nums);
    for(int i=0; i < MasSize; i++)
        if ((Nums[i] % 2) == 0) EvenNumsCount++;
    Console.WriteLine($"В массиве содержится {EvenNumsCount} четных элементов.");

    Console.WriteLine("- - - - - - - Задача 34 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_34_FillArray(int[] Mas) {
          // Задача 34. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(100,1001);
}
static void Seminar_5_Task_34_PrintArray(int[] Mas) {
          // Задача 34. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
*/
/*          // Практическое задание к семинарам, урок 4 (26.09.22)
// Seminar_4_Task_D03();
// Seminar_4_Task_D02();
// Seminar_4_Task_D01();
// Seminar_4_Task_29();
// Seminar_4_Task_27();
// Seminar_4_Task_25();

static void Seminar_4_Task_D03() {
          // Доп. задача 03: Массив на 100 элементов задаётся случайными числами от 1 до 99.
          // Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.
    int Size = 100;
    int[,] Mas= new int[2, Size];
           // Подготовка массива
    Seminar_4_Task_D03_FillArray(Mas, 0);
    Seminar_4_Task_D03_PrintArray(Mas);
    Console.WriteLine();
           // Сортировка элементов первой строки массива
    int Tmp1, Tmp2;
    for(int i=0; i<Size; i++)
        for(int j=0; j<Size-1-i; j++)
            if (Mas[0,j] > Mas[0,j+1]) {
                Tmp1 = Mas[0,j];
                Mas[0,j] = Mas[0,j+1];
                Mas[0,j+1] = Tmp1;
            }  
           // Подсчет количства элментов в сортированной строке массива и запись результатов во вторую строку
    int Duplicates = 1;
    int k = 0;
    while (k < Size) {
        for(int j=k+1; j<Size; j++)
            if (Mas[0,k] == Mas[0,j]) {
                k++;
                Duplicates++;
            }
        Mas[1,k-Duplicates+1] = Duplicates;
        k++;
        Duplicates = 1;
    }
    Seminar_4_Task_D03_PrintArray(Mas);
    Console.WriteLine();
           // Обратная сортировка массива по второй строке
    for(int i=0; i<Size; i++)
        for(int j=0; j<Size-1-i; j++)
            if (Mas[1,j] < Mas[1,j+1]) {
                Tmp1 = Mas[0,j];
                Mas[0,j] = Mas[0,j+1];
                Mas[0,j+1] = Tmp1;
                Tmp2 = Mas[1,j];
                Mas[1,j] = Mas[1,j+1];
                Mas[1,j+1] = Tmp2;
            }  
    Seminar_4_Task_D03_PrintArray(Mas);
    Console.WriteLine();
          // Вывод самых часто встречающихся элементов
    int MostOftenElements = Mas[1,0];
    k=1;
    while (Mas[1,k] == MostOftenElements) k++;
    Console.WriteLine($"Наиболее часто (по {Mas[1,k-1]}) повторяющиеся элементы:");
    for(int i=0;i<k; i++) Console.Write(Mas[0,i] + " ");
    Console.WriteLine(""); 

    Console.WriteLine("- - - - - - - Задача D03 успешно выполнена! - - - - - - -\n");
}
static void Seminar_4_Task_D03_FillArray(int[,] Mas, int row) {
          // Задача D03. Подпрограмма заполнения указанной строки массива.
    Random RundNum = new Random();
//    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
//    for(int i=0; i<rows; i++) 
    for(int j=0; j<columns; j++) Mas[row,j] = RundNum.Next(1,100);
}
static void Seminar_4_Task_D03_PrintArray(int[,] Mas) {
          // Задача D03. Подпрограмма печати массива.
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) 
            if (Mas[i,j] < 10) Console.Write(Mas[i,j] + "  ");    
              else Console.Write(Mas[i,j] + " ");
        Console.WriteLine(""); 
    }
}
static void Seminar_4_Task_D02() {
          // Доп. задача 02: Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
          // Размер массива должен совпадать с квадратом количества единиц в нём.
    Random RundNum = new Random();
    int Size = RundNum.Next(1,17);
    int[,] Mas= new int[Size, Size];
    
    for(int i=0; i<Size; i++) {
        int Column = RundNum.Next(0,Size);
        Mas[i, Column] = 1;
    }
    Seminar_4_Task_D02_PrintArray(Mas);

    Console.WriteLine("- - - - - - - Задача D02 успешно выполнена! - - - - - - -\n");
}
static void Seminar_4_Task_D02_PrintArray(int[,] Mas) {
          // Задача D02. Подпрограмма печати массива.
    int rows = Mas.GetLength(0);
    int columns = Mas.GetLength(1);
    for(int i=0; i<rows; i++) {
        for(int j=0; j<columns; j++) Console.Write(Mas[i,j] + "\t");    
        Console.WriteLine(""); 
    }
}
static void Seminar_4_Task_D01() {
          // Доп. задача 01: На вход подаётся натуральное десятичное число.
          // Проверьте, является ли оно палиндромом в двоичной записи.
    Random RundNum = new Random();
    int Num10 = RundNum.Next(1,100001);
    long Num2 = Seminar_4_Task_D01_Convert_10_to_2(Num10);
    Console.WriteLine($"{Num10} в двоичном коде: {Num2}.");
    bool Num10_Polyndrom = Seminar_4_Task_D01_PalindromityCheck(Num10);
    bool Num2_Polyndrom = Seminar_4_Task_D01_PalindromityCheck(Num2);
    if (Num10_Polyndrom & Num2_Polyndrom) Console.WriteLine($"{Num10} является палиндромом и в десятичном и в двоичном кодах ({Num2}).");
      else if (Num10_Polyndrom)  Console.WriteLine($"{Num10} является палиндромом только в десятичном коде.");
             else if (Num10_Polyndrom) Console.WriteLine($"{Num10} является палиндромом только в двоичном коде ({Num2}).");
                    else Console.WriteLine($"{Num10} не является палиндромом ни в десятичном ни в двоичном кодах ({Num2}).");

    Console.WriteLine("- - - - - - - Задача D01 успешно выполнена! - - - - - - -\n");
}
static bool Seminar_4_Task_D01_PalindromityCheck(long Num) {
          // Задача D01. Подпрограмма проверки числа на палиндромность (например, 12321).
    string NumStr = Convert.ToString(Num);
          // Первоначально предполагаем, что число является палиндромом, пока не найдем исключение
    bool Palindromity = true;
    for(int i=0; i < NumStr.Length/2; i++)
        if (NumStr[i] != NumStr[NumStr.Length-1-i]) return false;
    return Palindromity;
} 
static long Seminar_4_Task_D01_Convert_10_to_2(int Num10) {
          // Задача D01. Подпрограмма перевода десятичного числа в двоичное.
    double Num2 = 0;
    double i = 0;
    while (Num10 > 0) {
        Num2 = (Num10 % 2)*Math.Pow(10,i) + Num2;
        Num10 /= 2;
        i += 1;     
    }
    return Convert.ToInt64(Num2);
} 
static void Seminar_4_Task_29() {
          // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и
          // выводит отсортированный по модулю массив.
    Random RundNum = new Random();
    int MasSize = RundNum.Next(6,16);
    int[] Nums = new int[MasSize];
    int Tmp;

    Seminar_4_Task_29_FillArray(Nums);
    Seminar_4_Task_29_PrintArray(Nums);
    for(int i=0; i < MasSize; i++)
        for(int j=0; j < MasSize-1-i; j++)
            if (Math.Abs(Nums[j]) > Math.Abs(Nums[j+1])) {
                Tmp = Nums[j];
                Nums[j] = Nums[j+1];
                Nums[j+1] =Tmp; 
            }
    Seminar_4_Task_29_PrintArray(Nums);

    Console.WriteLine("- - - - - - - Задача 29 успешно выполнена! - - - - - - -\n");
}
static void Seminar_4_Task_29_FillArray(int[] Mas) {
          // Задача 29. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(-100,100);
}
static void Seminar_4_Task_29_PrintArray(int[] Mas) {
          // Задача 29. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_4_Task_27() {
          // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//    Console.WriteLine("Введите целое число:");
//    int Num = Convert.ToInt32(Console.ReadLine());
    Random RundNum = new Random();
    int Num = RundNum.Next(-1000000, 1000001);

    int AbsNum = Math.Abs(Num);
    int DigitsSum = 0;
    while (AbsNum > 0) {
        DigitsSum += AbsNum % 10;
        AbsNum = AbsNum / 10;
    }
    Console.WriteLine($"Сумма цифр числа {Num} равна: {DigitsSum}.");

    Console.WriteLine("- - - - - - - Задача 27 успешно выполнена! - - - - - - -\n");
}
static void Seminar_4_Task_25() {
          // Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два
          // натуральных числа (A и B) и возводит число A в степень B.
//    Console.WriteLine("Введите натуральное число до 100:");
//    int Num = Convert.ToInt16(Console.ReadLine());
//    Console.WriteLine("Введите натуральное число до 10 (показатель степени):");
//    int Exponent = Convert.ToInt16(Console.ReadLine());
    Random RundNum = new Random();
    int Num = RundNum.Next(1, 101);
    int Exponent = RundNum.Next(1, 11);
    
    double ExponentiatedNum = 1;
    for(int i=1; i <= Exponent; i++) ExponentiatedNum *= Num;
    Console.WriteLine($"Число {Num} в степени {Exponent} равно: {ExponentiatedNum}.");

    Console.WriteLine("- - - - - - - Задача 25 успешно выполнена! - - - - - - -\n");
}
*/
/*         // Практическое задание к семинарам, урок 3 (22.09.22)
// Seminar_3_Task_DS02_03();
// Seminar_3_Task_DS01();
// Seminar_3_Task_D04();
// Seminar_3_Task_D03();
// Seminar_3_Task_D02();
// Seminar_3_Task_D01();
// Seminar_3_Task_23();
// Seminar_3_Task_21();
// Seminar_3_Task_19();

static void Seminar_3_Task_DS02_03() {
          // Задачи DS02_03. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?
          // Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).
    double K1, K2, B1, B2, CrossX, CrossY;
    Random RundNum = new Random();
    double Ax = RundNum.Next(-100, 101);
    double Ay = RundNum.Next(-100, 101);
    double Bx = RundNum.Next(-100, 101);
    double By = RundNum.Next(-100, 101);
    double Cx = RundNum.Next(-100, 101);
    double Cy = RundNum.Next(-100, 101);
    double Dx = RundNum.Next(-100, 101);
    double Dy = RundNum.Next(-100, 101);

          // Получение уравнений векторов
    K1 = (Ay - By) / (Ax - Bx);
    B1 = By - K1 * Bx;
    K2 = (Cy - Dy) / (Cx - Dx);
    B2 = Dy - K2 * Dx;
    Console.WriteLine($"Точки первого вектора: A({Ax}, {Ay}), B({Bx}, {By})");
    Console.WriteLine($"Уравнение прямой, содержащей первый вектор: Y = {K1}*X + {B1}");
    Console.WriteLine($"Точки второго вектора: C({Cx}, {Cy}), D({Dx}, {Dy})");
    Console.WriteLine($"Уравнение прямой, содержащей второй вектор: Y = {K2}*X + {B2}");
          // Нахождение точки пересечения прямых, пересечения векторов и четверти, в которой находится точка пересечения
    if (K1 != K2) {
        Console.WriteLine($"Прямые, содержащие векторы AB и CD, пересекаются.");
        CrossX = (B2 - B1) / (K1 - K2);
        Console.WriteLine($"Точка пересечения по оси абсцисс: {CrossX}");
          // Опредение принадлежности векторам точки пересечения прямых
        if (((CrossX < Math.Max(Ax, Bx)) & (CrossX > Math.Min(Ax, Bx))) & ((CrossX < Math.Max(Cx, Dx)) & (CrossX > Math.Min(Cx, Dx)))) {   
            CrossY = K1 * CrossX + B1;
            Console.WriteLine($"Векторы AB и СВ пересекаются в точке: E({CrossX}, {CrossY}).");
            if ((CrossX > 0) & (CrossY > 0)) Console.WriteLine("Точка пересечения находится в четверти 1.");
              else if ((CrossX < 0) & (CrossY > 0)) Console.WriteLine("Точка пересечения находится в четверти 2.");
                     else if ((CrossX < 0) & (CrossY < 0)) Console.WriteLine("Точка пересечения находится в четверти 3.");
                            else if ((CrossX > 0) & (CrossY < 0)) Console.WriteLine("Точка пересечения находится в четверти 4.");
                                   else Console.WriteLine("Точка пересечения находится находится на одной из осей координат.");
        } 
          else Console.WriteLine($"Векторы AB и СВ не пересекаются.");
    } 
      else Console.WriteLine($"Прямые, содержащие векторы AB и CD, не пересекаются.");
    Console.WriteLine("- - - - - - - Задачи DS02_03 успешно выполнены! - - - - - - -\n");
}
static void Seminar_3_Task_DS01() {
          // Задача DS01: На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти.
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
*/
/*
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
*/
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