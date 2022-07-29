Console.WriteLine("Задача 38 ");
Console.WriteLine(".......................................................... ");

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double Min = Int32.MaxValue;
double Max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > Max)
        {
            Max = numbers[z];
        }
    if (numbers[z] < Min)
        {
            Min = numbers[z];
        }
}

Console.WriteLine($"Размер массива состоит из {numbers.Length} чисел. Максимальное значение массива: {Max}; Минимальное значение массива: {Min}");
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {Max - Min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(1,100));
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "; ");
        }
    Console.Write("]");
    Console.WriteLine();
}