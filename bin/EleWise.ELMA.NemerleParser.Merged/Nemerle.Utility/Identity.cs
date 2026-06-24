using Nemerle.Builtins;

namespace Nemerle.Utility;

public sealed class Identity<A, B> : Function<A, B> where A : B
{
	public static readonly Identity<A, B> Instance;

	static Identity()
	{
		Instance = new Identity<A, B>();
	}

	public override B apply(A x)
	{
		return (B)(object)x;
	}
}
