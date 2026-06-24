using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Peg;

public class VToken<TValue> : Located
{
	private readonly TValue value;

	public TValue Value
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return value;
		}
	}

	public static implicit operator TValue(VToken<TValue> x)
	{
		return x.Value;
	}

	[RecordCtor]
	public VToken([MappedMember("value")] TValue value)
	{
		this.value = value;
	}

	[RecordCtor]
	public VToken(Location location, [MappedMember("value")] TValue value)
		: base(location)
	{
		this.value = value;
	}
}
