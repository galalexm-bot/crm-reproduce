using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Deploy.Import;

public class FormItemImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static FormItemImportSaveActions HV0ynhlRS2TiJm84Zc5;

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == UID;
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		IFormMetadataItem formMetadataItem = entity as IFormMetadataItem;
		Func<string, TestImportMessages> func = (string e) => new TestImportMessages(TestImportMessagesType.Error, SR.T((string)_003C_003Ec.YTT0qcfjW3qPtj2aPOaQ(-1459557599 ^ -1459338357), e));
		if (formMetadataItem == null)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643816689));
			return new List<TestImportMessages> { func(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53C17D1))) };
		}
		if (formMetadataItem.Header == null)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87298083));
			return new List<TestImportMessages> { func(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606630616))) };
		}
		if (!(formMetadataItem.Metadata is FormMetadata formMetadata))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998582956));
			return new List<TestImportMessages> { func(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A75E5E))) };
		}
		formMetadata.Name = formMetadataItem.Header.Name;
		formMetadata.DisplayName = formMetadataItem.Header.DisplayName;
		return new List<TestImportMessages>();
	}

	public FormItemImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tsbv7flXvww9WZPaAYD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FormItemImportSaveActions()
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
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867780324));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool Vfmmg4lq1p9gPuYiYYU()
	{
		return HV0ynhlRS2TiJm84Zc5 == null;
	}

	internal static FormItemImportSaveActions ltgC1wlKpXAghJh2YEO()
	{
		return HV0ynhlRS2TiJm84Zc5;
	}

	internal static void tsbv7flXvww9WZPaAYD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
