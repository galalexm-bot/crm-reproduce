using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component(Order = 100)]
public class HtmlFilePreviewCreator : BaseFilePreviewCreatorEx
{
	public static Guid UID;

	internal static HtmlFilePreviewCreator RIPttqGe2kejKQt5Ztl8;

	public override Guid Uid => UID;

	public override string DisplayName => (string)c6JjN9GeNHUFTgyTk9RH(EpDMXVGe1B3kfgoTsOid(-643786247 ^ -643597303));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475974539),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D2B82)
	};

	public override bool RequiredExternalCreator => false;

	public override string GetMainFileName(BinaryFile file)
	{
		return (string)YTJBHLGe3TMy3qdVkQ5x(file);
	}

	public override string GetTextFileName(BinaryFile file)
	{
		return (string)YTJBHLGe3TMy3qdVkQ5x(file);
	}

	public override bool EnableGenerateHtml()
	{
		return false;
	}

	public HtmlFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static HtmlFilePreviewCreator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				F3WVroGepXFNiMCOpQjX();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)EpDMXVGe1B3kfgoTsOid(-576149596 ^ -575979124));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object EpDMXVGe1B3kfgoTsOid(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object c6JjN9GeNHUFTgyTk9RH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool dEIBa9GeeUXeSAUsrIbK()
	{
		return RIPttqGe2kejKQt5Ztl8 == null;
	}

	internal static HtmlFilePreviewCreator Y6YLp0GePyLQdOarnWfY()
	{
		return RIPttqGe2kejKQt5Ztl8;
	}

	internal static object YTJBHLGe3TMy3qdVkQ5x(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static void F3WVroGepXFNiMCOpQjX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
