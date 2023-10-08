using System;

public class Puzzle3
{
public static int Main(string[] args)
{
    char x = 'X';
    int i = 0;
    Console.Write(true ? x : 0);
    Console.Write(false ? i : x);
    Console.Write(Environment.NewLine);
    return 0;
}
}
