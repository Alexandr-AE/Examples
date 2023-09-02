Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = a, i = 0;

while (a >= 1)
{
    a = a / 2;
    i++;
}
int[] array = new int[i];
while (i >= 1)
{
    array[i - 1] = n % 2;
    n = n / 2;
    i--;
}
for (i = 0; i < array.Length; i++)
    Console.Write(array[i]);