using System;

namespace Antlr.Runtime.Misc;

public abstract class LookaheadStream<T> : FastQueue<T> where T : class
{
	private int _currentElementIndex;

	private T _previousElement;

	private T _eof = null;

	private int _lastMarker;

	private int _markDepth;

	public T EndOfFile
	{
		get
		{
			return _eof;
		}
		protected set
		{
			_eof = value;
		}
	}

	public override int Count
	{
		get
		{
			throw new NotSupportedException("streams are of unknown size");
		}
	}

	public virtual int Index => _currentElementIndex;

	public override void Clear()
	{
		base.Clear();
		_currentElementIndex = 0;
		_p = 0;
		_previousElement = null;
	}

	public abstract T NextElement();

	public abstract bool IsEndOfFile(T o);

	public override T Dequeue()
	{
		T result = this[0];
		_p++;
		if (_p == _data.Count && _markDepth == 0)
		{
			Clear();
		}
		return result;
	}

	public virtual void Consume()
	{
		SyncAhead(1);
		_previousElement = Dequeue();
		_currentElementIndex++;
	}

	protected virtual void SyncAhead(int need)
	{
		int num = _p + need - 1 - _data.Count + 1;
		if (num > 0)
		{
			Fill(num);
		}
	}

	public virtual void Fill(int n)
	{
		for (int i = 0; i < n; i++)
		{
			T val = NextElement();
			if (IsEndOfFile(val))
			{
				_eof = val;
			}
			_data.Add(val);
		}
	}

	public virtual T LT(int k)
	{
		if (k == 0)
		{
			return null;
		}
		if (k < 0)
		{
			return LB(-k);
		}
		SyncAhead(k);
		if (_p + k - 1 > _data.Count)
		{
			return _eof;
		}
		return this[k - 1];
	}

	public virtual int Mark()
	{
		_markDepth++;
		_lastMarker = _p;
		return _lastMarker;
	}

	public virtual void Release(int marker)
	{
		_markDepth--;
	}

	public virtual void Rewind(int marker)
	{
		Seek(marker);
		Release(marker);
	}

	public virtual void Rewind()
	{
		Seek(_lastMarker);
	}

	public virtual void Seek(int index)
	{
		_p = index;
	}

	protected virtual T LB(int k)
	{
		if (k == 1)
		{
			return _previousElement;
		}
		throw new ArgumentException("can't look backwards more than one token in this stream");
	}
}
