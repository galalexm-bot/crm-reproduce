using System;
using System.IO;
using System.Text;
using Nemerle.Builtins;

namespace Nemerle.IO;

public class PipeReader : TextReader
{
	private readonly TextReader input_reader;

	private readonly Function<string, string> filter;

	private int input_ptr;

	private string line = "";

	public PipeReader(TextReader input_reader, Function<string, string> filter)
	{
		this.filter = filter;
		this.input_reader = input_reader;
	}

	private void fill_buffer()
	{
		do
		{
			input_ptr = 0;
			string text = input_reader.ReadLine();
			if (text == null)
			{
				line = "";
				break;
			}
			line = filter.apply(text + "\n");
		}
		while (line == "");
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		((IDisposable)input_reader).Dispose();
	}

	public override int Peek()
	{
		if (line.Length <= input_ptr)
		{
			fill_buffer();
		}
		return (line.Length > input_ptr) ? line[input_ptr] : (-1);
	}

	public override int Read()
	{
		int num = Peek();
		checked
		{
			if (num != -1)
			{
				input_ptr++;
			}
			return num;
		}
	}

	public override string ReadToEnd()
	{
		int num = Read();
		object result;
		if (num == -1)
		{
			result = null;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder.Append((char)checked((ushort)num));
			while (true)
			{
				num = Read();
				if (num == -1)
				{
					break;
				}
				stringBuilder2 = stringBuilder.Append((char)checked((ushort)num));
			}
			result = stringBuilder.ToString();
		}
		return (string)result;
	}

	public override string ReadLine()
	{
		int num = Read();
		object result;
		if (num == -1)
		{
			result = null;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder.Append((char)checked((ushort)num));
			while (true)
			{
				num = Read();
				if (num != 13)
				{
					if (num == 10 || num == -1)
					{
						break;
					}
					stringBuilder2 = stringBuilder.Append((char)checked((ushort)num));
				}
			}
			result = stringBuilder.ToString();
		}
		return (string)result;
	}
}
