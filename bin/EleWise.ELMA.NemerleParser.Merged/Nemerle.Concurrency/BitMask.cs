namespace Nemerle.Concurrency;

public struct BitMask
{
	private uint i;

	public void Set(uint m)
	{
		i |= m;
	}

	public void Clear(uint m)
	{
		i &= ~m;
	}

	public bool Match(uint m)
	{
		return (~i & m) == 0;
	}
}
