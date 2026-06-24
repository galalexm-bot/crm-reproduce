namespace Nemerle.Compiler;

public abstract class LexerStringBase : LexerBase
{
	protected string reader;

	protected int pos;

	public LexerStringBase(ManagerClass manager, string code, Location loc)
	{
		int num = 0;
		base._002Ector(manager, loc.File);
		reader = code;
		pos = 0;
		file_idx = loc.FileIndex;
		line = loc.Line;
		col = loc.Column;
		if (line > 0 && col > 0)
		{
			for (num = line; num > 0; num = checked(num - 1))
			{
				_linesLengths.Add(-1);
			}
		}
		else
		{
			if (line != 0 || col != 0)
			{
			}
			_linesLengths = null;
		}
	}

	protected override char peek()
	{
		return (pos < reader.Length) ? reader[pos] : '\0';
	}

	protected override char peek_or_white()
	{
		return (pos >= reader.Length) ? ' ' : reader[pos];
	}

	protected override int get_position()
	{
		return pos;
	}

	protected override char read_from_input()
	{
		int result;
		checked
		{
			if (pos < reader.Length)
			{
				char c = reader[pos];
				pos++;
				result = c;
			}
			else
			{
				result = 0;
			}
		}
		return (char)result;
	}
}
