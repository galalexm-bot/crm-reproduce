using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging.Shortcuts;

public class Shortcut
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface IWshShortcut
	{
		[DispId(0)]
		string FullName
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string Arguments
		{
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1001)]
		string Description
		{
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1002)]
		string Hotkey
		{
			[DispId(1002)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1002)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1003)]
		string IconLocation
		{
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1004)]
		string RelativePath
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string TargetPath
		{
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1006)]
		int WindowStyle
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string WorkingDirectory
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[TypeLibFunc(64)]
		[DispId(2000)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type m_type = Type.GetTypeFromProgID("WScript.Shell");

	private static object m_shell = Activator.CreateInstance(m_type);

	public static void Create(string fileName, string targetPath, string arguments, string workingDirectory, string description, string hotkey, string iconPath)
	{
		string directoryName = Path.GetDirectoryName(fileName);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		IWshShortcut wshShortcut = (IWshShortcut)m_type.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, m_shell, new object[1] { fileName });
		wshShortcut.Description = description;
		if (!string.IsNullOrEmpty(hotkey))
		{
			wshShortcut.Hotkey = hotkey;
		}
		wshShortcut.TargetPath = targetPath;
		wshShortcut.WorkingDirectory = workingDirectory;
		wshShortcut.Arguments = arguments;
		if (!string.IsNullOrEmpty(iconPath))
		{
			wshShortcut.IconLocation = iconPath;
		}
		wshShortcut.Save();
	}

	public static string GetShortcutTarget(string fileName)
	{
		if (!File.Exists(fileName))
		{
			return null;
		}
		IWshShortcut wshShortcut = (IWshShortcut)m_type.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, m_shell, new object[1] { fileName });
		try
		{
			return wshShortcut.TargetPath;
		}
		catch
		{
			return null;
		}
	}
}
