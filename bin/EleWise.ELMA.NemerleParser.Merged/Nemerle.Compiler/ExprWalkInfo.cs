using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;

namespace Nemerle.Compiler;

public class ExprWalkInfo : ISupportRelocation
{
	private sealed class _N_closureOf_Walk_89581
	{
		internal PExpr _N_node_89588;

		internal ExprWalkInfo _N__N_closurised_this_ptr_89586;

		internal _N_closureOf_Walk_89581()
		{
		}
	}

	private sealed class _N__N_lambda__89574__89590 : FunctionVoid<ExprWalker>
	{
		[SpecialName]
		private _N_closureOf_Walk_89581 _N_Walk_closure_89594;

		public _N__N_lambda__89574__89590(_N_closureOf_Walk_89581 _N_Walk_closure_89594)
		{
			this._N_Walk_closure_89594 = _N_Walk_closure_89594;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalker w)
		{
			w.Walk(_N_Walk_closure_89594._N_node_89588, _N_Walk_closure_89594._N__N_closurised_this_ptr_89586._handler);
		}
	}

	private sealed class _N_closureOf_Walk_89608
	{
		internal TExpr _N_node_89615;

		internal ExprWalkInfo _N__N_closurised_this_ptr_89613;

		internal _N_closureOf_Walk_89608()
		{
		}
	}

	private sealed class _N__N_lambda__89601__89617 : FunctionVoid<ExprWalker>
	{
		[SpecialName]
		private _N_closureOf_Walk_89608 _N_Walk_closure_89621;

		public _N__N_lambda__89601__89617(_N_closureOf_Walk_89608 _N_Walk_closure_89621)
		{
			this._N_Walk_closure_89621 = _N_Walk_closure_89621;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalker w)
		{
			w.Walk(_N_Walk_closure_89621._N_node_89615, _N_Walk_closure_89621._N__N_closurised_this_ptr_89613._handler);
		}
	}

	private sealed class _N_closureOf_Walk_89635
	{
		internal Pattern _N_node_89642;

		internal ExprWalkInfo _N__N_closurised_this_ptr_89640;

		internal _N_closureOf_Walk_89635()
		{
		}
	}

	private sealed class _N__N_lambda__89628__89644 : FunctionVoid<ExprWalker>
	{
		[SpecialName]
		private _N_closureOf_Walk_89635 _N_Walk_closure_89648;

		public _N__N_lambda__89628__89644(_N_closureOf_Walk_89635 _N_Walk_closure_89648)
		{
			this._N_Walk_closure_89648 = _N_Walk_closure_89648;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalker w)
		{
			w.Walk(_N_Walk_closure_89648._N_node_89642, _N_Walk_closure_89648._N__N_closurised_this_ptr_89640._handler);
		}
	}

	private bool _isStopped;

	private bool _isSkipped;

	private ExprWalkHandler _handler;

	private IExprWalkerCallback _callback;

	private readonly HashSet<object> _visited = new HashSet<object>();

	private object _node;

	public object Node
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _node;
		}
	}

	internal void Init(ExprWalkHandler handler, IExprWalkerCallback callback)
	{
		_handler = handler;
		_callback = callback;
		_isStopped = false;
		_isSkipped = false;
		_visited.Clear();
	}

	internal bool Push(object node)
	{
		bool flag = false;
		if (node == null || !_visited.Add(node))
		{
			return false;
		}
		_node = node;
		_isSkipped = false;
		int result;
		if (_isStopped || node == null || _handler == null)
		{
			result = 0;
		}
		else
		{
			_handler(this);
			if (!_isStopped && !_isSkipped)
			{
				if (_callback != null)
				{
					_callback.Push(this);
				}
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		return (byte)result != 0;
	}

	internal void Pop()
	{
		if (!_isStopped && _callback != null)
		{
			_callback.Pop(this);
		}
	}

	private void Walk(FunctionVoid<ExprWalker> walk)
	{
		walk.apply_void(new ExprWalker(_callback));
		Skip();
	}

	public void Walk(PExpr node)
	{
		_N_closureOf_Walk_89581 n_closureOf_Walk_ = new _N_closureOf_Walk_89581();
		n_closureOf_Walk_._N_node_89588 = node;
		n_closureOf_Walk_._N__N_closurised_this_ptr_89586 = this;
		FunctionVoid<ExprWalker> walk = new _N__N_lambda__89574__89590(n_closureOf_Walk_);
		Walk(walk);
	}

	public void Walk(TExpr node)
	{
		_N_closureOf_Walk_89608 n_closureOf_Walk_ = new _N_closureOf_Walk_89608();
		n_closureOf_Walk_._N_node_89615 = node;
		n_closureOf_Walk_._N__N_closurised_this_ptr_89613 = this;
		FunctionVoid<ExprWalker> walk = new _N__N_lambda__89601__89617(n_closureOf_Walk_);
		Walk(walk);
	}

	public void Walk(Pattern node)
	{
		_N_closureOf_Walk_89635 n_closureOf_Walk_ = new _N_closureOf_Walk_89635();
		n_closureOf_Walk_._N_node_89642 = node;
		n_closureOf_Walk_._N__N_closurised_this_ptr_89640 = this;
		FunctionVoid<ExprWalker> walk = new _N__N_lambda__89628__89644(n_closureOf_Walk_);
		Walk(walk);
	}

	public void Stop()
	{
		_isStopped = true;
		if (_callback != null)
		{
			_callback.Stop(this);
		}
	}

	public void Skip()
	{
		_isSkipped = true;
		if (_callback != null)
		{
			_callback.Skip(this);
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			IExprWalkerCallback callback = _callback;
			if (callback != null)
			{
				((ISupportRelocation)callback).RelocateImpl(_info);
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
