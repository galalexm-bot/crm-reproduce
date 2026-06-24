using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace EleWise.ELMA.Files;

public static class FileUtils
{
	private static FileUtils dkGIGsGX56YH5uIdCS8l;

	public static void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf, IL_010c, IL_0158, IL_0167, IL_0199, IL_01a8, IL_01d8, IL_0210, IL_0248
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_0294: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		string[] array = default(string[]);
		int num3 = default(int);
		FileStream fileStream = default(FileStream);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 12:
			case 14:
				CompressFolder(array[num3], zipStream, folderOffset);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
			case 3:
				if (num3 < array.Length)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			case 6:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				continue;
			case 15:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
				num3 = 0;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 2;
				}
				continue;
			case 16:
				num3++;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				array = (string[])StJXu2GXLksyfoiWaXmT(path);
				num2 = 6;
				continue;
			case 13:
				zipStream.CloseEntry();
				num2 = 15;
				continue;
			case 5:
				try
				{
					StreamUtils.Copy((Stream)fileStream, (Stream)(object)zipStream, array2);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (fileStream != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								((IDisposable)fileStream).Dispose();
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 13;
			case 9:
				return;
			default:
			{
				string obj = array[num3];
				FileInfo fileInfo = new FileInfo(obj);
				ZipEntry val = new ZipEntry((string)rKUYdFGXUITmqfiiLrUq(obj.Substring(folderOffset)));
				val.set_DateTime(fileInfo.LastWriteTime);
				WiUJooGXcDqnrVmOPb9d((object)val, Lo6iuYGXseL0GMGPYeMt(fileInfo));
				B4PXGrGXzWh5ky34uQD5((object)val, true);
				ZipEntry val2 = val;
				zipStream.PutNextEntry(val2);
				array2 = new byte[4096];
				fileStream = (FileStream)F7KCYlGTFVAJB9AMZYId(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 5;
				}
				continue;
			}
			case 2:
			case 8:
				if (num3 >= array.Length)
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 12;
				}
				continue;
			case 11:
				break;
			}
			array = Directory.GetDirectories(path);
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
			{
				num2 = 4;
			}
		}
	}

	public static void CopyDirectory(string src, string dst)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				CopyDirectory(src, dst, overwrite: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static IEnumerable<string> CopyDirectory(string src, string dst, bool overwrite)
	{
		return CopyDirectory(src, dst, "", overwrite);
	}

	private static IEnumerable<string> CopyDirectory(object src, object dst, object returnPrefix, bool overwrite)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.dst = (string)dst;
		CS_0024_003C_003E8__locals0.returnPrefix = (string)returnPrefix;
		CS_0024_003C_003E8__locals0.overwrite = overwrite;
		if (!Directory.Exists(CS_0024_003C_003E8__locals0.dst))
		{
			Directory.CreateDirectory(CS_0024_003C_003E8__locals0.dst);
		}
		return Directory.GetFileSystemEntries((string)src).SelectMany(delegate(string element)
		{
			string fileName = Path.GetFileName(element);
			string text = Path.Combine(CS_0024_003C_003E8__locals0.dst, fileName);
			string text2 = Path.Combine(CS_0024_003C_003E8__locals0.returnPrefix, fileName);
			if (Directory.Exists(element))
			{
				return CopyDirectory(element, text, text2, CS_0024_003C_003E8__locals0.overwrite);
			}
			if (!CS_0024_003C_003E8__locals0.overwrite && File.Exists(text))
			{
				return new string[1] { text2 };
			}
			File.Copy(element, text, CS_0024_003C_003E8__locals0.overwrite);
			return Enumerable.Empty<string>();
		}).ToArray();
	}

	internal static object StJXu2GXLksyfoiWaXmT(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static object rKUYdFGXUITmqfiiLrUq(object P_0)
	{
		return ZipEntry.CleanName((string)P_0);
	}

	internal static long Lo6iuYGXseL0GMGPYeMt(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static void WiUJooGXcDqnrVmOPb9d(object P_0, long P_1)
	{
		((ZipEntry)P_0).set_Size(P_1);
	}

	internal static void B4PXGrGXzWh5ky34uQD5(object P_0, bool P_1)
	{
		((ZipEntry)P_0).set_IsUnicodeText(P_1);
	}

	internal static object F7KCYlGTFVAJB9AMZYId(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static bool inprRjGXjLDKVuxqugn3()
	{
		return dkGIGsGX56YH5uIdCS8l == null;
	}

	internal static FileUtils ghYohfGXYPUsDEFpxpio()
	{
		return dkGIGsGX56YH5uIdCS8l;
	}
}
