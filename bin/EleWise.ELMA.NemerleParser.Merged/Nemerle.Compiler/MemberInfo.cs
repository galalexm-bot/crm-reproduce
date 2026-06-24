using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public abstract class MemberInfo : ISupportRelocation
{
	private IDictionary _userData;

	protected bool is_obsolete;

	protected NemerleModifiers attributes;

	public IDictionary UserData
	{
		get
		{
			if (_userData == null)
			{
				_userData = new ListDictionary();
			}
			return _userData;
		}
	}

	public override bool IsConstructor => false;

	public override bool IsStatic => (attributes & NemerleModifiers.Static) != 0;

	public bool IsPublic => (attributes & NemerleModifiers.Public) != 0;

	public bool IsPrivate => (attributes & NemerleModifiers.Private) != 0;

	public bool IsProtected => (attributes & NemerleModifiers.Protected) != 0;

	public bool IsInternal => (attributes & NemerleModifiers.Internal) != 0;

	public bool IsAbstract => (attributes & NemerleModifiers.Abstract) != 0;

	public override bool HasBeenUsed
	{
		get
		{
			return true;
		}
		set
		{
			string text = null;
			if (is_obsolete && value)
			{
				Nemerle.Builtins.Tuple<string, bool> obsoletionDetails = GetObsoletionDetails();
				text = obsoletionDetails.Field0;
				bool field = obsoletionDetails.Field1;
				text = ((!(text == null)) ? (Convert.ToString(this) + " is obsolete: '" + Convert.ToString(text) + "'") : (Convert.ToString(this) + " is obsolete"));
				if (field)
				{
					Message.Error(text);
				}
				else
				{
					Message.Warning(618, text);
				}
			}
		}
	}

	public abstract override GlobalEnv GlobalEnv { get; }

	public override bool IsConditional => false;

	public bool IsObsolete
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return is_obsolete;
		}
	}

	public NemerleModifiers Attributes
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return attributes;
		}
	}

	public void StartTyping()
	{
		_userData = null;
	}

	public abstract override AttributesAndModifiers GetModifiers();

	public abstract override bool IsCustomAttributeDefined(string attributeFullName);

	internal override Nemerle.Builtins.Tuple<string, bool> GetObsoletionDetails()
	{
		bool flag = false;
		string text = null;
		TypeInfo obsolete_tc = GlobalEnv.Manager.InternalType.Obsolete_tc;
		AttributesAndModifiers modifiers = GetModifiers();
		if (modifiers == null)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 236, "mods != null", ToString().ToString());
		}
		list<PExpr> list = modifiers.FindAttributeWithArgs(obsolete_tc, GlobalEnv).Value.Field1;
		text = null;
		flag = false;
		list = list;
		while (list is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list).hd;
			list = ((list<PExpr>.Cons)list).tl;
			if (hd is PExpr.Literal)
			{
				if (((PExpr.Literal)hd).val is Literal.String)
				{
					text = ((Literal.String)((PExpr.Literal)hd).val).val;
					text = text;
				}
				else if (((PExpr.Literal)hd).val is Literal.Bool)
				{
					flag = ((Literal.Bool)((PExpr.Literal)hd).val).val;
					flag = flag;
				}
			}
			else if (hd is PExpr.Assign && ((PExpr.Assign)hd).target is PExpr.Ref)
			{
				if (((PExpr.Ref)((PExpr.Assign)hd).target).name.idl == "Message")
				{
					if (((PExpr.Assign)hd).source is PExpr.Literal && ((PExpr.Literal)((PExpr.Assign)hd).source).val is Literal.String)
					{
						text = ((Literal.String)((PExpr.Literal)((PExpr.Assign)hd).source).val).val;
						text = text;
					}
				}
				else if (((PExpr.Ref)((PExpr.Assign)hd).target).name.idl == "IsError" && ((PExpr.Assign)hd).source is PExpr.Literal && ((PExpr.Literal)((PExpr.Assign)hd).source).val is Literal.Bool)
				{
					flag = ((Literal.Bool)((PExpr.Literal)((PExpr.Assign)hd).source).val).val;
					flag = flag;
				}
			}
			list = list;
		}
		return new Nemerle.Builtins.Tuple<string, bool>(text, flag);
	}

	public bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess)
	{
		int result;
		if (IsPublic)
		{
			result = 1;
			goto IL_00c8;
		}
		if (IsInternal)
		{
			if (memberTypeInfo is TypeBuilder)
			{
				if (1 == 0)
				{
					goto IL_003e;
				}
			}
			else if (0 == 0)
			{
				goto IL_003e;
			}
			goto IL_0050;
		}
		goto IL_0056;
		IL_00c8:
		return (byte)result != 0;
		IL_003e:
		if (memberTypeInfo.CanAccess(currentTypeInfo))
		{
			goto IL_0050;
		}
		goto IL_0056;
		IL_0050:
		result = 1;
		goto IL_00c8;
		IL_0056:
		TypeInfo typeInfo = memberTypeInfo;
		TypeInfo typeInfo2 = currentTypeInfo;
		while (true)
		{
			if (typeInfo2 != null && typeInfo != null)
			{
				if (!typeInfo.Equals(typeInfo2))
				{
					TypeInfo typeInfo3 = typeInfo;
					typeInfo2 = typeInfo2.DeclaringType;
					typeInfo = typeInfo3;
					continue;
				}
				if (true)
				{
					result = 1;
					break;
				}
			}
			result = ((IsProtected && ((!isThisAccess) ? memberTypeInfo.IsDerivedFrom(currentTypeInfo) : currentTypeInfo.IsDerivedFrom(memberTypeInfo))) ? 1 : 0);
			break;
		}
		goto IL_00c8;
	}

	public override list<string> GetConditions()
	{
		return list<string>.Nil._N_constant_object;
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
