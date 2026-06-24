using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

public abstract class BaseFileContentLoader : IFileContentLoader, ITextContentExtractor
{
	internal static BaseFileContentLoader B2f8Q2GTbrSuUb8siLbm;

	public abstract List<string> Extensions { get; }

	public virtual bool NeedHtmlClear => true;

	public virtual string GetText(string fileName)
	{
		return (string)esCWRJGTExrcF8OfcpRQ(fileName);
	}

	public virtual string GetText(Stream stream)
	{
		//Discarded unreachable code: IL_005e, IL_0096, IL_00b5, IL_00c4, IL_00f1, IL_0100
		int num = 1;
		int num2 = num;
		StreamReader streamReader2 = default(StreamReader);
		StreamReader streamReader = default(StreamReader);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				streamReader2 = streamReader;
				num2 = 3;
				break;
			case 3:
				try
				{
					result = (string)rs9hNPGTQSLUfIOQYFdq(streamReader);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					int num4;
					if (streamReader2 == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num4 = 1;
						}
						goto IL_009a;
					}
					goto IL_00cf;
					IL_00cf:
					jLyCm2GTCqvuAaifBPx7(streamReader2);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num4 = 2;
					}
					goto IL_009a;
					IL_009a:
					switch (num4)
					{
					case 1:
						goto end_IL_0075;
					case 2:
						goto end_IL_0075;
					}
					goto IL_00cf;
					end_IL_0075:;
				}
			case 1:
				streamReader = new StreamReader(stream, (Encoding)OUusUFGTf2ux3ySHO9pr());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return result;
			}
		}
	}

	protected BaseFileContentLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object esCWRJGTExrcF8OfcpRQ(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static object OUusUFGTf2ux3ySHO9pr()
	{
		return Encoding.UTF8;
	}

	internal static object rs9hNPGTQSLUfIOQYFdq(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static void jLyCm2GTCqvuAaifBPx7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool tFGgxhGThLTV56m2QuuJ()
	{
		return B2f8Q2GTbrSuUb8siLbm == null;
	}

	internal static BaseFileContentLoader jX7GSBGTGfTTKtDvPKGx()
	{
		return B2f8Q2GTbrSuUb8siLbm;
	}
}
