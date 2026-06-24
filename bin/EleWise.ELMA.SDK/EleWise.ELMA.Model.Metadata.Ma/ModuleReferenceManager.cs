using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

[Service(Type = ComponentType.Server, EnableInterceptors = false)]
internal sealed class ModuleReferenceManager : NHManager, IModuleReferenceManager
{
	internal static ModuleReferenceManager n2mOhgbUqtIpmtpjCsua;

	public void Save(ModuleReference moduleReference)
	{
		int num = 8;
		ModuleReference moduleReference2 = default(ModuleReference);
		string message = default(string);
		Guid metadataUid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					throw new Exception((string)Ken1DRbUTwkHMsHKkG5I(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1F1D8A)));
				case 1:
					if (F8meSwbUnMMxP0EblFKX(ICJQ3kbUkd8yZJooR2av(moduleReference2), moduleReference.ModuleUid))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 5:
					message = SR.T((string)djuV5ybUOJmBbZ7tuVfK(-521266112 ^ -521332636), ICJQ3kbUkd8yZJooR2av(moduleReference2), moduleReference.ModuleUid);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 6;
					}
					continue;
				default:
					throw new Exception(message);
				case 6:
					((ILogger)VgCOnpbU2qW3imnaqLvq()).Error(message);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (moduleReference2 == null)
					{
						FGkDvwbUeO4E3VVG8V6x(base.Session, moduleReference);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 7:
					if (!(metadataUid == Guid.Empty))
					{
						moduleReference2 = LoadOrNull(metadataUid);
						num2 = 2;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 8:
					break;
				case 3:
					return;
				}
				break;
			}
			metadataUid = moduleReference.MetadataUid;
			num = 7;
		}
	}

	public ModuleReference LoadOrNull(Guid metadataUid)
	{
		return base.Session.Get<ModuleReference>((object)metadataUid);
	}

	public ModuleReferenceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FUN5OYbUPkLobeij1AjQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Ken1DRbUTwkHMsHKkG5I(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Guid ICJQ3kbUkd8yZJooR2av(object P_0)
	{
		return ((ModuleReference)P_0).ModuleUid;
	}

	internal static bool F8meSwbUnMMxP0EblFKX(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object djuV5ybUOJmBbZ7tuVfK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VgCOnpbU2qW3imnaqLvq()
	{
		return Logger.Log;
	}

	internal static object FGkDvwbUeO4E3VVG8V6x(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static bool leI6RSbUKuRg8QNGshCB()
	{
		return n2mOhgbUqtIpmtpjCsua == null;
	}

	internal static ModuleReferenceManager rRDe3VbUXWmxCdSbuXHG()
	{
		return n2mOhgbUqtIpmtpjCsua;
	}

	internal static void FUN5OYbUPkLobeij1AjQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
