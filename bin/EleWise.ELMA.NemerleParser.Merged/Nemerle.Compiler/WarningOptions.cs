using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class WarningOptions : ISupportRelocation
{
	private sealed class _N_closureOf_set_Level_25797
	{
		internal WarningOptions _N__N_closurised_this_ptr_25802;

		internal _N_closureOf_set_Level_25797()
		{
		}
	}

	private sealed class _N__N_lambda__25789__25825 : FunctionVoid<int, object>
	{
		[SpecialName]
		private _N_closureOf_set_Level_25797 _N_set_Level_closure_25829;

		public _N__N_lambda__25789__25825(_N_closureOf_set_Level_25797 _N_set_Level_closure_25829)
		{
			this._N_set_Level_closure_25829 = _N_set_Level_closure_25829;
		}

		[SpecialName]
		public sealed override void apply_void(int x, object _N_wildcard_3296)
		{
			if (!_N_set_Level_closure_25829._N__N_closurised_this_ptr_25802.currently_enabled.Contains(x))
			{
				_N_set_Level_closure_25829._N__N_closurised_this_ptr_25802.currently_enabled.Add(x, "");
			}
		}
	}

	private bool treat_warnings_as_errors = false;

	private int _N_field_cur_level_embeded_in_Level_3295;

	private Hashtable<int, object> currently_enabled;

	private readonly Hashtable<int, object> enabled = new Hashtable<int, object>();

	private readonly Hashtable<int, object> disabled = new Hashtable<int, object>();

	private readonly Hashtable<int, list<Nemerle.Builtins.Tuple<int, int>>> pragma_warning = new Hashtable<int, list<Nemerle.Builtins.Tuple<int, int>>>();

	private readonly int[][] levels = new int[6][]
	{
		new int[0],
		new int[12]
		{
			183, 184, 458, 602, 626, 1633, 1696, 5000, 10010, 10011,
			10012, 10013
		},
		new int[7] { 108, 114, 162, 251, 252, 253, 618 },
		new int[5] { 67, 105, 168, 169, 219 },
		new int[10] { 28, 78, 109, 402, 628, 649, 10001, 10003, 10005, 10009 },
		new int[5] { 10002, 10004, 10006, 10007, 10008 }
	};

	public int Level
	{
		get
		{
			return _N_field_cur_level_embeded_in_Level_3295;
		}
		set
		{
			int num = 0;
			int num2 = 0;
			_N_closureOf_set_Level_25797 n_closureOf_set_Level_ = new _N_closureOf_set_Level_25797();
			n_closureOf_set_Level_._N__N_closurised_this_ptr_25802 = this;
			if (value < 0 || value > 4)
			{
				return;
			}
			_N_field_cur_level_embeded_in_Level_3295 = value;
			currently_enabled = new Hashtable<int, object>();
			checked
			{
				for (num2 = 0; num2 <= value; num2++)
				{
					int[] array = levels[num2];
					for (num = 0; num < array.Length; num++)
					{
						int num3 = array[num];
						num3 = num3;
						if (!disabled.Contains(num3))
						{
							currently_enabled.Add(num3, "");
						}
					}
				}
				Hashtable<int, object> hashtable = enabled;
				FunctionVoid<int, object> f = new _N__N_lambda__25789__25825(n_closureOf_set_Level_);
				hashtable.Iter(f);
			}
		}
	}

	public string Help
	{
		get
		{
			int num = 0;
			bool flag = false;
			list<Nemerle.Builtins.Tuple<int, string>>.Cons cons = new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(28, "'function declaration' has the wrong signature to be an entry point"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(105, "The using directive for 'namespace' appeared previously in this namespace"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(114, "'f1' hides inherited member 'f2'. To make the current method override that implementation, add the override keyword.  Otherwise add the new keyword."), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(168, "The variable 'var' is declared but never used"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(402, "an entry point cannot be generic or in a generic type"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(649, "Field 'field' is never assigned to, and will always have its default value 'value"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10001, "Cast is unnecessary"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10002, "Enable some pedantic checks for illegal characters in input stream"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10003, "Other global unused member warnings"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10004, "warnings about usage of bit operations on enums without correct attribute"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10005, "warnings about ignoring computed values"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10006, "`this' is unused, consider making method static"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10007, "`$' occurs inside string literal, which is not prefixed itself with `$'"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10008, "verify that generic arguments of methods and classes are inferred to some concrete types"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10009, "using a constant object reference directly (as first class value)"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10010, "compilation options `-debug+' and `-optimize' has poor compatibility: `-debug+' suppresses runtime optimizations"), new list<Nemerle.Builtins.Tuple<int, string>>.Cons(new Nemerle.Builtins.Tuple<int, string>(10011, "comparing a value with reference equality"), list<Nemerle.Builtins.Tuple<int, string>>.Nil._N_constant_object)))))))))))))))));
			StringBuilder stringBuilder = new StringBuilder();
			list<Nemerle.Builtins.Tuple<int, string>> list = cons;
			while (list is list<Nemerle.Builtins.Tuple<int, string>>.Cons)
			{
				Nemerle.Builtins.Tuple<int, string> hd = ((list<Nemerle.Builtins.Tuple<int, string>>.Cons)list).hd;
				list = ((list<Nemerle.Builtins.Tuple<int, string>>.Cons)list).tl;
				int field = hd.Field0;
				string field2 = hd.Field1;
				int num2 = 0;
				object obj;
				while (true)
				{
					if (num2 >= levels.Length)
					{
						obj = "";
						break;
					}
					flag = false;
					int[] array = levels[num2];
					foreach (int num3 in array)
					{
						if (num3 == field)
						{
							flag = true;
						}
					}
					if (flag)
					{
						obj = "[enabled by -warn:" + Convert.ToString(num2) + "]";
						break;
					}
					num2 = checked(num2 + 1);
				}
				string text = (string)obj;
				StringBuilder stringBuilder2 = stringBuilder.Append(Convert.ToString(field) + "\t" + Convert.ToString(field2) + " " + Convert.ToString(text) + Environment.NewLine);
				list = list;
			}
			return stringBuilder.ToString();
		}
	}

	public bool TreatWarningsAsErrors
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return treat_warnings_as_errors;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			treat_warnings_as_errors = value;
		}
	}

	public WarningOptions()
	{
		enabled.Clear();
		disabled.Clear();
		pragma_warning.Clear();
		Level = 4;
	}

	public bool IsEnabled(int nr)
	{
		bool flag = false;
		try
		{
			return currently_enabled.Contains(nr);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool IsEnabledAt(Location loc, int nr)
	{
		int result;
		if (IsEnabled(nr))
		{
			if (pragma_warning.Contains(loc.FileIndex))
			{
				int line = loc.Line;
				list<Nemerle.Builtins.Tuple<int, int>> list = pragma_warning[loc.FileIndex];
				while (true)
				{
					if (list is list<Nemerle.Builtins.Tuple<int, int>>.Cons)
					{
						int field = ((list<Nemerle.Builtins.Tuple<int, int>>.Cons)list).hd.Field0;
						list<Nemerle.Builtins.Tuple<int, int>> tl = ((list<Nemerle.Builtins.Tuple<int, int>>.Cons)list).tl;
						if (field > line)
						{
							list = tl;
							continue;
						}
						field = ((list<Nemerle.Builtins.Tuple<int, int>>.Cons)list).hd.Field1;
						list = ((list<Nemerle.Builtins.Tuple<int, int>>.Cons)list).tl;
						if (field == 1 || field == nr)
						{
							result = 0;
							break;
						}
						if (field == -1 || field == checked(nr * -1))
						{
							result = 1;
							break;
						}
						list = list;
						continue;
					}
					if ((object)list == list<Nemerle.Builtins.Tuple<int, int>>.Nil._N_constant_object)
					{
						result = 1;
						break;
					}
					throw new MatchFailureException();
				}
			}
			else
			{
				result = 1;
			}
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public void AddPragmaWarning(int file_idx, int line_no, int warning_no)
	{
		if (pragma_warning.Contains(file_idx))
		{
			Hashtable<int, list<Nemerle.Builtins.Tuple<int, int>>> hashtable = pragma_warning;
			hashtable[file_idx] = new list<Nemerle.Builtins.Tuple<int, int>>.Cons(new Nemerle.Builtins.Tuple<int, int>(line_no, warning_no), hashtable[file_idx]);
		}
		else
		{
			pragma_warning[file_idx] = new list<Nemerle.Builtins.Tuple<int, int>>.Cons(new Nemerle.Builtins.Tuple<int, int>(line_no, warning_no), list<Nemerle.Builtins.Tuple<int, int>>.Nil._N_constant_object);
		}
	}

	public void Enable(int nr)
	{
		if (disabled.Contains(nr))
		{
			Message.Warning("warning N" + Convert.ToString(nr) + " is already explicitly disabled, thus it cannot be enabled");
			return;
		}
		if (!currently_enabled.Contains(nr))
		{
			currently_enabled.Add(nr, null);
		}
		if (!enabled.Contains(nr))
		{
			enabled.Add(nr, null);
		}
	}

	public void Disable(int nr)
	{
		if (enabled.Contains(nr))
		{
			Message.Warning("warning N" + Convert.ToString(nr) + " is already explicitly enabled, thus it cannot be disabled");
			return;
		}
		if (currently_enabled.Contains(nr))
		{
			currently_enabled.Remove(nr);
		}
		if (!disabled.Contains(nr))
		{
			disabled.Add(nr, null);
		}
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
