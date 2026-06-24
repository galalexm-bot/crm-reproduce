using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Misc;

namespace Antlr.Runtime.Tree;

[Serializable]
public class CommonTreeNodeStream : LookaheadStream<object>, ITreeNodeStream, IIntStream
{
	public const int DEFAULT_INITIAL_BUFFER_SIZE = 100;

	public const int INITIAL_CALL_STACK_SIZE = 10;

	private object _root;

	protected ITokenStream tokens;

	[NonSerialized]
	private ITreeAdaptor _adaptor;

	private TreeIterator _it;

	private Stack<int> _calls;

	private bool _hasNilRoot;

	private int _level;

	public virtual string SourceName
	{
		get
		{
			if (TokenStream == null)
			{
				return null;
			}
			return TokenStream.SourceName;
		}
	}

	public virtual ITokenStream TokenStream
	{
		get
		{
			return tokens;
		}
		set
		{
			tokens = value;
		}
	}

	public virtual ITreeAdaptor TreeAdaptor
	{
		get
		{
			return _adaptor;
		}
		set
		{
			_adaptor = value;
		}
	}

	public virtual object TreeSource => _root;

	public virtual bool UniqueNavigationNodes
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CommonTreeNodeStream(object tree)
		: this(new CommonTreeAdaptor(), tree)
	{
	}

	public CommonTreeNodeStream(ITreeAdaptor adaptor, object tree)
	{
		_root = tree;
		_adaptor = adaptor;
		_it = new TreeIterator(adaptor, _root);
	}

	public virtual void Reset()
	{
		Clear();
		_it.Reset();
		_hasNilRoot = false;
		_level = 0;
		if (_calls != null)
		{
			_calls.Clear();
		}
	}

	public override object NextElement()
	{
		_it.MoveNext();
		object current = _it.Current;
		if (current == _it.up)
		{
			_level--;
			if (_level == 0 && _hasNilRoot)
			{
				_it.MoveNext();
				return _it.Current;
			}
		}
		else if (current == _it.down)
		{
			_level++;
		}
		if (_level == 0 && TreeAdaptor.IsNil(current))
		{
			_hasNilRoot = true;
			_it.MoveNext();
			current = _it.Current;
			_level++;
			_it.MoveNext();
			current = _it.Current;
		}
		return current;
	}

	public override bool IsEndOfFile(object o)
	{
		return TreeAdaptor.GetType(o) == -1;
	}

	public virtual int LA(int i)
	{
		return TreeAdaptor.GetType(LT(i));
	}

	public virtual void Push(int index)
	{
		if (_calls == null)
		{
			_calls = new Stack<int>();
		}
		_calls.Push(_p);
		Seek(index);
	}

	public virtual int Pop()
	{
		int num = _calls.Pop();
		Seek(num);
		return num;
	}

	public virtual void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t)
	{
		if (parent != null)
		{
			TreeAdaptor.ReplaceChildren(parent, startChildIndex, stopChildIndex, t);
		}
	}

	public virtual string ToString(object start, object stop)
	{
		return "n/a";
	}

	public virtual string ToTokenTypeString()
	{
		Reset();
		StringBuilder stringBuilder = new StringBuilder();
		object t = LT(1);
		for (int type = TreeAdaptor.GetType(t); type != -1; type = TreeAdaptor.GetType(t))
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(type);
			Consume();
			t = LT(1);
		}
		return stringBuilder.ToString();
	}
}
