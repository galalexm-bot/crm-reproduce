using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class MemberBase : DeclarationBase
{
	[IgnoreField]
	internal Location _bodyOpenTokenLocation;

	[IgnoreField]
	internal Location _bodyCloseTokenLocation;

	[IgnoreField]
	internal bool _isIndentationSyntax;

	[IgnoreField]
	internal Location _typeParametersLocation;

	public Location BodyLocation => BodyOpenTokenLocation + BodyCloseTokenLocation;

	public Location BodyInnerLocation => BodyOpenTokenLocation.FromEnd() + BodyCloseTokenLocation.FromStart();

	public Location BodyOpenTokenLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _bodyOpenTokenLocation;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			_bodyOpenTokenLocation = value;
		}
	}

	public Location BodyCloseTokenLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _bodyCloseTokenLocation;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			_bodyCloseTokenLocation = value;
		}
	}

	public bool IsIndentationSyntax
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _isIndentationSyntax;
		}
	}

	public Location TypeParametersLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _typeParametersLocation;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			_typeParametersLocation = value;
		}
	}

	[RecordCtor]
	public MemberBase(Splicable name, AttributesAndModifiers modifiers)
		: base(name, modifiers)
	{
	}

	[RecordCtor]
	public MemberBase(Location loc, Splicable name, AttributesAndModifiers modifiers)
		: base(loc, name, modifiers)
	{
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			_typeParametersLocation = Completion.Relocate(_typeParametersLocation, _info);
			_bodyCloseTokenLocation = Completion.Relocate(_bodyCloseTokenLocation, _info);
			_bodyOpenTokenLocation = Completion.Relocate(_bodyOpenTokenLocation, _info);
		}
	}
}
