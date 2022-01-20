﻿using System;
using System.Linq;
using Stack = FirstTask.Stack;
using Queue = FirstTask.Queue;


var input = Console.ReadLine();
var tokens = Token(input);
Console.WriteLine(tokens.ToString());
var postfixTokens = InfixToPostfix(tokens);
var result = Calculate(postfixTokens);
Console.WriteLine(postfixTokens.ToString());

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
    if (!b.IsEmpty())
        tokenized.Enqueue(combineNumber(b));
    return tokenized;
}

Queue InfixToPostfix(Queue tokenized)
{
    var operatorStack = new Stack();
    var output = new Queue();
    while (!tokenized.IsEmpty())
    {
        var token = tokenized.Dequeue();
        if (int.TryParse(token, out _))
        {
            output.Enqueue(token);
        }
        else if(isOperator(token))
        {
            while (!operatorStack.IsEmpty() && checkPriority(operatorStack.GetLast()) > checkPriority(token) || 
                   checkPriority(operatorStack.GetLast()) == checkPriority(token) && token != "^")
            {
                if (operatorStack.GetLast() != "(")
                    output.Enqueue(operatorStack.Pull());
                else break;
            }
            operatorStack.Push(token);
        }
        else if (token == "(")
        {
            operatorStack.Push(token);
        }
        else if (token == ")")
        {
            while (operatorStack.GetLast() != "(")
            {
                output.Enqueue(operatorStack.Pull());
            }

            operatorStack.Pull();
        }
    }

    while (!operatorStack.IsEmpty())
    {
        output.Enqueue(operatorStack.Pull());
    }
    return output;
}


int Calculate(Queue tokenList)
{
    var result = 0;
    return result;
}


int checkPriority(string operation)
{
    if (operation == "+" || operation == "-")
    {
        return 0;
    }
    else if (operation == "*" || operation == "/")
    {
        return 1;
    }
    else return 2;
}

bool isOperator(String oper)
{
    if (oper == "+" || oper == "-" || oper == "/" || oper == "*" || oper == "^")
        return true;
    return false;
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