using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181106.ExceptionHandling
{
    class StackException : Exception
    {
        public String somethinClass;
        public String somethinFunc;
        public String result;

        public StackException(String c, String f, String r)
        {
            somethinClass = c;
            somethinFunc = f;
            result = r;
        }
    }

    class Stack
    {
        // Attributes
        static int MAX = 100;
        /** an array to save stack contents 
         */
        private int[] _s;
        /** the index to point top of stack
         */
        private int _top;
        /** size of the stack
         */
        private int _size;
        // Operations
        /** initialization procedure for new stack
         */
        private void initialize()
        {
            // NOTE: We don't have to do this initialization with Java
            for (int i = 0; i < _size; i++)
            {
                _s[i] = 0;
            }
        }
        /** this function is called for stack overflow exception
         */
        private void overflowError()
        {
            Console.WriteLine("Stack overflow error occurs.");
            Environment.Exit(-1);
        }
        /** this function is called for stack empty exception
         */
        private void emptyError()
        {
            Console.WriteLine("Stack empty error occurs.");
            Environment.Exit(-1);
        }
        /** the constructor for stack object
         */
        public Stack()
            : this(MAX)
        {
        }
        /** the constructor for stack object
         */
        public Stack(int n)
        {
            if (n > MAX)
            {
                Console.WriteLine("Stack size must be less than " + MAX + ".");
                Environment.Exit(-1);
            }
            _s = new int[MAX];
            _size = n;
            _top = -1;
            initialize();
        }
        /**	the function to insert new item on stack
         */
        public void push(int item)
        {
            if (_top >= _size - 1) overflowError();
            _top++;
            _s[_top] = item;
        }
        /** the function to delete an item at the top position of the stack
         */
        public int pop()
        {
            if (_top == -1) throw new StackException("Stack", "pop()", "stack empty");
            int value = _s[_top];
            _top--;
            return (value);
        }
        /** the function to get the top element of the stack
         */
        public int peek()
        {
            if (_top == -1) emptyError();
            return (_s[_top]);
        }
        /** the fuction to clear an exisiting stack
         */
        public void reset()
        {
            _top = -1;
            initialize();
        }
        public bool isEmpty()
        {
            if (_top == -1) return true;
            return false;
        }
    }

    class Tokenizer
    {
        public const int ID_PLUS = 1;
        public const int ID_MINUS = 2;
        public const int ID_MULTIFLY = 3;
        public const int ID_DIVIDE = 4;
        public const int ID_EOD = 5;
        public const int ID_OPERAND = 6;
        public const int ID_EPR = 7;

        private const int MAX = 100;
        private char[] _text;
        private int _pos;
        private int _tokenValue;

        public Tokenizer(String text)
        {
            _text = new char[MAX];

            for (int i = 0; i < text.Length; i++)
            {
                _text[i] = text.ElementAt(i);
            }
            _text[text.Length] = '\0';
            _tokenValue = 0;
            _pos = 0;
        }

        public int getNextToken()
        {
            // ignore blank
            while (_text[_pos] == ' ') { _pos++; }

            if (_text[_pos] == '\0') { return ID_EOD; }
            if (_text[_pos] == '+')
            {
                _pos++;
                return ID_PLUS;
            }
            if (_text[_pos] == '*')
            {
                _pos++;
                return ID_MULTIFLY;
            }
            if (_text[_pos] == '/')
            {
                _pos++;
                return ID_DIVIDE;
            }
            if ((_text[_pos] == '-' && _text[_pos + 1] == ' ') ||
                (_text[_pos] == '-' && _text[_pos + 1] == '\0'))
            {
                _pos++;
                return ID_MINUS;
            }

            String buffer = "";

            if (_text[_pos] == '-')
            {
                buffer = buffer + "-";
                _pos++;
            }

            while (_text[_pos] >= '0' && _text[_pos] <= '9')
            {
                buffer = buffer + _text[_pos];
                _pos++;
            }

            _tokenValue = int.Parse(buffer);

            return ID_OPERAND;
        }
        public int getTokenValue()
        {
            return _tokenValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a postfix expression: (ex) 1 2 3 + +");
            Stack operands = new Stack();
            while (true)
            {
                String aLine;

                aLine = Console.ReadLine();

                Tokenizer t = new Tokenizer(aLine);

                while (true)
                {
                    int value;
                    int tokenID;

                    tokenID = t.getNextToken();
                    value = t.getTokenValue();
                    try
                    {
                        if (tokenID == Tokenizer.ID_OPERAND)
                        {
                            operands.push(value);
                        }
                        else if (tokenID == Tokenizer.ID_PLUS)
                        {
                            int a = operands.pop();
                            int b = operands.pop();
                            int c = b + a;
                            operands.push(c);
                        }
                        else if (tokenID == Tokenizer.ID_MINUS)
                        {
                            int a = operands.pop();
                            int b = operands.pop();
                            int c = b - a;
                            operands.push(c);
                        }
                        else if (tokenID == Tokenizer.ID_MULTIFLY)
                        {
                            int a = operands.pop();
                            int b = operands.pop();
                            int c = b * a;
                            operands.push(c);
                        }
                        else if (tokenID == Tokenizer.ID_DIVIDE)
                        {
                            int a = operands.pop();
                            int b = operands.pop();
                            int c = b / a;
                            operands.push(c);
                        }
                        else if (tokenID == Tokenizer.ID_EOD)
                        {
                            int ans = operands.pop();

                            if (operands.isEmpty())
                            {
                                Console.WriteLine(" = " + ans);
                            }
                            else
                            {
                                Console.WriteLine("incorrect expression!");
                                operands.reset();
                            }
                            break;
                        }
                    } catch (StackException ex) {
                        operands.reset();
                        // Console.WriteLine("Something wrong!\nTry again!");
                        Console.WriteLine("Exception occurs: " + ex.result);
                        Console.WriteLine("Class: " + ex.somethinClass + ", Function: " + ex.somethinFunc);
                        Console.WriteLine("Try again!");
                        break;
                    }
                }
            }
        }
    }
}
