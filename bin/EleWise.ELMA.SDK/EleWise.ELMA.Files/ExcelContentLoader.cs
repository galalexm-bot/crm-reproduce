using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

[Component(Order = 30)]
public class ExcelContentLoader : BaseFileContentLoader
{
	internal static ExcelContentLoader Q33vDeGTvNIRjW0JVbrY;

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3631B3DF),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787403345)
	};

	public override string GetText(string fileName)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_006d: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return base.GetText(text2);
			case 1:
			{
				Workbook val = new Workbook(fileName);
				string text = (string)epirHVGTu4lX6diI3ueP();
				text2 = (string)zGyYL2GTVZ4naATewAJP(xJwubGGTIeF54fPUc77S(0x42643203 ^ 0x4267D2AF), text);
				HtmlSaveOptions val2 = new HtmlSaveOptions((SaveFormat)12);
				yG4L8tGTSLrxQZyYxeJ3(val2, true);
				BJ8mqtGTixucdJDYTbkq((object)val, text2, val2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public override string GetText(Stream stream)
	{
		//Discarded unreachable code: IL_0074, IL_00ac, IL_00cb, IL_00da, IL_0107, IL_0175, IL_01ec, IL_020b, IL_021a, IL_0237, IL_0246
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		Stream stream2 = default(Stream);
		Workbook val = default(Workbook);
		string text = default(string);
		HtmlSaveOptions val2 = default(HtmlSaveOptions);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stream2 = stream;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					val = new Workbook(stream);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num6;
					if (stream2 == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num6 = 0;
						}
						goto IL_00b0;
					}
					goto IL_00e5;
					IL_00e5:
					((IDisposable)stream2).Dispose();
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num6 = 0;
					}
					goto IL_00b0;
					IL_00b0:
					switch (num6)
					{
					default:
						goto end_IL_008b;
					case 1:
						goto end_IL_008b;
					case 2:
						break;
					case 0:
						goto end_IL_008b;
					}
					goto IL_00e5;
					end_IL_008b:;
				}
				goto case 4;
			case 2:
				return text;
			case 4:
			{
				HtmlSaveOptions val3 = new HtmlSaveOptions((SaveFormat)12);
				val3.set_ExportActiveWorksheetOnly(true);
				val2 = val3;
				num2 = 3;
				break;
			}
			case 3:
				memoryStream = (MemoryStream)B7msGMGTRmXJLJUGpy95();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				try
				{
					fR98RNGTqZRRiMLm7v18(val, memoryStream, val2);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return text;
						case 1:
							text = base.GetText(memoryStream);
							num3 = 2;
							continue;
						}
						ymSK9SGTK3f9TLfGyZR9(memoryStream, 0L);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num4 = 1;
						}
						goto IL_01f0;
					}
					goto IL_0225;
					IL_0225:
					fa83HoGTXenB4sHKAtYa(memoryStream);
					num4 = 2;
					goto IL_01f0;
					IL_01f0:
					switch (num4)
					{
					case 1:
						goto end_IL_01cb;
					case 2:
						goto end_IL_01cb;
					}
					goto IL_0225;
					end_IL_01cb:;
				}
			}
		}
	}

	public ExcelContentLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KaosrSGTTI2LUsdBhUc9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object epirHVGTu4lX6diI3ueP()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object xJwubGGTIeF54fPUc77S(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zGyYL2GTVZ4naATewAJP(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void yG4L8tGTSLrxQZyYxeJ3(object P_0, bool P_1)
	{
		((HtmlSaveOptions)P_0).set_ExportActiveWorksheetOnly(P_1);
	}

	internal static void BJ8mqtGTixucdJDYTbkq(object P_0, object P_1, object P_2)
	{
		((Workbook)P_0).Save((string)P_1, (SaveOptions)P_2);
	}

	internal static bool OkjDTOGT8ccIRnKuVPVB()
	{
		return Q33vDeGTvNIRjW0JVbrY == null;
	}

	internal static ExcelContentLoader a4cGftGTZdISHw2wIbaq()
	{
		return Q33vDeGTvNIRjW0JVbrY;
	}

	internal static object B7msGMGTRmXJLJUGpy95()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void fR98RNGTqZRRiMLm7v18(object P_0, object P_1, object P_2)
	{
		((Workbook)P_0).Save((Stream)P_1, (SaveOptions)P_2);
	}

	internal static void ymSK9SGTK3f9TLfGyZR9(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static void fa83HoGTXenB4sHKAtYa(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void KaosrSGTTI2LUsdBhUc9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
