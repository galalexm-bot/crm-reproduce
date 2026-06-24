using System.IO;
using EleWise.ELMA.IO;

namespace EleWise.ELMA.Extensions;

internal static class MemoryStreamExtensions
{
	public unsafe static bool Compare(this MemoryStream left, MemoryStream right)
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
		NativeMemoryStream nativeMemoryStream = left as NativeMemoryStream;
		NativeMemoryStream nativeMemoryStream2 = right as NativeMemoryStream;
		if (nativeMemoryStream != null && nativeMemoryStream2 != null)
		{
			return ByteArrayExtensions.ByteArrayCompare(nativeMemoryStream.GetNativeBuffer(), nativeMemoryStream2.GetNativeBuffer(), left.Length);
		}
		if (nativeMemoryStream != null)
		{
			if (right.TryGetBuffer(out var buffer) && buffer.Array != null)
			{
				fixed (byte* ptr = buffer.Array)
				{
					return ByteArrayExtensions.ByteArrayCompare(nativeMemoryStream.GetNativeBuffer(), ptr + buffer.Offset, left.Length);
				}
			}
			return false;
		}
		if (nativeMemoryStream2 != null)
		{
			if (left.TryGetBuffer(out var buffer2) && buffer2.Array != null)
			{
				fixed (byte* ptr2 = buffer2.Array)
				{
					return ByteArrayExtensions.ByteArrayCompare(ptr2 + buffer2.Offset, nativeMemoryStream2.GetNativeBuffer(), left.Length);
				}
			}
			return false;
		}
		if (left.TryGetBuffer(out var buffer3) && buffer3.Array != null && right.TryGetBuffer(out var buffer4) && buffer4.Array != null)
		{
			fixed (byte* ptr3 = buffer3.Array)
			{
				fixed (byte* ptr4 = buffer4.Array)
				{
					return ByteArrayExtensions.ByteArrayCompare(ptr3 + buffer3.Offset, ptr4 + buffer4.Offset, left.Length);
				}
			}
		}
		return false;
	}
}
