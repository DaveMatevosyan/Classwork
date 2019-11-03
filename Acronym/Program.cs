using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text");
            while(true) 
            {                
                string input = Console.ReadLine();
                var key = ConsoleKey.Escape;
                if (input == "" || Console.ReadKey().Key == key)
                {
                    break;
                    //return;
                }

                //if (input == "" || input == "exit")
                //{
                //    break;
                //}

                string result = GetAcronym(input);
                Console.WriteLine(result);


                //bool isBalanced = IsBalanced(input);
                //if (isBalanced)
                //{
                //    Console.WriteLine("Brackets are balanced");
                //}
                //else
                //{
                //    Console.WriteLine("wrong input");
                //}
            }
            Console.ReadKey();
            //Console.WriteLine("bye");
        }

        public static string GetAcronym(string input)
        {
            // string output = String.Empty; //"";               
            //string output = input[0].ToString();// Input.Substring(0,1);

            StringBuilder output = new StringBuilder();
            output.Append(input[0].ToString().ToUpper());

            for (int i = 0; i < input.Length - 1; ++i)
            {
                if (input[i] == ' ' && input[i + 1] != ' ')
                {
                    //Output += Input[i + 1];
                    output.Append(input[i + 1].ToString().ToUpper());
                }
            }
            //Console.WriteLine(output); 
            
            input = String.Empty;
            //output = null;

            return output.ToString();
        }

        static bool IsBalanced(string brackets)
        {
            var stack = new Stack<char>();
            foreach (var bracket in brackets)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    stack.Push(bracket);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char currBracket = stack.Pop();                    
                    if (bracket == '}' && currBracket == '{' ||
                        bracket == ')' && currBracket == '(' ||
                        bracket == ']' && currBracket == '[')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }                        
                }
            }
            return stack.Count() == 0;          
        }
    }
}
