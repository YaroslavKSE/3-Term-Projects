using System;
using System.Collections.Generic;
using Stack = FirstTask.Stack;


var stack = new Stack();
stack.Push("a");
stack.Push("c");
stack.Push("d");
stack.Push("e");
stack.Pop();
stack.Seek();

Console.WriteLine(stack);
while (true)
{
    var input = Console.ReadLine();
    var tokens = Token(input);
    var postfixTokens = InfixToPostfix(tokens);
    var result = Calculate(postfixTokens);
}



List<string> Token(string expression)
{
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