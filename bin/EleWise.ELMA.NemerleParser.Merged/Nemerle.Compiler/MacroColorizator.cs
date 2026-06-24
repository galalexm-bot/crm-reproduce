using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class MacroColorizator : ISupportRelocation
{
	public int Color;

	public int UseColor;

	public GlobalEnv UseContext;

	private int max_macro_color;

	private list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>> colors_stack;

	public MacroColorizator()
	{
		Color = 1;
		UseColor = 1;
		UseContext = null;
		max_macro_color = 1;
		colors_stack = list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Nil._N_constant_object;
	}

	public int NewColor()
	{
		checked
		{
			max_macro_color++;
			return max_macro_color;
		}
	}

	public _0027a InGlobalColor<_0027a>(Function<_0027a> fn)
	{
		try
		{
			colors_stack = new list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons(new Nemerle.Builtins.Tuple<int, int, GlobalEnv>(Color, UseColor, UseContext), colors_stack);
			Color = 1;
			UseColor = 1;
			UseContext = ManagerClass.Instance.CoreEnv;
			return fn.apply();
		}
		finally
		{
			PopColor();
		}
	}

	public void InGlobalColor(FunctionVoid fn)
	{
		try
		{
			colors_stack = new list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons(new Nemerle.Builtins.Tuple<int, int, GlobalEnv>(Color, UseColor, UseContext), colors_stack);
			Color = 1;
			UseColor = 1;
			UseContext = ManagerClass.Instance.CoreEnv;
			fn.apply_void();
		}
		finally
		{
			PopColor();
		}
	}

	public void PushNewColor(int use_color, GlobalEnv use_context)
	{
		colors_stack = new list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons(new Nemerle.Builtins.Tuple<int, int, GlobalEnv>(Color, UseColor, UseContext), colors_stack);
		Color = NewColor();
		UseColor = use_color;
		UseContext = use_context;
	}

	public void PushUseSiteColor()
	{
		colors_stack = new list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons(new Nemerle.Builtins.Tuple<int, int, GlobalEnv>(Color, UseColor, UseContext), colors_stack);
		Color = UseColor;
	}

	public void PopColor()
	{
		list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>> list = colors_stack;
		if (list is list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons)
		{
			int field = ((list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons)list).hd.Field0;
			int field2 = ((list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons)list).hd.Field1;
			GlobalEnv field3 = ((list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons)list).hd.Field2;
			list = (colors_stack = ((list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Cons)list).tl);
			Color = field;
			UseColor = field2;
			UseContext = field3;
			return;
		}
		if ((object)list == list<Nemerle.Builtins.Tuple<int, int, GlobalEnv>>.Nil._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = "pop from empty stack of macro colors...".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\MacroColorizer.n", 118, "", "pop from empty stack of macro colors...");
		}
		throw new MatchFailureException();
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
