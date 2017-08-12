namespace _07.BalancedParenthesis
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().ToArray();
			Stack<char> stack = new Stack<char>();

			bool result = true;
			for (int i = 0; i < input.Length; i++)
			{
				if (input.Length <=1)
				{
					result = false;
				}
				if (input[i]=='('|| input[i] == '['|| input[i] == '{')
				{
					stack.Push(input[i]);
				}
				else
				{
					if (input[i]==')')
					{
						if (stack.Count ==0)
						{
							result = false;
							break;
						}
						if (stack.Peek() =='(')
						{
							if (stack.Count > 0 )
							{
								stack.Pop();
							}
							else
							{
								result = false;
								break;
							}
						}
						else
						{
							result = false;
							break;
						}
					}
					else if(input[i]==']')
					{
						if (stack.Count == 0)
						{
							result = false;
							break;
						}
						if (stack.Peek()=='[')
						{
							if (stack.Count > 0)
							{
								stack.Pop();
							}
							else
							{
								result = false;
								break;
							}
						}
						else
						{
							result = false;
						}
					}
					else if (input[i]=='}')
					{
						if (stack.Count == 0)
						{
							result = false;
							break;
						}
						if (stack.Peek()=='{')
						{
							if (stack.Count > 0)
							{
								stack.Pop();
							}
							else
							{
								result = false;
								break;
							}
						}
						else
						{
							result = false;
						}
					}
				}
			}
			
			if (!result==true || stack.Count>0)
			{
				Console.WriteLine("NO");
			}
			else
			{
				Console.WriteLine("YES");

			}
		}
	}
}
