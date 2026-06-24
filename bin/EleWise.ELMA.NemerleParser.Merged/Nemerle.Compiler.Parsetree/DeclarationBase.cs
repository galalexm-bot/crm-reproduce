using System.Runtime.CompilerServices;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class DeclarationBase : ParsedBase
{
	public Splicable name;

	public AttributesAndModifiers modifiers;

	[IgnoreField]
	public readonly Splicable ParsedSplicableName;

	[IgnoreField]
	public readonly AttributesAndModifiers ParsedAttributsAndModifiers;

	public Name PName => name.GetName();

	public string Name => (name != null) ? name.ToString() : "";

	public string ParsedName => ParsedSplicableName.ToString();

	public Location NameLocation => (ParsedSplicableName != null) ? ParsedSplicableName.Location : Location;

	public NemerleModifiers Attributes
	{
		get
		{
			return modifiers.mods;
		}
		set
		{
			modifiers.mods = value;
		}
	}

	public DeclarationBase(Splicable name, AttributesAndModifiers modifiers)
		: this(LocationStack.Top(), name, modifiers)
	{
	}

	public DeclarationBase(Location loc, Splicable name, AttributesAndModifiers modifiers)
		: base(loc)
	{
		this.name = name;
		ParsedSplicableName = name;
		this.modifiers = modifiers;
		ParsedAttributsAndModifiers = modifiers;
	}

	public option<GlobalEnv> TryGetEnv()
	{
		Splicable splicable = this.name;
		Name name;
		object result;
		if (splicable is Splicable.Name)
		{
			name = ((Splicable.Name)splicable).body;
		}
		else
		{
			if (!(splicable is Splicable.HalfId))
			{
				if ((object)splicable != null)
				{
					PExpr expr = ((Splicable.Expression)splicable).expr;
				}
				result = option<GlobalEnv>.None._N_constant_object;
				goto IL_006b;
			}
			name = ((Splicable.HalfId)splicable).prefix;
		}
		result = new option<GlobalEnv>.Some(name.context);
		goto IL_006b;
		IL_006b:
		return (option<GlobalEnv>)result;
	}

	public GlobalEnv GetEnv(GlobalEnv defaulteGlobalEnv)
	{
		Splicable splicable = this.name;
		Name name;
		GlobalEnv result;
		if (splicable is Splicable.Name)
		{
			name = ((Splicable.Name)splicable).body;
		}
		else
		{
			if (!(splicable is Splicable.HalfId))
			{
				if ((object)splicable != null)
				{
					PExpr expr = ((Splicable.Expression)splicable).expr;
				}
				result = defaulteGlobalEnv;
				goto IL_0062;
			}
			name = ((Splicable.HalfId)splicable).prefix;
		}
		result = name.context;
		goto IL_0062;
		IL_0062:
		return result;
	}

	public list<PExpr> GetCustomAttributes()
	{
		return modifiers.custom_attrs;
	}

	public void AddCustomAttribute(PExpr e)
	{
		modifiers.custom_attrs = new list<PExpr>.Cons(e, modifiers.custom_attrs);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			ParsedAttributsAndModifiers?.RelocateImplInternal(_info);
			ParsedSplicableName?.RelocateImplInternal(_info);
			modifiers?.RelocateImplInternal(_info);
			name?.RelocateImplInternal(_info);
		}
	}
}
