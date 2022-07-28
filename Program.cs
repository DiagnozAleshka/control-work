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

string [] array = {"hello","world","2","12","(-;","UKRAINE","UK","-1","Nicolas Cage"};