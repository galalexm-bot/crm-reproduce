using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

public class PageScriptModuleType : FormScriptModuleType<PageScriptCodeGenerationParams>
{
	public const string UID_S = "{C8A77AC7-5AB2-4E58-8FA3-2C93C40C8E34}";

	public static readonly Guid UID;

	internal static PageScriptModuleType u26YPTYAAinVUT5OkYR;

	public override Guid Uid => UID;

	public override string Name => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882172616));

	protected override string TemplateFileName => (string)yms7H9Y0pGFbXoJkBkn(-1822890472 ^ -1822938468);

	protected override string GetSummary(PageScriptCodeGenerationParams p)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				QNIDU0Ymy1GJPsjIgty(p, yms7H9Y0pGFbXoJkBkn(0x3CE17B75 ^ 0x3CE1B1AD));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				yv7s0KYycgTPW0XSqNl(p.Metadata, yms7H9Y0pGFbXoJkBkn(0x48A7E34A ^ 0x48A72994));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return SR.T((string)yms7H9Y0pGFbXoJkBkn(-210725949 ^ -210739451), XKX1qBYM8WmDYj3HM69(p.Metadata));
			}
		}
	}

	public PageScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PageScriptModuleType()
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
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)yms7H9Y0pGFbXoJkBkn(-629844702 ^ -629827106));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UPhhd0Y7hMmQlPCnrMI()
	{
		return u26YPTYAAinVUT5OkYR == null;
	}

	internal static PageScriptModuleType rCbUNnYxcweQSDweYyF()
	{
		return u26YPTYAAinVUT5OkYR;
	}

	internal static object yms7H9Y0pGFbXoJkBkn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void QNIDU0Ymy1GJPsjIgty(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void yv7s0KYycgTPW0XSqNl(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object XKX1qBYM8WmDYj3HM69(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
