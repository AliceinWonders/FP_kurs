using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;

//Task 1
Action<string> firstTask = message =>
{
    string[] splitMessage = message.Split(new string[] {" "},
        StringSplitOptions.RemoveEmptyEntries);
    foreach (string str in splitMessage)
    {
        Console.WriteLine(str);
    }
};
firstTask (Console.ReadLine());

//Task 2
Action<string> secondTask = message =>
{
    string[] splitMessage = message.Split(new string[] {" "},
        StringSplitOptions.RemoveEmptyEntries);
    foreach (string str in splitMessage)
    {
        Console.WriteLine($"{str}(out of range)");
    }
};
secondTask (Console.ReadLine());

//Task 3
Func<string, int> thirdTask = message =>
{
    int min = message.Split(" ",
        StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray().Min();
    return min;
};
Console.WriteLine(thirdTask(Console.ReadLine()));

//Task 4
Func<int[], string> odd = message =>
{
    string numbers = null;
    for (int i = message.First(); i <= message.Last(); i++)
    {
        if (i % 2 != 0)
        {
            numbers += $"{i} ";
        }
    }

    return numbers;
};
Func<int[], string> even = message =>
{
    string numbers = null;
    for (int i = message.First(); i <= message.Last(); i++)
    {
        if (i % 2 == 0)
        {
            numbers += $"{i} ";
        }
    }

    return numbers;
};
Action<string> fourthTask = message =>
{
    string operations = Console.ReadLine();
    int[] numbers = message.Split(" ",
        StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
    if (operations == "odd")
    {
        Console.WriteLine(odd(numbers));
    }
    else if (operations == "even")
    {
        Console.WriteLine(even(numbers));
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }
};
fourthTask(Console.ReadLine());

//Task 5
Func<int[], int[]> add = message =>
{
    for (int i=0; i < message.Length;i++)
    {
        message[i]++;
    }

    return message;
};
Func<int[], int[]> multiply = message =>
{
    for(int i=0; i < message.Length;i++)
    {
        message[i] = message[i] * 2;
    }

    return message;
};
Func<int[], int[]> subtract = message =>
{
    for(int i=0; i < message.Length;i++)
    {
        message[i]--;
    }

    return message;
};
Action<int[]> print = message =>
{
    Console.WriteLine(String.Join(" ", message));
};
Action<string> fifthTask = message =>
{
    string operations = Console.ReadLine();
    int[] numbers = message.Split(" ",
        StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
    while (operations != "end")
    {
        if (operations == "add")
        {
            add(numbers);
        }
        else if (operations == "multiply")
        {
            multiply(numbers);
        }
        else if (operations == "subtract")
        {
            subtract(numbers);
        }
        else if (operations == "print")
        {
            print(numbers);
        }

        operations = Console.ReadLine();
    }
};
fifthTask(Console.ReadLine());

//Task 6
Action<string> sixthTask = message =>
{
    int a = Convert.ToInt32(Console.ReadLine());
    IEnumerable<int> numbers = message.Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n))
        .Where(n => n % a != 0)
        .ToArray().Reverse();
    Console.WriteLine(String.Join(" ", numbers));
};
sixthTask(Console.ReadLine());

//Task 7
Func<string, string[]> seventhTask = message =>
{
    int a = Convert.ToInt32(Console.ReadLine());
    string[] result = message.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => n).Where(n => n.Length == a).ToArray();
    Console.WriteLine(String.Join(" ", result));
    return result;
};
seventhTask(Console.ReadLine());

//Task 8
int[] numbers = Console.ReadLine().Split(new string[] { " " },
        StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n))
    .ToArray();
Array.Sort(numbers,(x,y) =>
{
    if (x % 2 == 0 && y%2 !=0 )
    {
        return -1;
    }
    else if(x % 2 !=0 && y%2 ==0)
    {
        return 1;
    }
    else
    {
        return x.CompareTo(y);
    }
        
});
Console.WriteLine(String.Join(" ", numbers));