using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;

namespace EleWise.ELMA.NemerleParser;

public class BinaryExpression : Expression
{
	private class _N_Enumerable_7173 : IEnumerator, IDisposable, IEnumerator<TreeItem>, IEnumerable, IEnumerable<TreeItem>
	{
		private bool _N_finally_needed_7206;

		internal TreeItem _N_i_7204;

		internal IEnumerator<TreeItem> _N_enumerator_7202;

		internal TreeItem _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_7198;

		internal BinaryExpression _N__N_closurised_this_ptr_7196;

		internal Function<bool> _N__N_wildcard_3441_7194;

		private int _N_this_used;

		public TreeItem Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_7206)
			{
				((IDisposable)_N_enumerator_7202).Dispose();
			}
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
				switch (_N_state)
				{
				default:
					return false;
				case 0:
					_N_enumerator_7202 = ((TreeItem)_N__N_closurised_this_ptr_7196).GetChildItems().GetEnumerator();
					_N_finally_needed_7206 = true;
					goto case 1;
				case 1:
					if (_N_enumerator_7202.MoveNext())
					{
						TreeItem treeItem = (_N_i_7204 = _N_enumerator_7202.Current);
						_N_current = _N_i_7204;
						_N_state = 1;
						return true;
					}
					_N_finally_needed_7206 = false;
					((IDisposable)_N_enumerator_7202).Dispose();
					if (_N__N_closurised_this_ptr_7196.Operand1 != null)
					{
						_N_current = _N__N_closurised_this_ptr_7196.Operand1;
						_N_state = 2;
						return true;
					}
					goto case 2;
				case 2:
					if (_N__N_closurised_this_ptr_7196.Operand2 != null)
					{
						_N_current = _N__N_closurised_this_ptr_7196.Operand2;
						_N_state = 3;
						return true;
					}
					break;
				case 3:
					break;
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
				_N_Enumerable_7173 n_Enumerable_ = new _N_Enumerable_7173();
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
				_N_Enumerable_7173 n_Enumerable_ = new _N_Enumerable_7173();
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

		private void CopyFrom(_N_Enumerable_7173 other)
		{
			_N_this_used = 1;
			_N__N_closurised_this_ptr_7196 = other._N__N_closurised_this_ptr_7196;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private int? ownStop;

	public override int Start
	{
		get
		{
			return (Operand1 != null) ? Operand1.Start : ((Operand2 != null) ? Operand2.Start : 0);
		}
		set
		{
		}
	}

	public override int Stop
	{
		get
		{
			return ownStop.HasValue ? ownStop.Value : ((Operand2 != null) ? Operand2.Stop : ((Operand1 != null) ? Operand1.Stop : 0));
		}
		set
		{
			ownStop = value;
		}
	}

	public Expression Operand1 { get; set; }

	public BinaryOperator Operator { get; set; }

	public Expression Operand2 { get; set; }

	public override string ToString()
	{
		return string.Concat("<" + Operator, ">");
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		BinaryExpression binaryExpression = (BinaryExpression)base.CreateCopy(parent);
		binaryExpression.Operand1 = (Expression)Operand1.CreateCopy(binaryExpression);
		binaryExpression.Operator = Operator;
		binaryExpression.Operand2 = (Expression)Operand2.CreateCopy(binaryExpression);
		return binaryExpression;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		_N_Enumerable_7173 n_Enumerable_ = new _N_Enumerable_7173();
		n_Enumerable_._N__N_closurised_this_ptr_7196 = this;
		return n_Enumerable_;
	}
}
