using System;
using StackAndQueue.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string testString = "{([])}";
            string testString2 = "(){}";
            string testString3 = "]()";
            string testString4 = "[{]}";
            string testString5 = "asdkljfoiweh";
            string testString6 = "";
            MultiBracketValidate(testString);
            Console.WriteLine(MultiBracketValidate(testString6));
        }

        /// <summary>
        /// Checks if brackets in a string is balanced or not.
        /// Empty string is treated as balanced.
        /// </summary>
        /// <param name="input">String of letters including brackets</param>
        /// <returns>True or False</returns>
        public static bool MultiBracketValidate(string input)
        {
            if (input == "")
            {
                return true;
            }

            if (input[0] == '}' || input[0] == ']' || input[0] == ')')
            {
                return false;
            }

            Stack myStack = new Stack(null);

            for (int i = 0; i < input.Length; i++)
            {
                //Push all opening braces onto stack
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    myStack.Push(new Node(input[i]));
                }
                //If there are closing braces, compare to the opening brace on top of stack.
                else if (input[i] == '}' || input[i] == ']' || input[i] == ')')
                {
                    switch (input[i])
                    {
                        case '}':
                            if ((char)myStack.Pop().Value == '{')
                            {
                                return false;
                            }
                            break;
                        case ']':
                            if ((char)myStack.Pop().Value != '[')
                            {
                                return false;
                            }
                            break;
                        case ')':
                            if ((char)myStack.Pop().Value != '(')
                            {
                                return false;
                            }
                            break;
                    }
                }
            }
            //If every brace has a matching pair, return true. Otherwise, return false.
            return myStack.Size != 1 ? false : true;
        }
    }
}
