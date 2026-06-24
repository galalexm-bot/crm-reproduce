using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Peg;

public class SourceSnapshot
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[IgnoreField]
	private Hashtable<int, Nemerle.Builtins.Tuple<int, int>> _N_cache_3774;

	private readonly string originalText;

	private readonly string text;

	private readonly int fileIndex;

	private readonly string fileName;

	private readonly int[] lineIndexes;

	public string OriginalText
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return originalText;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return text;
		}
	}

	public int FileIndex
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return fileIndex;
		}
	}

	public string FileName
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return fileName;
		}
	}

	protected SourceSnapshot(string originalText, string text, int fileIndex, string fileName, int[] lineIndexes)
	{
		this.originalText = originalText;
		this.text = text;
		this.fileName = fileName;
		this.fileIndex = fileIndex;
		this.lineIndexes = lineIndexes;
	}

	public SourceSnapshot([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string text, int fileIndex = 0, string fileName = "")
	{
		if (text == null)
		{
			throw new ArgumentNullException("text", "The ``NotNull'' contract of parameter ``text'' has been violated. See SourceSnapshot.n:28:27:28:31: .");
		}
		this._002Ector(text, text, fileIndex, fileName, MakeLineIndexes(text));
	}

	public int[] GetLinesRelocationTable()
	{
		int[] array = new int[lineIndexes.Length];
		lineIndexes.CopyTo(array, 0);
		return array;
	}

	internal Nemerle.Builtins.Tuple<int, int> PositionToLineColumn(int pos)
	{
		if (_N_cache_3774 == null)
		{
			_N_cache_3774 = new Hashtable<int, Nemerle.Builtins.Tuple<int, int>>();
		}
		Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<int, int>, bool> tuple = _N_cache_3774.TryGetValue(pos);
		checked
		{
			Nemerle.Builtins.Tuple<int, int> result;
			if (tuple.Field1)
			{
				Nemerle.Builtins.Tuple<int, int> field = tuple.Field0;
				result = field;
			}
			else
			{
				int num = Array.BinarySearch(lineIndexes, pos);
				int num2 = num;
				Nemerle.Builtins.Tuple<int, int> tuple2;
				if (num2 < 0)
				{
					num2 = ~num2;
					tuple2 = new Nemerle.Builtins.Tuple<int, int>(num2, pos - lineIndexes[num2 - 1] + 1);
				}
				else
				{
					num2 = num;
					tuple2 = new Nemerle.Builtins.Tuple<int, int>(num2 + 1, pos - lineIndexes[num2] + 1);
				}
				Nemerle.Builtins.Tuple<int, int> field = tuple2;
				_N_cache_3774[pos] = field;
				result = field;
			}
			return result;
		}
	}

	public Location GetSourceLine(int pos)
	{
		Nemerle.Builtins.Tuple<int, int> tuple = PositionToLineColumn(pos);
		int field = tuple.Field0;
		int field2 = tuple.Field1;
		field = ((field != lineIndexes.Length) ? lineIndexes[field] : text.Length);
		return new Location(this, checked(pos - field2 + 1), field);
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "originalText.Length == text.Length@")]
	public SourceSnapshot WithText([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text", "The ``NotNull'' contract of parameter ``text'' has been violated. See SourceSnapshot.n:65:31:65:35: .");
		}
		if (originalText.Length != text.Length)
		{
			throw new AssertionException("SourceSnapshot.n", 66, "originalText.Length == text.Length", "The ``Requires'' contract of method `WithText' has been violated.".ToString());
		}
		return new SourceSnapshot(originalText, text, fileIndex, fileName, lineIndexes);
	}

	public override string ToString()
	{
		return "File index: " + Convert.ToString(fileIndex) + ", File name: " + Convert.ToString(fileName);
	}

	protected static int[] MakeLineIndexes(string text)
	{
		int num = 0;
		List<int> list = new List<int>(text.Length / 25);
		list.Add(0);
		checked
		{
			while (num < text.Length)
			{
				switch (text[num])
				{
				case '\r':
					num++;
					if (num < text.Length && text[num] == '\n')
					{
						num++;
					}
					list.Add(num);
					break;
				case '\n':
				case '\u2028':
				case '\u2029':
					num++;
					list.Add(num);
					break;
				default:
					num++;
					break;
				}
			}
			return list.ToArray();
		}
	}
}
