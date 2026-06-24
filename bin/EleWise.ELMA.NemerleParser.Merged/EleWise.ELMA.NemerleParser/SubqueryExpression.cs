using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;

namespace EleWise.ELMA.NemerleParser;

public class SubqueryExpression : Expression
{
	private class _N_Enumerable_16071 : IEnumerator, IDisposable, IEnumerator<TreeItem>, IEnumerable, IEnumerable<TreeItem>
	{
		internal TreeItem _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_16096;

		internal SubqueryExpression _N__N_closurised_this_ptr_16094;

		internal Function<bool> _N__N_wildcard_3441_16092;

		private int _N_this_used;

		public TreeItem Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			try
			{
				bool flag = false;
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_current = _N__N_closurised_this_ptr_16094.Expression;
					_N_state = 1;
					return true;
				}
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<TreeItem> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_16071 n_Enumerable_ = new _N_Enumerable_16071();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<TreeItem>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<TreeItem>)this;
			}
			return (IEnumerator<TreeItem>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_16071 n_Enumerable_ = new _N_Enumerable_16071();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_16071 other)
		{
			_N_this_used = 1;
			_N__N_closurised_this_ptr_16094 = other._N__N_closurised_this_ptr_16094;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	public string SelectProperty { get; set; }

	public override int SelectPropertyStart { get; set; }

	public override int SelectPropertyStop { get; set; }

	public string FromEntity { get; set; }

	public override int FromEntityStart { get; set; }

	public override int FromEntityStop { get; set; }

	public Expression Expression { get; set; }

	public override string ToString()
	{
		return $"<{SelectProperty} FROM {FromEntity}>";
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		_N_Enumerable_16071 n_Enumerable_ = new _N_Enumerable_16071();
		n_Enumerable_._N__N_closurised_this_ptr_16094 = this;
		return n_Enumerable_;
	}
}
