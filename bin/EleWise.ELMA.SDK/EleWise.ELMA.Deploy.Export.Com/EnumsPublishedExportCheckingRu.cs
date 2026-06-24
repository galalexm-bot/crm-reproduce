using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Components;

[Component]
internal sealed class EnumsPublishedExportCheckingRule : ObjectsPublishedExportCheckingRule
{
	internal static EnumsPublishedExportCheckingRule JHLZW0EsBHIjjeWujgk0;

	public EnumsPublishedExportCheckingRule(MetadataItemHeaderManager metadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		xyF33kEsbsKOsl9S9q7S();
		base._002Ector(metadataItemHeaderManager);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override IExportCheckingResult Check(IExportCheckingContext context)
	{
		//Discarded unreachable code: IL_00c4, IL_014a, IL_0159
		int num = 8;
		ObjectsExportSetting objectsExportSetting = default(ObjectsExportSetting);
		BaseExportCheckingResult result = default(BaseExportCheckingResult);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Check(objectsExportSetting.Enums, result);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (objectsExportSetting.Enums != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 8:
					tlvDU4EsGletVRlpTNxt(context, sx9oTXEshjnwQLOPLnqk(0x3A6135BE ^ 0x3A6171A8));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					if ((objectsExportSetting = value as ObjectsExportSetting) == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 4:
					if (!context.Settings.CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out value))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 7:
					result = new BaseExportCheckingResult();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
				case 5:
				case 6:
					break;
				}
				return result;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	protected override string PublishedMissed(string displayName)
	{
		return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477469224), displayName);
	}

	internal static void xyF33kEsbsKOsl9S9q7S()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MhOkBWEsW2lW7RsEAb0C()
	{
		return JHLZW0EsBHIjjeWujgk0 == null;
	}

	internal static EnumsPublishedExportCheckingRule uTJ5NmEsoXbIRoKIp2lR()
	{
		return JHLZW0EsBHIjjeWujgk0;
	}

	internal static object sx9oTXEshjnwQLOPLnqk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void tlvDU4EsGletVRlpTNxt(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}
