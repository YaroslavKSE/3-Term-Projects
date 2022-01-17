using System;
using System.Collections.Generic;
using System.Linq;
using Array = FirstTask.Array;
using Stack = FirstTask.Stack;


var stack = new Stack();
var array = new Array();

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

        if (element.Length > 2)
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
