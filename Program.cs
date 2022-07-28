/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.*/
int arrayLine(string[] array)
{
    int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
    count++;
  }
  return count;
}

string[]FillArray(string[] array, int count)
{
    string[]arrayDuble = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayDuble[arrayDuble.Length - count] = array[i];
            count--;
        }
    }
    return arrayDuble;
}

void PrintArray(string[] array)
{
        for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]} ");
}

string [] array = {"hello","world","2","12","(-;","UKRAINE","UK","-1","Nicolas Cage"};
int x = arrayLine(array);
string[] resultArray = FillArray(array, x);
PrintArray(resultArray);