using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace EleWise.ELMA.Packaging;

internal static class FileNative
{
	public static void SetCreationTime(SafeFileHandle handle, DateTime creationTime)
	{
		SetCreationTimeUtc(handle, creationTime.ToUniversalTime());
	}

	public static void SetCreationTimeUtc(SafeFileHandle handle, DateTime creationTimeUtc)
	{
		long lpCreationTime = creationTimeUtc.ToFileTimeUtc();
		if (!SetFileCreationTime(handle, ref lpCreationTime, IntPtr.Zero, IntPtr.Zero))
		{
			throw new InvalidOperationException($"Cannot set creation time of file (HResult: {Marshal.GetLastWin32Error()})");
		}
	}

	public static void SetLastWriteTime(SafeFileHandle handle, DateTime lastWriteTime)
	{
		SetLastWriteTimeUtc(handle, lastWriteTime.ToUniversalTime());
	}

	public static void SetLastWriteTimeUtc(SafeFileHandle handle, DateTime lastWriteTimeUtc)
	{
		long lpLastWriteTime = lastWriteTimeUtc.ToFileTimeUtc();
		if (!SetFileLastWriteTime(handle, IntPtr.Zero, IntPtr.Zero, ref lpLastWriteTime))
		{
			throw new InvalidOperationException($"Cannot set last write time of file (HResult: {Marshal.GetLastWin32Error()})");
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "SetFileTime", SetLastError = true)]
	private static extern bool SetFileCreationTime(SafeFileHandle hFile, ref long lpCreationTime, IntPtr p1, IntPtr p2);

	[DllImport("kernel32.dll", EntryPoint = "SetFileTime", SetLastError = true)]
	private static extern bool SetFileLastWriteTime(SafeFileHandle hFile, IntPtr p1, IntPtr p2, ref long lpLastWriteTime);
}
