#region Task 1
//while (true)
//{
//    Console.Write("Enter a number between 1 and 100: ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (!(num > 1 && num < 100))
//        Console.WriteLine("Number is not between 1 and 100!");
//    else if (num % 3 == 0 && num % 5 == 0)
//        Console.WriteLine("Fizz Buzz");
//    else if (num % 3 == 0)
//        Console.WriteLine("Fizz");
//    else if (num % 5 == 0)
//        Console.WriteLine("Buzz");
//    else
//        Console.WriteLine(num);
//}
#endregion

#region Task 2
//var evenCount = 0;
//var oddCount = 0;
//var uniqueCount = 0;

//int[] arr = { 22, 55, 44, 85, 47, 24, 66, 54, 84, 55 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0) evenCount++;
//    else oddCount++;
//}
//for (int i = 0;i < arr.Length; i++)
//{
//    bool isUnique = true;
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (i != j &&  arr[i] == arr[j]) {  
//            isUnique = false; 
//            break; 
//        }
//    }
//    if (isUnique) uniqueCount++;
//}

//Console.WriteLine($"Count of even numbers: {evenCount}");
//Console.WriteLine($"Count of odd numbers: {oddCount}");
//Console.WriteLine($"Count of unique numbers: {uniqueCount}");
#endregion

#region Task 3
//int[] arr = { 22, 55, 44, 85, 47, 24, 66, 54, 84, 55 };

//Console.Write("Enter a number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//var count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < num) count++;
//}

//Console.WriteLine($"Count of numbers that is smaller than {num}: {count}");
#endregion

#region Task 4
int[] ints = new int[5];
float[,] floats = new float[3,4];

for (int i = 0; i < ints.Length; i++)
{
    Console.Write($"ints[{i}] = ");
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.Write("ints array = ");
for (int i = 0;i < ints.Length; i++)
{
    Console.Write($"{ints[i]} ");
}
Console.WriteLine();

Random rnd = new Random();
for (int i = 0;i < 3; i++)
{
    for (int j = 0;j < 4; j++)
    {
        floats[i, j] = (float)rnd.NextDouble() * 100;
    }
}

Console.Write("floats array = ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{floats[i, j]} ");
    }
    Console.WriteLine();
} 
#endregion