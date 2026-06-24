using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class Region : ISupportRelocation
{
	private bool isComplete;

	private Location location;

	private readonly string text;

	public bool IsComplete
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return isComplete;
		}
	}

	public Location Location
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return location;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return text;
		}
	}

	public Region(Location location, string text)
	{
		this.location = location;
		this.text = ((!(text == null)) ? text : string.Empty);
	}

	internal void SetEndRegion(Location loc)
	{
		if (isComplete)
		{
			throw new InvalidOperationException("region is complete.");
		}
		if (location.FileIndex != loc.FileIndex)
		{
			throw new InvalidOperationException("invalid endregion.");
		}
		isComplete = true;
		location = new Location(location.FileIndex, location.Line, location.Column, loc.Line, loc.Column);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			location = Completion.Relocate(location, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
