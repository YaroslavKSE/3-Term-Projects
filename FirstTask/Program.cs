using System;
using System.Collections.Generic;
using System.Linq;
using Array = FirstTask.Array;
using Stack = FirstTask.Stack;


var stack = new Stack();
// stack.Push("a");
// stack.Push("c");
// stack.Push("d");
// stack.Push("e");
// stack.Pop();
// stack.Seek();
var array = new Array();

array.Push(1);
// array.Push(2);
// array.Push(3);
// array.Push(4);
// array.Push(5);
// array.Push(6);
// array.Push(7);
// array.Push(8);
// array.Push(9);
// array.Push(10);
array.Insert(1, 3);
// array.Remove(7);

// Console.WriteLine(stack);
// while (true)
// {
var input = Console.ReadLine();
var tokens = Token(input);
var postfixTokens = InfixToPostfix(tokens);
var result = Calculate(postfixTokens);
// }


List<string> Token(string expression)
{
    List<string> elements = input.Split(' ').ToList();
    foreach (var element in elements)
    {
        if (element.Length == 1)
        {
            stack.Push(element);
        }

        if (element.Length == 2)
        {
            element.Split(new string[] { }, StringSplitOptions.None);
            foreach (var i in element)
            {
                string iString = i.ToString();
                stack.Push(iString);
            }
        }
    }

    return null;
}

List<string> InfixToPostfix(List<string> tokenList)
{
    return null;
}


int Calculate(List<string> tokenList)
{
    return 0;
}
