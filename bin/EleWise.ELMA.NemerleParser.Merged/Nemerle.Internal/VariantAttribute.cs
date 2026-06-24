using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

public sealed class VariantAttribute : NemerleAttribute
{
	private readonly string variantOptions;

	public string VariantOptions
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return variantOptions;
		}
	}

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(variantOptions);
	}

	[RecordCtor]
	public VariantAttribute([MappedMember("variantOptions")] string variantOptions)
	{
		this.variantOptions = variantOptions;
	}
}
