using System;
using System.IO;
using System.Text;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Helpers;

public static class TempFileMetadataHelper
{
	private static TempFileMetadataHelper tYUkh0hYOAI28JJnu86G;

	public static string GetFilename(string metadataFilePath)
	{
		return (string)i2K2aehYNWJvPZsU0rQn(Encoding.UTF8, y5SGiIhY1daWojQ3jJ8X(YHi3D4hYP0M1HVLikr5H(metadataFilePath)));
	}

	public static void PutFilename(string metadataFilePath, string filename)
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
				kyds19hY3I2ZqNjF5qjR(metadataFilePath, filename.ToBase64String());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object YHi3D4hYP0M1HVLikr5H(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static object y5SGiIhY1daWojQ3jJ8X(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object i2K2aehYNWJvPZsU0rQn(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static bool nFr2VnhY2AIXLvS2iiXW()
	{
		return tYUkh0hYOAI28JJnu86G == null;
	}

	internal static TempFileMetadataHelper QRwuxchYeAsXH8utm8VL()
	{
		return tYUkh0hYOAI28JJnu86G;
	}

	internal static void kyds19hY3I2ZqNjF5qjR(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}
}
