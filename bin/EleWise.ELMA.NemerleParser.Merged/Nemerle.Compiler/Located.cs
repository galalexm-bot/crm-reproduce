using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class Located : ISupportRelocation
{
	private Location loc;

	public bool IsGenerated => loc.IsGenerated;

	public override Location Location
	{
		[DebuggerStepThrough]
		get
		{
			return loc;
		}
		set
		{
			loc = value;
		}
	}

	public Located()
	{
		loc = LocationStack.Top();
	}

	public Located(Location loc)
	{
		this.loc = loc;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			loc = Completion.Relocate(loc, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
