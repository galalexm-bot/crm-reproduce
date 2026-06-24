using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component(Order = 100)]
public class ImgFilePreviewCreator : BaseFilePreviewCreatorEx
{
	public static Guid UID;

	internal static ImgFilePreviewCreator EXuXELG1AVmiHt4PSm9G;

	public override Guid Uid => UID;

	public override string DisplayName => SR.T((string)cmn1GhG10lxWwfpXaLN2(0x5A4C7B29 ^ 0x5A4F9775));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309722072),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AA993E),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFFC588),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105121188),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A80847E)
	};

	public override bool RequiredExternalCreator => false;

	public override string GetMainFileName(BinaryFile file)
	{
		return (string)wZerP6G1mYPyNnlX9nTU(file);
	}

	public override string GetPreviewText(BinaryFile file)
	{
		return null;
	}

	public override bool EnableGenerateHtml()
	{
		return false;
	}

	public ImgFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pJP7yRG1y8N1PvFcGLfX();
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

	static ImgFilePreviewCreator()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561167962));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object cmn1GhG10lxWwfpXaLN2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool li1XTrG17LLHEZOuh9gg()
	{
		return EXuXELG1AVmiHt4PSm9G == null;
	}

	internal static ImgFilePreviewCreator XGCDkdG1x4efSgF5OFm4()
	{
		return EXuXELG1AVmiHt4PSm9G;
	}

	internal static object wZerP6G1mYPyNnlX9nTU(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static void pJP7yRG1y8N1PvFcGLfX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
