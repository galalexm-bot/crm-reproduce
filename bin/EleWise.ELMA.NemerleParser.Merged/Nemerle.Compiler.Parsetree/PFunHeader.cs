using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class PFunHeader : ParsedBase, IParametersProvider
{
	private sealed class _N__N_lambda__43772__43779 : Function<PParameter, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__43772__43779 Instance = new _N__N_lambda__43772__43779();

		[SpecialName]
		public sealed override PExpr apply(PParameter _N__43771)
		{
			return _N__43771.ReferencingExpr;
		}
	}

	private class _N_Enumerable_43819 : IEnumerator, IDisposable, IEnumerator<PExpr>, IEnumerable, IEnumerable<PExpr>
	{
		private bool _N_finally_needed_43860;

		internal PExpr _N_x_43858;

		internal list<PParameter> _N__N_wildcard_4026_43856;

		internal PParameter _N_x_43854;

		internal list<PParameter> _N_xs_43852;

		internal PParameter _N_p_43850;

		internal IEnumerator<PExpr> _N_enumerator_43848;

		internal PExpr _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_43844;

		internal PFunHeader _N__N_closurised_this_ptr_43842;

		internal Function<bool> _N__N_wildcard_3438_43840;

		private int _N_this_used;

		public PExpr Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_43860)
			{
				((IDisposable)_N_enumerator_43848).Dispose();
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
				list<PParameter> n__N_wildcard_4026_;
				if (_N_state != 0)
				{
					if (_N_state != 1)
					{
						if (_N_state == 2)
						{
							goto IL_00d8;
						}
						return false;
					}
					n__N_wildcard_4026_ = _N__N_closurised_this_ptr_43842.Parameters;
					goto IL_0067;
				}
				_N_current = _N__N_closurised_this_ptr_43842.ReturnType;
				_N_state = 1;
				return true;
				IL_00d8:
				if (_N_enumerator_43848.MoveNext())
				{
					PExpr pExpr = (_N_x_43858 = _N_enumerator_43848.Current);
					_N_current = _N_x_43858;
					_N_state = 2;
					return true;
				}
				_N_finally_needed_43860 = false;
				((IDisposable)_N_enumerator_43848).Dispose();
				n__N_wildcard_4026_ = _N_xs_43852;
				goto IL_0067;
				IL_0067:
				_N__N_wildcard_4026_43856 = n__N_wildcard_4026_;
				if (_N__N_wildcard_4026_43856 is list<PParameter>.Cons)
				{
					_N_x_43854 = ((list<PParameter>.Cons)_N__N_wildcard_4026_43856).hd;
					_N_xs_43852 = ((list<PParameter>.Cons)_N__N_wildcard_4026_43856).tl;
					_N_p_43850 = _N_x_43854;
					_N_enumerator_43848 = _N_p_43850.GetTypeReferences().GetEnumerator();
					_N_finally_needed_43860 = true;
					goto IL_00d8;
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

		public IEnumerator<PExpr> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_43819 n_Enumerable_ = new _N_Enumerable_43819();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<PExpr>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<PExpr>)this;
			}
			return (IEnumerator<PExpr>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_43819 n_Enumerable_ = new _N_Enumerable_43819();
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

		private void CopyFrom(_N_Enumerable_43819 other)
		{
			_N_this_used = 1;
			_N__N_wildcard_4026_43856 = other._N__N_wildcard_4026_43856;
			_N__N_closurised_this_ptr_43842 = other._N__N_closurised_this_ptr_43842;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N__N_lambda__43886__43893 : Function<PParameter, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__43886__43893 Instance = new _N__N_lambda__43886__43893();

		[SpecialName]
		public sealed override string apply(PParameter x)
		{
			return Convert.ToString(x);
		}
	}

	public Typarms TypeParameters;

	public Splicable SplicableName;

	public PExpr ReturnType;

	public list<PParameter> Parameters;

	public readonly Typarms ParsedTypeParameters;

	public readonly Splicable ParsedSplicableName;

	public readonly PExpr ParsedReturnType;

	public readonly list<PParameter> ParsedParameters;

	[IgnoreField]
	internal Location _parsedParametersOpenLocation;

	[IgnoreField]
	internal Location _parsedParametersCloseLocation;

	public new TFunHeader TypedObject => (TFunHeader)base.TypedObject;

	public string Name => ParsedSplicableName.ToString();

	public Name PName => SplicableName.GetName();

	private list<PParameter> ParametersDeclarations => Parameters;

	public list<PExpr> ParametersReferences
	{
		get
		{
			list<PParameter> parameters = Parameters;
			Function<PParameter, PExpr> instance = _N__N_lambda__43772__43779.Instance;
			return parameters.Map(instance);
		}
	}

	public Location ParsedParametersOpenLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _parsedParametersOpenLocation;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			_parsedParametersOpenLocation = value;
		}
	}

	public Location ParsedParametersCloseLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _parsedParametersCloseLocation;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			_parsedParametersCloseLocation = value;
		}
	}

	public PFunHeader(Location loc, Splicable name, PExpr returnType, list<PParameter> parameters)
		: this(loc, Typarms.Empty, name, returnType, parameters)
	{
	}

	public PFunHeader(Typarms typeParameters, Splicable name, PExpr returnType, list<PParameter> parameters)
		: this(LocationStack.Top(), typeParameters, name, returnType, parameters)
	{
	}

	public PFunHeader(Location loc, Typarms typeParameters, Splicable name, PExpr returnType, list<PParameter> parameters)
		: this(loc, typeParameters, name, returnType, parameters, Location.Default, Location.Default)
	{
	}

	public PFunHeader(Location loc, Typarms typeParameters, Splicable name, PExpr returnType, list<PParameter> parameters, Location parametersOpenLocation, Location parametersCloseLocation)
		: base(loc)
	{
		ParsedTypeParameters = typeParameters;
		ParsedSplicableName = name;
		ParsedParameters = parameters;
		ParsedReturnType = returnType;
		TypeParameters = typeParameters;
		SplicableName = name;
		Parameters = parameters;
		ReturnType = returnType;
		_parsedParametersOpenLocation = parametersOpenLocation;
		_parsedParametersCloseLocation = parametersCloseLocation;
	}

	public IEnumerable<PExpr> GetTypeReferences()
	{
		_N_Enumerable_43819 n_Enumerable_ = new _N_Enumerable_43819();
		n_Enumerable_._N__N_closurised_this_ptr_43842 = this;
		return n_Enumerable_;
	}

	public override string ToString()
	{
		string[] obj = new string[6]
		{
			Convert.ToString(Name),
			Convert.ToString(TypeParameters),
			"(",
			null,
			null,
			null
		};
		IEnumerable<PParameter> source = Parameters;
		Function<PParameter, string> instance = _N__N_lambda__43886__43893.Instance;
		obj[3] = string.Join(", ", source.MapToArray(instance));
		obj[4] = ") : ";
		obj[5] = Convert.ToString(ReturnType);
		return string.Concat(obj);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		base.RelocateImplInternal(_info);
		_info.VisitedObjects[this] = 0;
		_parsedParametersCloseLocation = Completion.Relocate(_parsedParametersCloseLocation, _info);
		_parsedParametersOpenLocation = Completion.Relocate(_parsedParametersOpenLocation, _info);
		list<PParameter> parsedParameters = ParsedParameters;
		if (parsedParameters != null)
		{
			parsedParameters = parsedParameters;
			while (parsedParameters is list<PParameter>.Cons)
			{
				PParameter hd = ((list<PParameter>.Cons)parsedParameters).hd;
				parsedParameters = ((list<PParameter>.Cons)parsedParameters).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				parsedParameters = parsedParameters;
			}
		}
		ParsedReturnType?.RelocateImplInternal(_info);
		ParsedSplicableName?.RelocateImplInternal(_info);
		ParsedTypeParameters?.RelocateImplInternal(_info);
		parsedParameters = Parameters;
		if (parsedParameters != null)
		{
			parsedParameters = parsedParameters;
			while (parsedParameters is list<PParameter>.Cons)
			{
				PParameter hd = ((list<PParameter>.Cons)parsedParameters).hd;
				parsedParameters = ((list<PParameter>.Cons)parsedParameters).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				parsedParameters = parsedParameters;
			}
		}
		ReturnType?.RelocateImplInternal(_info);
		SplicableName?.RelocateImplInternal(_info);
		TypeParameters?.RelocateImplInternal(_info);
	}
}
