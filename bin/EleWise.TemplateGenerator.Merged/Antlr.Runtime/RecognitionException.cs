using System;
using System.Runtime.Serialization;
using Antlr.Runtime.Tree;

namespace Antlr.Runtime;

[Serializable]
public class RecognitionException : Exception
{
	private IIntStream _input;

	private int _index;

	private IToken _token;

	private object _node;

	private int _c;

	private int _line;

	private int _charPositionInLine;

	private bool _approximateLineInfo;

	public virtual int UnexpectedType
	{
		get
		{
			if (_input is ITokenStream)
			{
				return _token.Type;
			}
			if (_input is ITreeNodeStream treeNodeStream)
			{
				ITreeAdaptor treeAdaptor = treeNodeStream.TreeAdaptor;
				return treeAdaptor.GetType(_node);
			}
			return _c;
		}
	}

	public bool ApproximateLineInfo
	{
		get
		{
			return _approximateLineInfo;
		}
		protected set
		{
			_approximateLineInfo = value;
		}
	}

	public IIntStream Input
	{
		get
		{
			return _input;
		}
		protected set
		{
			_input = value;
		}
	}

	public IToken Token
	{
		get
		{
			return _token;
		}
		set
		{
			_token = value;
		}
	}

	public object Node
	{
		get
		{
			return _node;
		}
		protected set
		{
			_node = value;
		}
	}

	public int Character
	{
		get
		{
			return _c;
		}
		protected set
		{
			_c = value;
		}
	}

	public int Index
	{
		get
		{
			return _index;
		}
		protected set
		{
			_index = value;
		}
	}

	public int Line
	{
		get
		{
			return _line;
		}
		set
		{
			_line = value;
		}
	}

	public int CharPositionInLine
	{
		get
		{
			return _charPositionInLine;
		}
		set
		{
			_charPositionInLine = value;
		}
	}

	public RecognitionException()
		: this("A recognition error occurred.", null, null)
	{
	}

	public RecognitionException(IIntStream input)
		: this("A recognition error occurred.", input, null)
	{
	}

	public RecognitionException(string message)
		: this(message, null, null)
	{
	}

	public RecognitionException(string message, IIntStream input)
		: this(message, input, null)
	{
	}

	public RecognitionException(string message, Exception innerException)
		: this(message, null, innerException)
	{
	}

	public RecognitionException(string message, IIntStream input, Exception innerException)
		: base(message, innerException)
	{
		_input = input;
		if (input != null)
		{
			_index = input.Index;
			if (input is ITokenStream)
			{
				_token = ((ITokenStream)input).LT(1);
				_line = _token.Line;
				_charPositionInLine = _token.CharPositionInLine;
			}
			if (input is ITreeNodeStream input2)
			{
				ExtractInformationFromTreeNodeStream(input2);
			}
			else if (input is ICharStream)
			{
				_c = input.LA(1);
				_line = ((ICharStream)input).Line;
				_charPositionInLine = ((ICharStream)input).CharPositionInLine;
			}
			else
			{
				_c = input.LA(1);
			}
		}
	}

	protected RecognitionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		_index = info.GetInt32("Index");
		_c = info.GetInt32("C");
		_line = info.GetInt32("Line");
		_charPositionInLine = info.GetInt32("CharPositionInLine");
		_approximateLineInfo = info.GetBoolean("ApproximateLineInfo");
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("Index", _index);
		info.AddValue("C", _c);
		info.AddValue("Line", _line);
		info.AddValue("CharPositionInLine", _charPositionInLine);
		info.AddValue("ApproximateLineInfo", _approximateLineInfo);
	}

	protected virtual void ExtractInformationFromTreeNodeStream(ITreeNodeStream input)
	{
		_node = input.LT(1);
		if (input is ITokenStreamInformation tokenStreamInformation)
		{
			IToken lastToken = tokenStreamInformation.LastToken;
			IToken lastRealToken = tokenStreamInformation.LastRealToken;
			if (lastRealToken != null)
			{
				_token = lastRealToken;
				_line = lastRealToken.Line;
				_charPositionInLine = lastRealToken.CharPositionInLine;
				_approximateLineInfo = lastRealToken.Equals(lastToken);
			}
			return;
		}
		ITreeAdaptor treeAdaptor = input.TreeAdaptor;
		IToken token = treeAdaptor.GetToken(_node);
		if (token != null)
		{
			_token = token;
			if (token.Line <= 0)
			{
				int num = -1;
				object obj = input.LT(num);
				while (obj != null)
				{
					IToken token2 = treeAdaptor.GetToken(obj);
					if (token2 != null && token2.Line > 0)
					{
						_line = token2.Line;
						_charPositionInLine = token2.CharPositionInLine;
						_approximateLineInfo = true;
						break;
					}
					num--;
					try
					{
						obj = input.LT(num);
					}
					catch (ArgumentException)
					{
						obj = null;
					}
				}
			}
			else
			{
				_line = token.Line;
				_charPositionInLine = token.CharPositionInLine;
			}
		}
		else if (_node is ITree)
		{
			_line = ((ITree)_node).Line;
			_charPositionInLine = ((ITree)_node).CharPositionInLine;
			if (_node is CommonTree)
			{
				_token = ((CommonTree)_node).Token;
			}
		}
		else
		{
			int type = treeAdaptor.GetType(_node);
			string text = treeAdaptor.GetText(_node);
			_token = new CommonToken(type, text);
		}
	}
}
