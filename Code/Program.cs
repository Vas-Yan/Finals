// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
int GetRandom (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue,MaxValue);
}
int [] Array = new int [10];
void FillArray (int [] Array)
{
    for (int i=0; i<Array.Length; i++)
        {
            Array[i] = GetRandom(-10,10);
            Console.Write($"{Array[i]} ; ");
        }
}
int EvenNumbersArray (int [] Array)
{  int CountEven = 0;
   for (int j=0; j<Array.Length; j++)
   {
       if (Array[j]%2==0)
       {
           CountEven++;
           Console.Write($"{Array[j]} ; ");
       }
   } 
   return CountEven;
}
FillArray(Array);
Console.WriteLine();
EvenNumbersArray(Array);