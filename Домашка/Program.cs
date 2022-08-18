// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = { 1, 0, 1, 0, 1, 0, 1, 0};
int n = array.Length;
int index = 0;

while (index < n)
{
Console.WriteLine(array[index]);
index++;
}
