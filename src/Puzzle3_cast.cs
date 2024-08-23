using System;

public class Puzzle3_cast
{
public static int Main(string[] args)
{
    char x = 'X';
    int i = 0;
    Console.Write(true ? x : (char)0);
    Console.Write(false ? (char)i : x);
    Console.Write(Environment.NewLine);
    return 0;
}
}
