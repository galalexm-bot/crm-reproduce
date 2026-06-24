using System;
using System.IO;
using System.Text;

namespace Nemerle;

public static class IO
{
	public class InvalidInput : Exception
	{
	}

	public static void ConsumeWhiteSpace(TextReader input)
	{
		int num = 0;
		while (true)
		{
			num = input.Peek();
			if (num >= 0 && char.IsWhiteSpace(Convert.ToChar(num)))
			{
				num = input.Read();
				continue;
			}
			break;
		}
	}

	public static string ReadIntDigits(TextReader input)
	{
		int num = input.Read();
		if (num >= 0)
		{
			char c = Convert.ToChar(num);
			if (char.IsDigit(c) || c == '-' || c == '+')
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder.Append(c);
				while (true)
				{
					num = input.Peek();
					if (num < 0 || !char.IsDigit(Convert.ToChar(num)))
					{
						break;
					}
					stringBuilder2 = stringBuilder.Append(Convert.ToChar(input.Read()));
				}
				return stringBuilder.ToString();
			}
			throw new InvalidInput();
		}
		throw new InvalidInput();
	}

	public static string ReadString(TextReader input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			int num = input.Peek();
			if (num < 0 || char.IsWhiteSpace(Convert.ToChar(num)))
			{
				break;
			}
			StringBuilder stringBuilder2 = stringBuilder.Append(Convert.ToChar(input.Read()));
		}
		return stringBuilder.ToString();
	}

	public static int ReadChar(TextReader input)
	{
		int num = input.Read();
		if (num >= 0)
		{
			return num;
		}
		throw new InvalidInput();
	}

	public static void CheckInput(string str, TextReader input)
	{
		int num = 0;
		int length = str.Length;
		num = 0;
		checked
		{
			while (num < length)
			{
				if (char.IsWhiteSpace(str[num]))
				{
					ConsumeWhiteSpace(input);
					for (; num < length && char.IsWhiteSpace(str[num]); num++)
					{
					}
					continue;
				}
				int num2 = input.Read();
				if (num2 < 0 || Convert.ToChar(num2) != str[num])
				{
					throw new InvalidInput();
				}
				num++;
			}
		}
	}
}
