using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

[Service]
public class TemplateFileManager : ITemplateFileManager
{
	internal static TemplateFileManager Gu5cnUWMNR7ZOILAUxJq;

	protected IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

	public virtual string SaveTemplate(BinaryFile binaryFile)
	{
		return (string)AcUKcAWMall1xoKTtZw5(FileManager, binaryFile);
	}

	public virtual BinaryFile LoadTemplate(string id)
	{
		return FileManager.LoadFile(id);
	}

	public virtual BinaryFile CreateFromTemplate(string id)
	{
		int num = 2;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 2:
				binaryFile = (BinaryFile)hjX17JWMDfaOstQi573W(this, id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				throw new ObjectNotFoundException((string)LuKaIfWMtgcLV2YOq8cA(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A8389B6)), id);
			case 1:
				if (binaryFile != null)
				{
					return (BinaryFile)IOXaM0WM6kSTGPVcpUDo(((BinaryFileBuilder)djBI0aWMwwFmWAPE6AQ7(binaryFile)).Content(binaryFile.GetContent(GetContentOptions.NonSeekable), autoCloseStream: true, (string)F7pYhEWM49gnBCKsxlTe(binaryFile)));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetTemplateFileServerPath(string id)
	{
		return (string)juVOfcWM76nOvZpoLaQk(SICIT7WMA2rVP4Poaqcv(LoadTemplate(id) ?? throw new ObjectNotFoundException((string)LuKaIfWMtgcLV2YOq8cA(NiZ4UcWMHN87IOiT9DdS(0x1A33FE36 ^ 0x1A31CE34)), id)));
	}

	public TemplateFileManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p2aLgVWMxiFNU2ilL5xH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object AcUKcAWMall1xoKTtZw5(object P_0, object P_1)
	{
		return ((IFileManager)P_0).SaveFile((BinaryFile)P_1);
	}

	internal static bool qTxQynWM3ktsMaLXvrXT()
	{
		return Gu5cnUWMNR7ZOILAUxJq == null;
	}

	internal static TemplateFileManager owx9b1WMpMgHudCK6k1E()
	{
		return Gu5cnUWMNR7ZOILAUxJq;
	}

	internal static object hjX17JWMDfaOstQi573W(object P_0, object P_1)
	{
		return ((TemplateFileManager)P_0).LoadTemplate((string)P_1);
	}

	internal static object LuKaIfWMtgcLV2YOq8cA(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object djBI0aWMwwFmWAPE6AQ7(object P_0)
	{
		return BinaryFile.CreateFrom((BinaryFile)P_0);
	}

	internal static object F7pYhEWM49gnBCKsxlTe(object P_0)
	{
		return ((BinaryFile)P_0).Extension;
	}

	internal static object IOXaM0WM6kSTGPVcpUDo(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static object NiZ4UcWMHN87IOiT9DdS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SICIT7WMA2rVP4Poaqcv(object P_0)
	{
		return ((BinaryFile)P_0).ContentLocation;
	}

	internal static object juVOfcWM76nOvZpoLaQk(object P_0)
	{
		return ((Uri)P_0).LocalPath;
	}

	internal static void p2aLgVWMxiFNU2ilL5xH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
