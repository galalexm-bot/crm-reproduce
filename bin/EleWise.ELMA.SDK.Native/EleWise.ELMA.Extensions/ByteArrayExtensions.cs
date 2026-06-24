namespace EleWise.ELMA.Extensions;

internal static class ByteArrayExtensions
{
	public unsafe static bool ByteArrayCompare(byte[] left, byte[] right)
	{
		if (left == right)
		{
			return true;
		}
		if (left == null || right == null)
		{
			return false;
		}
		if (left.Length != right.Length)
		{
			return false;
		}
		fixed (byte* left2 = left)
		{
			fixed (byte* right2 = right)
			{
				return ByteArrayCompare(left2, right2, left.Length);
			}
		}
	}

	public unsafe static bool ByteArrayCompare(byte* left, byte* right, long count)
	{
		if (left == right)
		{
			return true;
		}
		if (left == null || right == null)
		{
			return false;
		}
		while (count-- > 0)
		{
			if (*(left++) != *(right++))
			{
				return false;
			}
		}
		return true;
	}
}
