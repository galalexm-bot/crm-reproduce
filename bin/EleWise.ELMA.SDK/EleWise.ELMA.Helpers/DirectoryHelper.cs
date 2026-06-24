using System;
using System.IO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public class DirectoryHelper
{
	private static DirectoryHelper URsyBkhz89I2BiNgTlj2;

	public static void Copy(string sourceDirectory, string targetDirectory)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Copy(sourceDirectory, targetDirectory, (FileInfo info, string s) => false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Copy(string sourceDirectory, string targetDirectory, Func<FileInfo, string, bool> skipCopy)
	{
		DirectoryInfo source = new DirectoryInfo(sourceDirectory);
		DirectoryInfo target = new DirectoryInfo(targetDirectory);
		CopyAll(source, target, skipCopy);
	}

	public static void CopyAll(DirectoryInfo source, DirectoryInfo target, Func<FileInfo, string, bool> skipCopy)
	{
		if (!Directory.Exists(target.FullName))
		{
			Directory.CreateDirectory(target.FullName);
		}
		string path = target.ToString();
		FileInfo[] files = source.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			string text = Path.Combine(path, fileInfo.Name);
			if (!skipCopy(fileInfo, text))
			{
				fileInfo.CopyTo(text, overwrite: true);
			}
		}
		DirectoryInfo[] directories = source.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo target2 = target.CreateSubdirectory(directoryInfo.Name);
			CopyAll(directoryInfo, target2, skipCopy);
		}
	}

	public static string GetRelativePath(string filespec, string folder)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (hZ0tqAhzIXsJJ0jvCVCJ(folder, Path.DirectorySeparatorChar.ToString()))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 2:
				uri = new Uri(filespec);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				folder = (string)q2elU2hzVQWRxDeJfA3Y(folder, Path.DirectorySeparatorChar.ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)N0KLSshziXVjM0JZ73cp(Nh7NlBhzSL2x5nGLCAa9(new Uri(folder), uri).ToString().Replace('/', Path.DirectorySeparatorChar));
			}
		}
	}

	public DirectoryHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jv3cKHhzRuxXIOLGemtE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yt2L72hzZL991UkFucst()
	{
		return URsyBkhz89I2BiNgTlj2 == null;
	}

	internal static DirectoryHelper ogwIQAhzuj4bTQ5kVHNv()
	{
		return URsyBkhz89I2BiNgTlj2;
	}

	internal static bool hZ0tqAhzIXsJJ0jvCVCJ(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object q2elU2hzVQWRxDeJfA3Y(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Nh7NlBhzSL2x5nGLCAa9(object P_0, object P_1)
	{
		return ((Uri)P_0).MakeRelativeUri((Uri)P_1);
	}

	internal static object N0KLSshziXVjM0JZ73cp(object P_0)
	{
		return Uri.UnescapeDataString((string)P_0);
	}

	internal static void jv3cKHhzRuxXIOLGemtE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
