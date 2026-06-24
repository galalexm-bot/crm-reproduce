using System;
using System.IO;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Extensions;

public static class BinaryFileExtensions
{
	internal static BinaryFileExtensions Ju6m2CGpakA0ftqVGwiB;

	public static void SaveToLocalPath(this BinaryFile binaryFile, string path)
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
			{
				Stream content = binaryFile.GetContent(GetContentOptions.NonSeekable);
				FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
				sM4dVIGpws5LrwZArBiN(content, fileStream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public static string SaveToLocalTempPath(this BinaryFile binaryFile)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				binaryFile.SaveToLocalPath(text);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				text = (string)x0ebneGp4nGmbWmbGO5J(binaryFile.Extension);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return text;
			}
		}
	}

	public static byte[] ToByteArray(this BinaryFile binaryFile)
	{
		//Discarded unreachable code: IL_0068, IL_00a0, IL_00d0, IL_00df, IL_00eb, IL_00fa
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		Stream content = default(Stream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return array;
			default:
				return null;
			case 3:
				try
				{
					array = content.ReadAllBytes();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => array, 
						_ => array, 
					};
				}
				finally
				{
					int num4;
					if (content == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 1;
						}
						goto IL_00a4;
					}
					goto IL_00ba;
					IL_00ba:
					lrtbdDGp6gSYBvHNaYv9(content);
					num4 = 2;
					goto IL_00a4;
					IL_00a4:
					switch (num4)
					{
					case 1:
						goto end_IL_007f;
					case 2:
						goto end_IL_007f;
					}
					goto IL_00ba;
					end_IL_007f:;
				}
			case 1:
				if (binaryFile != null)
				{
					content = binaryFile.GetContent();
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void sM4dVIGpws5LrwZArBiN(object P_0, object P_1)
	{
		((Stream)P_0).CopyAllBytesToStream((Stream)P_1);
	}

	internal static bool O2SZ8BGpD2sqoTEhO5Gy()
	{
		return Ju6m2CGpakA0ftqVGwiB == null;
	}

	internal static BinaryFileExtensions ROf5uqGpt3lelb1nH29r()
	{
		return Ju6m2CGpakA0ftqVGwiB;
	}

	internal static object x0ebneGp4nGmbWmbGO5J(object P_0)
	{
		return IOExtensions.GetTempFileName((string)P_0);
	}

	internal static void lrtbdDGp6gSYBvHNaYv9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
