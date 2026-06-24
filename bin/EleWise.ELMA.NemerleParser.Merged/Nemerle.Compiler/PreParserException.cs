using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

internal class PreParserException : Exception, ISupportRelocation
{
	public Location _location;

	public Location Location
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _location;
		}
	}

	public PreParserException(Location location, string msg)
		: base(msg)
	{
		_location = location;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			_location = Completion.Relocate(_location, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
