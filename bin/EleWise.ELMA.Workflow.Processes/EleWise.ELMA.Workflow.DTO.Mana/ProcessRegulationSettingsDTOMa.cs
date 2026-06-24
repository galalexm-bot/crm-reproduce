using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class ProcessRegulationSettingsDTOManager : DTOManager, IProcessRegulationSettingsDTOManager, IConfigurationService
{
	internal static ProcessRegulationSettingsDTOManager o9e9tjPcNNErc52c5M7;

	public static IProcessRegulationSettingsDTOManager Instance => Locator.GetServiceNotNull<IProcessRegulationSettingsDTOManager>();

	public virtual ProcessRegulation LoadRegulationGlobalSettings()
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 4;
		int num2 = num;
		string key = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				key = (string)wstt5uPjMoSvjYxhpPB(-1941486619 ^ -1941491921);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (array != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			case 1:
				return ClassSerializationHelper.DeserializeObject(array) as ProcessRegulation;
			case 3:
				array = Locator.GetServiceNotNull<BlobStore>().LoadOrNull(key);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void SaveRegulationGlobalSettings(ProcessRegulation regulation)
	{
		int num = 2;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					W6mULKPSVbmjf9uwly8(regulation, wstt5uPjMoSvjYxhpPB(-1969850261 ^ -1969875813));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
				{
					BlobStore serviceNotNull = Locator.GetServiceNotNull<BlobStore>();
					byte[] array = (byte[])KpMmuZPk2aUg9toOmA1(regulation);
					oYZpvMPbDMHMFUjZeMh(serviceNotNull, text, array);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
					break;
				}
				break;
			}
			text = (string)wstt5uPjMoSvjYxhpPB(--47835757 ^ 0x2D986A7);
			num = 3;
		}
	}

	public ProcessRegulationSettingsDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object wstt5uPjMoSvjYxhpPB(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TI3pslPNjY44LOKM4gp()
	{
		return o9e9tjPcNNErc52c5M7 == null;
	}

	internal static ProcessRegulationSettingsDTOManager z0FLZOPdmoUrEH5cmi1()
	{
		return o9e9tjPcNNErc52c5M7;
	}

	internal static void W6mULKPSVbmjf9uwly8(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object KpMmuZPk2aUg9toOmA1(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void oYZpvMPbDMHMFUjZeMh(object P_0, object P_1, object P_2)
	{
		((BlobStore)P_0).Save((string)P_1, (byte[])P_2);
	}
}
