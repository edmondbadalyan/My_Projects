using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Token
{
    public string Type { get; }
    public string Value { get; }

    public Token(string type, string value)
    {
        Type = type;
        Value = value;
    }
}

class Lexer
{
    private readonly string input;
    private int position;
    private List<Token> tokens;

    public Lexer(string input)
    {
        this.input = input;
        position = 0;
        tokens = new List<Token>();
    }

    public List<Token> Tokenize()
    {
        while (position < input.Length)
        {
            if (char.IsWhiteSpace(input[position]))
            {
                position++;
            }
            else if (char.IsDigit(input[position]))
            {
                Match match = Regex.Match(input.Substring(position), @"\d+");
                tokens.Add(new Token("NUMBER", match.Value));
                position += match.Length;
            } 
            else
            {
                tokens.Add(new Token("OPERATOR", input[position].ToString()));
                position++;
            }
        }

        return tokens;
    }
}

class Program
{
    static void Main()
    {
        string expression = "2 + 3 * 4 - 8 / 2";
        Lexer lexer = new Lexer(expression);
        List<Token> tokens = lexer.Tokenize();

        foreach (Token token in tokens)
        {
            Console.WriteLine($"Type: {token.Type}, Value: {token.Value}");
        }
    }
}
