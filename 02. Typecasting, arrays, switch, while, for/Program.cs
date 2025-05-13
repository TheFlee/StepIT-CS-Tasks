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
using System;

int[] ints = new int[5];
float[,] floats = new float[3,4];

// Filling ints with user input numbers
for (int i = 0; i < ints.Length; i++)
{
    Console.Write($"ints[{i}] = ");
    ints[i] = Convert.ToInt32(Console.ReadLine());
}

// Filling floats with random float numbers
Random rnd = new Random();
for (int i = 0;i < 3; i++)
{
    for (int j = 0;j < 4; j++)
    {
        floats[i, j] = (float)rnd.NextDouble() * 100;
    }
}

// Print ints in one line
Console.WriteLine();
Console.Write("ints array = ");
for (int i = 0; i < ints.Length; i++)
{
    Console.Write($"{ints[i]} ");
}
Console.WriteLine();

// Print flaots table shaped
Console.WriteLine("floats array: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{floats[i, j]} \t");
    }
    Console.WriteLine();
}

// Print max, min, sum, product of all numbers in ints and floats
int min = ints[0];
int max = 0;
int sum = 0;
int product = 1;

float fmin = floats[0,0];
float fmax = 0;
float fsum = 0;
float fproduct = 1;

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] < min) min = ints[i];
    if (ints[i] > max) max = ints[i];
    sum += ints[i];
    product *= ints[i]; 
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (floats[i, j] < fmin) fmin = floats[i, j];
        if (floats[i, j] > fmax) fmax = floats[i, j];
        fsum += floats[i, j];
        fproduct *= floats[i, j];
    }
}
Console.WriteLine();
Console.WriteLine($"Max value in ints = {max}");
Console.WriteLine($"Min value in ints = {min}");
Console.WriteLine($"Sum of the numbers in ints = {sum}");
Console.WriteLine($"Product of the numbers in ints = {product}");

Console.WriteLine();
Console.WriteLine($"Max value in floats = {fmax}");
Console.WriteLine($"Min value in floats = {fmin}");
Console.WriteLine($"Sum of the numbers in floats = {fsum}");
Console.WriteLine($"Product of the numbers in floats = {fproduct}");

// Print sum of even numbers in ints
int evenSum = 0;
foreach (int num in ints) if (num % 2 == 0) evenSum += num;

Console.WriteLine();
Console.WriteLine($"Sum of even numbers in ints: {evenSum}");

// Print sum of numbers in odd columns
float oddColumnSum = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (j % 2 == 0) oddColumnSum += floats[i, j];
    }
}

Console.WriteLine();
Console.WriteLine($"Sum of numbers in odd columns (floats): {oddColumnSum}");
    
#endregion