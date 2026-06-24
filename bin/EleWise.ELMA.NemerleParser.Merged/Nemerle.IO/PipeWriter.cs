using System;
using System.IO;
using System.Text;
using Nemerle.Builtins;

namespace Nemerle.IO;

public class PipeWriter : TextWriter
{
	private readonly TextWriter output_writer;

	private readonly Function<string, string> filter;

	private readonly StringBuilder line = new StringBuilder();

	public override Encoding Encoding => output_writer.Encoding;

	public PipeWriter(TextWriter output_writer, Function<string, string> filter)
	{
		this.filter = filter;
		this.output_writer = output_writer;
	}

	private void flush_line()
	{
		string value = filter.apply(line.ToString());
		line.Length = 0;
		output_writer.Write(value);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (line.Length > 0)
		{
			flush_line();
		}
		((IDisposable)output_writer).Dispose();
	}

	public override void Flush()
	{
		output_writer.Flush();
	}

	public override void Write(char ch)
	{
		StringBuilder stringBuilder = line.Append(ch);
		if (ch == '\n')
		{
			flush_line();
		}
	}
}
