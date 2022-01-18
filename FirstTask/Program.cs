using System;
using System.Linq;
using Stack = FirstTask.Stack;
using Queue = FirstTask.Queue;


var input = Console.ReadLine();
var tokens = Token(input);
var postfixTokens = InfixToPostfix(tokens);
var result = Calculate(postfixTokens);
Console.WriteLine(tokens.ToString());




Queue Token(string expression)
{
    var tokenized = new Queue();
    var b = new Queue();
    for (int i = 0; i < expression.Length; i++)
    {
        if (char.IsDigit(expression[i]))
        {
            b.Enqueue(expression[i].ToString());
        }
        else if (expression[i] == ' ')
        {
            if (!b.IsEmpty())
                tokenized.Enqueue(combineNumber(b));
        }
        else if (expression[i] == '(')
        {
            tokenized.Enqueue(expression[i].ToString());
        }
        else
        {
            if (!b.IsEmpty())
                tokenized.Enqueue(combineNumber(b));
            tokenized.Enqueue(expression[i].ToString());
        }
}
    return tokenized;
}

Queue InfixToPostfix(Queue tokenized)
{
    var operatorStack = new Stack();
    var output = new Queue();
    while (!tokenized.IsEmpty())
    {
        
    }
    return null;
}


int Calculate(Queue tokenList)
{
    var result = 0;
    return result;
}


int checkPriority(char operation)
{
    if (operation == '+' || operation == '-')
    {
        return 0;
    }
    else if (operation == '*' || operation == '/')
    {
        return 1;
    }
    else return 2;
}

string combineNumber(Queue queue)
{
    string result = "";
    while (!queue.IsEmpty())
    {
        result = result + queue.Dequeue();
    }
    return result;
}