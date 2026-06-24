using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server, EnableInterceptors = false, InjectProperties = false)]
internal sealed class CustomActivityPublicationService : ICustomActivityPublicationService
{
	private readonly ICustomActivityManager customActivityManager;

	private static CustomActivityPublicationService cK2nsECiQ9hu80KvrEP;

	public CustomActivityPublicationService(ICustomActivityManager customActivityManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kRNi55CflGfQEjYgcZM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.customActivityManager = customActivityManager;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Publish(ICustomActivity customActivity)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				customActivityManager.GenerateCustomActivityParametersAssembly(customActivity);
				num2 = 4;
				break;
			case 4:
				if (customActivity.Header != null)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 3:
				customActivity.Save();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				GN37C4CJd98Pxu7tZ5K(customActivity, zqeLnsCLZNmlL75kclp(-133069941 ^ -133064123));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 5:
				TZ6uYtCrSDYlgp15tca(customActivity.Header, false);
				num2 = 3;
				break;
			}
		}
	}

	internal static void kRNi55CflGfQEjYgcZM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool SFaxGeCuC1Wkqkh8XvP()
	{
		return cK2nsECiQ9hu80KvrEP == null;
	}

	internal static CustomActivityPublicationService CnMJUFCl9OsAIm4Op2q()
	{
		return cK2nsECiQ9hu80KvrEP;
	}

	internal static object zqeLnsCLZNmlL75kclp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void GN37C4CJd98Pxu7tZ5K(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void TZ6uYtCrSDYlgp15tca(object P_0, bool value)
	{
		((ICustomActivityHeader)P_0).IsDirtyCustomActivity = value;
	}
}
