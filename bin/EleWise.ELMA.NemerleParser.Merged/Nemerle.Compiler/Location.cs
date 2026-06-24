using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[DebuggerDisplay("{File + \":\" + Line + \":\" + Column + \":\" + EndLine + \":\" + EndColumn + (IsGeneratedOrEmpty ? \"-gen\" : \"\")}")]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
public struct Location : IComparable<Location>, IEquatable<Location>
{
	private sealed class _N__N_lambda__21860__21867 : Function<Location, Location, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__21860__21867 Instance = new _N__N_lambda__21860__21867();

		[SpecialName]
		public sealed override bool apply(Location x, Location y)
		{
			return x.CompareTo(y) > 0;
		}
	}

	private sealed class _N__N_lambda__21885__21892<T> : Function<T, T, bool> where T : Located
	{
		[SpecialName]
		public static readonly _N__N_lambda__21885__21892<T> Instance = new _N__N_lambda__21885__21892<T>();

		[SpecialName]
		public sealed override bool apply(T x, T y)
		{
			return x.Location.CompareTo(y.Location) > 0;
		}
	}

	private sealed class _N_closureOf_IndexOfMostNested2_22099<T>
	{
		internal Converter<T, Location> _N_convert_22104;

		internal _N_closureOf_IndexOfMostNested2_22099()
		{
		}
	}

	private sealed class _N__N_lambda__22085__22106<T> : Function<T, Location>
	{
		[SpecialName]
		private _N_closureOf_IndexOfMostNested2_22099<T> _N_IndexOfMostNested2_closure_22110;

		public _N__N_lambda__22085__22106(_N_closureOf_IndexOfMostNested2_22099<T> _N_IndexOfMostNested2_closure_22110)
		{
			this._N_IndexOfMostNested2_closure_22110 = _N_IndexOfMostNested2_closure_22110;
		}

		[SpecialName]
		public sealed override Location apply(T _N__22084)
		{
			return _N_IndexOfMostNested2_closure_22110._N_convert_22104(_N__22084);
		}
	}

	private sealed class _N_closureOf_IndexOfMostNested_22167<T>
	{
		internal Function<T, Location> _N_convert_22176;

		internal int _N_line_22174;

		internal int _N_col_22172;

		internal _N_closureOf_IndexOfMostNested_22167()
		{
		}
	}

	private sealed class _N__N_lambda__22120__22184<T> : Function<T, Nemerle.Builtins.Tuple<int, int, Location>, Nemerle.Builtins.Tuple<int, int, Location>>
	{
		[SpecialName]
		private _N_closureOf_IndexOfMostNested_22167<T> _N_IndexOfMostNested_closure_22188;

		public _N__N_lambda__22120__22184(_N_closureOf_IndexOfMostNested_22167<T> _N_IndexOfMostNested_closure_22188)
		{
			this._N_IndexOfMostNested_closure_22188 = _N_IndexOfMostNested_closure_22188;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<int, int, Location> apply(T _N__22182, Nemerle.Builtins.Tuple<int, int, Location> _N__22183)
		{
			int field = _N__22183.Field0;
			int field2 = _N__22183.Field1;
			Location field3 = _N__22183.Field2;
			Location field4 = _N_IndexOfMostNested_closure_22188._N_convert_22176.apply(_N__22182);
			return checked((!field4.Contains(_N_IndexOfMostNested_closure_22188._N_line_22174, _N_IndexOfMostNested_closure_22188._N_col_22172) || (field2 >= 0 && !field4.IsNestedIn(field3))) ? new Nemerle.Builtins.Tuple<int, int, Location>(field + 1, field2, field3) : new Nemerle.Builtins.Tuple<int, int, Location>(field + 1, field, field4));
		}
	}

	private static readonly List<bool> _isFileInIndentationSyntax;

	private static readonly List<string> _files;

	private static readonly Hashtable<string, int> _filesMap;

	public static readonly Location Default;

	private const uint AllMasks = 4026531840u;

	private const int FileIndexMask = 268435455;

	private const int FakeSourceMask = 1610612736;

	private const int GeneratedMask = 1073741824;

	private int _fileIndex;

	private readonly int _line;

	private readonly int _column;

	private readonly int _endLine;

	private readonly int _endColumn;

	public bool IsGenerated => (_fileIndex & 0x40000000) != 0;

	public bool IsGeneratedOrEmpty => IsGenerated || _line == 0;

	public bool IsSourceAvailable
	{
		get
		{
			int num = _fileIndex & 0x60000000;
			return (num == 0 || num == 1610612736) && FileIndex > 0 && Line > 0;
		}
	}

	public bool IsSourceFileAvailable => FileIndex != 0 && Line > 0 && System.IO.File.Exists(File);

	public int FileIndex
	{
		[DebuggerNonUserCode]
		get
		{
			return _fileIndex & 0xFFFFFFF;
		}
	}

	public int Column => _column;

	public int EndColumn => _endColumn;

	public TextPoint Begin => new TextPoint(Line, Column);

	public TextPoint End => new TextPoint(EndLine, EndColumn);

	public string File
	{
		get
		{
			string text = _files[FileIndex];
			if (!(text != null))
			{
				throw new AssertionException("ncc\\parsing\\AST.n", 290, "value != null", "The ``Ensures'' contract of method `get_File' has been violated.".ToString());
			}
			return text;
		}
	}

	public bool IsEmpty => EndLine == 0 || EndLine < Line || (EndLine == Line && EndColumn <= Column);

	public int Line
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _line;
		}
	}

	public int EndLine
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _endLine;
		}
	}

	static Location()
	{
		_isFileInIndentationSyntax = new List<bool>();
		_files = new List<string>();
		_filesMap = new Hashtable<string, int>();
		Default = new Location(0, 0, 0, 0, 0);
		if (AddFile("") != 0)
		{
			throw new AssertionException("ncc\\parsing\\AST.n", 83, "index == 0", "");
		}
	}

	public static int GetIndexArrayLength()
	{
		return _files.Count;
	}

	public static void SetIndentationSyntaxForFile(int fileIndex, bool isIndntSyntax)
	{
		lock (_isFileInIndentationSyntax)
		{
			_isFileInIndentationSyntax[fileIndex] = isIndntSyntax;
		}
	}

	public Location(int fileIndex, int line, int col)
		: this(fileIndex, line, col, line, col)
	{
	}

	public Location(int fileIndex, TextPoint begin)
		: this(fileIndex, begin.Line, begin.Column, begin.Line, begin.Column)
	{
	}

	public Location(string fileName, int line, int col, int endLine, int endCol)
		: this(GetFileIndex(fileName), line, col, endLine, endCol)
	{
	}

	public Location(string fileName, TextPoint begin, TextPoint end)
		: this(fileName, begin.Line, begin.Column, end.Line, end.Column)
	{
	}

	public Location(int fileIndex, int line, int col, int endLine, int endCol)
	{
		if (fileIndex < 0)
		{
			throw new AssertionException("ncc\\parsing\\AST.n", 120, "fileIndex >= 0", "");
		}
		_fileIndex = fileIndex;
		_line = line;
		_column = col;
		_endLine = endLine;
		_endColumn = endCol;
	}

	public Location(int fileIndex, TextPoint begin, TextPoint end)
		: this(fileIndex, begin.Line, begin.Column, end.Line, end.Column)
	{
	}

	public Location(Location source, int line, int col, int endLine, int endCol)
	{
		_fileIndex = source._fileIndex;
		_line = line;
		_column = col;
		_endLine = endLine;
		_endColumn = endCol;
	}

	public Location(Location source, TextPoint begin, TextPoint end)
		: this(source, begin.Line, begin.Column, end.Line, end.Column)
	{
	}

	public Location(Location source, int line, int col)
		: this(source, line, col, line, col)
	{
	}

	public static bool operator ==(Location x, Location y)
	{
		return x.Equals(y);
	}

	public static bool operator !=(Location x, Location y)
	{
		return !x.Equals(y);
	}

	public static Location operator +(Location x, Location y)
	{
		int fileIndex = x.FileIndex;
		return (fileIndex == y.FileIndex && x.IsGenerated == y.IsGenerated) ? new Location(x._fileIndex | y._fileIndex, x.Line, x.Column, (y.EndLine <= x.EndLine) ? x.EndLine : y.EndLine, (x.EndLine < y.EndLine) ? y.EndColumn : ((x.EndLine > y.EndLine) ? x.EndColumn : ((x.EndColumn >= y.EndColumn) ? x.EndColumn : y.EndColumn))) : ((!(y == Default) && !y.IsGenerated) ? y : x);
	}

	public Location AsGenerated()
	{
		return AsGenerated(_fileIndex, _line, _column, _endLine, _endColumn);
	}

	public static Location AsGenerated(int fileIndex, int line, int col)
	{
		return AsGenerated(fileIndex, line, col, line, col);
	}

	public static Location AsGenerated(string fileName, int line, int col, int endLine, int endCol)
	{
		return AsGenerated(GetFileIndex(fileName), line, col, endLine, endCol);
	}

	public static Location AsGenerated(int fileIndex, int line, int col, int endLine, int endCol)
	{
		return new Location(fileIndex | 0x40000000, line, col, endLine, endCol);
	}

	public void MarkAsGenerated()
	{
		_fileIndex |= 1073741824;
	}

	public void MarkAsFakeSorceAvailable()
	{
		if (_line <= 0 || FileIndex <= 0)
		{
		}
		_fileIndex |= 1610612736;
	}

	public Location AsFakeSorceAvailable()
	{
		return new Location(_fileIndex | 0x60000000, _line, _column, _endLine, _endColumn);
	}

	public static string GetFileName(int index)
	{
		return _files[index];
	}

	public static int AddFile(string name)
	{
		if (_filesMap.Contains(name))
		{
			Message.Error("file '" + Convert.ToString(name) + "' occured twice on the list to compile");
		}
		return GetFileIndex(name);
	}

	public static void RemoveFile(string name)
	{
		if (!((Dictionary<string, int>)_filesMap).Remove(name))
		{
			throw new ArgumentException("file '" + Convert.ToString(name) + "' do not exist");
		}
	}

	public static bool IsFileInIndentationSyntax(int fileIndex)
	{
		return _isFileInIndentationSyntax[fileIndex];
	}

	public static int GetFileIndex(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", "The ``NotNull'' contract of parameter ``name'' has been violated. See ncc\\parsing\\AST.n:248:43:248:47: .");
		}
		int value = 0;
		int result;
		if (_filesMap.TryGetValue(name, out value))
		{
			result = value;
		}
		else
		{
			int num2;
			lock (_filesMap)
			{
				int num;
				if (_filesMap.TryGetValue(name, out value))
				{
					num = value;
				}
				else
				{
					value = _files.Count;
					_files.Add(name);
					_isFileInIndentationSyntax.Add(item: false);
					_filesMap[name] = value;
					num = value;
				}
				num2 = num;
			}
			result = num2;
		}
		return result;
	}

	public int CompareTo(Location x)
	{
		return (FileIndex != x.FileIndex) ? File.CompareTo(x.File) : checked((Line != x.Line) ? (Line - x.Line) : (Column - x.Column));
	}

	public override string ToString()
	{
		return (this == Default) ? "" : ((EndLine != 0) ? (Convert.ToString(File) + ":" + Convert.ToString(Line) + ":" + Convert.ToString(Column) + ":" + Convert.ToString(EndLine) + ":" + Convert.ToString(EndColumn) + ": ") : ((Line == 0) ? (File + ": ") : (Convert.ToString(File) + ":" + Convert.ToString(Line) + ":" + Convert.ToString(Column) + ": ")));
	}

	public bool Equals(Location other)
	{
		return FileIndex == other.FileIndex && _line == other._line && _column == other._column && _endLine == other._endLine && _endColumn == other._endColumn;
	}

	public override int GetHashCode()
	{
		return FileIndex ^ _line ^ _column ^ _endLine ^ _endColumn;
	}

	public Location FromStart()
	{
		return new Location(_fileIndex, Line, Column, Line, Column);
	}

	public Location FromStartAsGenerated()
	{
		return new Location(_fileIndex | 0x40000000, Line, Column, Line, Column);
	}

	public Location FromEnd()
	{
		return new Location(_fileIndex, EndLine, EndColumn, EndLine, EndColumn);
	}

	public Location FromEndAsGenerated()
	{
		return new Location(_fileIndex | 0x40000000, EndLine, EndColumn, EndLine, EndColumn);
	}

	public bool Contains(TextPoint point)
	{
		return Contains(point.Line, point.Column);
	}

	public bool Contains(int testLine, int testCol)
	{
		return testLine >= Line && testLine <= EndLine && ((testLine == Line) ? ((testLine != EndLine) ? (testCol >= Column) : (testCol >= Column && testCol <= EndColumn)) : (testLine != EndLine || testCol <= EndColumn));
	}

	public bool StrictlyContains(Location second)
	{
		return Contains(second) && this != second;
	}

	public bool Contains(Location second)
	{
		return FileIndex == second.FileIndex && Contains(second.Line, second.Column) && Contains(second.EndLine, second.EndColumn);
	}

	public bool StartsBefore(Location second)
	{
		return Line < second.Line || (Line <= second.Line && (Column < second.Column || ((Column <= second.Column) ? true : false)));
	}

	public bool Contains(int testFileIndex, int testLine, int testCol)
	{
		return FileIndex == testFileIndex && Contains(testLine, testCol);
	}

	[Nemerle.Internal.Extension]
	public static Location EnclosingLocation(this list<Location> lst)
	{
		return lst.Head + lst.Last;
	}

	[Nemerle.Internal.Extension]
	public static Location EnclosingLocation<T>(this list<T> lst) where T : Located
	{
		T head = lst.Head;
		Location location = head.Location;
		T last = lst.Last;
		return location + last.Location;
	}

	public Location TrimStart(Location second)
	{
		return TrimStart(second, adjustBegin: true);
	}

	public Location TrimStart(Location l2, bool adjustBegin)
	{
		int num = 0;
		int num2 = 0;
		num = (adjustBegin ? 1 : 0);
		checked
		{
			if (Line < l2.EndLine)
			{
				num2 = l2.EndLine;
				num = l2.EndColumn + num;
			}
			else if (Line > l2.EndLine)
			{
				num2 = Line;
				num = Column;
			}
			else
			{
				num2 = Line;
				num = ((Column >= l2.EndColumn) ? Column : (l2.EndColumn + num));
			}
			return new Location(this, num2, num, EndLine, EndColumn);
		}
	}

	public Location TrimEnd(Location l2)
	{
		int num = 0;
		int num2 = 0;
		if (EndLine > l2.Line)
		{
			num = l2.Line;
			num2 = checked(l2.Column - 1);
		}
		else if (EndLine < l2.Line)
		{
			num = EndLine;
			num2 = l2.EndColumn;
		}
		else
		{
			num = EndLine;
			num2 = ((EndColumn <= l2.Column) ? EndColumn : l2.Column);
		}
		return new Location(this, Line, Column, num, num2);
	}

	public Location Trim(Location l2, int line, int col)
	{
		return (line >= l2.Line && (line != l2.Line || col >= l2.Column)) ? ((line <= l2.EndLine && (line != l2.EndLine || col <= l2.EndColumn)) ? this : TrimStart(l2, adjustBegin: true)) : TrimEnd(l2);
	}

	public Location Combine(Location l2)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Location result;
		if (IsEmpty)
		{
			result = l2;
		}
		else if (l2.IsEmpty)
		{
			result = this;
		}
		else
		{
			if (Line < l2.Line)
			{
				num2 = Line;
				num = Column;
			}
			else if (Line > l2.Line)
			{
				num2 = l2.Line;
				num = l2.Column;
			}
			else
			{
				num2 = Line;
				num = ((Column >= l2.Column) ? l2.Column : Column);
			}
			if (EndLine > l2.EndLine)
			{
				num4 = EndLine;
				num3 = EndColumn;
			}
			else if (EndLine < l2.EndLine)
			{
				num4 = l2.EndLine;
				num3 = l2.EndColumn;
			}
			else
			{
				num4 = EndLine;
				num3 = ((EndColumn <= l2.EndColumn) ? l2.EndColumn : EndColumn);
			}
			result = new Location(this, num2, num, num4, num3);
		}
		return result;
	}

	public Location Combine(Located l2)
	{
		return Combine(l2.Location);
	}

	public bool IsIntersect(Location l2)
	{
		if (FileIndex != l2.FileIndex && FileIndex != 0 && l2.FileIndex != 0)
		{
			throw new AssertionException("ncc\\parsing\\AST.n", 513, "FileIndex == l2.FileIndex || FileIndex == 0 || l2.FileIndex == 0", "The ``Requires'' contract of method `IsIntersect' has been violated.".ToString());
		}
		return !Intersect(l2).IsEmpty;
	}

	public Location Intersect(Location l2)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (FileIndex != l2.FileIndex && FileIndex != 0 && l2.FileIndex != 0)
		{
			throw new AssertionException("ncc\\parsing\\AST.n", 519, "FileIndex == l2.FileIndex || FileIndex == 0 || l2.FileIndex == 0", "The ``Requires'' contract of method `Intersect' has been violated.".ToString());
		}
		if (Line < l2.Line)
		{
			num2 = l2.Line;
			num = l2.Column;
		}
		else if (Line > l2.Line)
		{
			num2 = Line;
			num = Column;
		}
		else
		{
			num2 = Line;
			num = ((Column >= l2.Column) ? Column : l2.Column);
		}
		if (EndLine > l2.EndLine)
		{
			num4 = l2.EndLine;
			num3 = l2.EndColumn;
		}
		else if (EndLine < l2.EndLine)
		{
			num4 = EndLine;
			num3 = EndColumn;
		}
		else
		{
			num4 = EndLine;
			num3 = ((EndColumn <= l2.EndColumn) ? EndColumn : l2.EndColumn);
		}
		return new Location(this, num2, num, num4, num3);
	}

	public bool IsEqualExcludingFile(Location l2)
	{
		return Line == l2.Line && EndLine == l2.EndLine && Column == l2.Column && EndColumn == l2.EndColumn;
	}

	public bool IsNestedIn(Location second)
	{
		return second.StrictlyContains(this);
	}

	[Nemerle.Internal.Extension]
	public static int IndexOfMostNested2<T>(this IList<T> seq, Converter<T, Location> convert, int line, int col)
	{
		_N_closureOf_IndexOfMostNested2_22099<T> n_closureOf_IndexOfMostNested2_ = new _N_closureOf_IndexOfMostNested2_22099<T>();
		n_closureOf_IndexOfMostNested2_._N_convert_22104 = convert;
		Function<T, Location> convert2 = new _N__N_lambda__22085__22106<T>(n_closureOf_IndexOfMostNested2_);
		return IndexOfMostNested(seq, convert2, line, col);
	}

	[Nemerle.Internal.Extension]
	public static int IndexOfMostNested<T>(this IList<T> seq, Function<T, Location> convert, int line, int col)
	{
		_N_closureOf_IndexOfMostNested_22167<T> n_closureOf_IndexOfMostNested_ = new _N_closureOf_IndexOfMostNested_22167<T>();
		n_closureOf_IndexOfMostNested_._N_convert_22176 = convert;
		n_closureOf_IndexOfMostNested_._N_line_22174 = line;
		n_closureOf_IndexOfMostNested_._N_col_22172 = col;
		Nemerle.Builtins.Tuple<int, int, Location> ini = new Nemerle.Builtins.Tuple<int, int, Location>(0, -1, Default);
		Function<T, Nemerle.Builtins.Tuple<int, int, Location>, Nemerle.Builtins.Tuple<int, int, Location>> convert2 = new _N__N_lambda__22120__22184<T>(n_closureOf_IndexOfMostNested_);
		return seq.Fold(ini, convert2).Field1;
	}

	public override bool Equals(object other)
	{
		return other is Location && Equals((Location)other);
	}
}
