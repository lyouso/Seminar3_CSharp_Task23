Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    int cube_number = i*i*i;
    Console.WriteLine("Куб числа " + i + " --> " + cube_number);
}