using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Peg;

public class PegParser
{
	private sealed class _N__N_lambda__7659__7666 : FunctionVoid<IGrammar>
	{
		[SpecialName]
		public static readonly _N__N_lambda__7659__7666 Instance = new _N__N_lambda__7659__7666();

		[SpecialName]
		public sealed override void apply_void(IGrammar _N__7658)
		{
			_N__7658.PushGrammarState();
		}
	}

	private readonly Hashtable<Type, IGrammar> _grammars = new Hashtable<Type, IGrammar>();

	private readonly List<IGrammar> _grammarList = new List<IGrammar>();

	private readonly Nemerle.Collections.Stack<int> _stateStack = new Nemerle.Collections.Stack<int>();

	public T AddGrammar<T>(Function<PegParser, T> ctor) where T : class, IGrammar
	{
		Type typeFromHandle = typeof(T);
		IGrammar value = null;
		object result;
		if (_grammars.TryGetValue(typeFromHandle, out value))
		{
			result = (T)value;
		}
		else
		{
			T val = ctor.apply(this);
			if (!val.GetType().Equals(typeFromHandle))
			{
				throw new AssertionException("PegParser.n", 27, "newGrammar.GetType().Equals(grammarType)", "");
			}
			_grammars[typeFromHandle] = val;
			_grammarList.Add(val);
			result = val;
		}
		return (T)result;
	}

	public void PushState()
	{
		_stateStack.Push(_grammarList.Count);
		List<IGrammar> grammarList = _grammarList;
		FunctionVoid<IGrammar> instance = _N__N_lambda__7659__7666.Instance;
		grammarList.Iter(instance);
	}

	public void PopState()
	{
		_stateStack.Push(_grammarList.Count);
	}
}
