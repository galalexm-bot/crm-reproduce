using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class MatchCompilerOptions : ISupportRelocation
{
	private int min_switch_size_for_variants;

	private int min_switch_size_for_ordinals;

	public int MinSwitchSizeForVariants
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return min_switch_size_for_variants;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			min_switch_size_for_variants = value;
		}
	}

	public int MinSwitchSizeForOrdinals
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return min_switch_size_for_ordinals;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			min_switch_size_for_ordinals = value;
		}
	}

	public MatchCompilerOptions()
	{
		Clear();
	}

	public void Clear()
	{
		min_switch_size_for_variants = 12;
		min_switch_size_for_ordinals = 4;
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
